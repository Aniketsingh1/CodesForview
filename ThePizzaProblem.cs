using System;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;
using System.Collections.Generic;

class CandidateCode
{

    public static void ManipulateTheString(dynamic param)
    {
        int count = 0;
        Dictionary<string, int> result = new Dictionary<string, int>();
        List<string> dataList = new List<string>();
        foreach (var key in param)
        {

            var value = key["toppings"];
            foreach (var val in value)
            {
                dataList.Add(val);
            }

        }
        var uniqueToopings = new HashSet<string>(dataList);// Pick out the unique combination of toppings to compare.
        foreach (var topping in uniqueToopings)
        {
            foreach (var toppings in dataList)
            {
                if (topping == toppings)
                {
                    count++;
                }
            }
            result.Add(topping, count);
            count = 0;
        }
        var sortedDict = (from entry in result orderby entry.Value descending select entry).Take(21); //Take top 20 toppings
        foreach (var mainTooping in sortedDict)
        {
            Console.WriteLine("Topping = {0}, No.OfTimesOrdered = {1}", mainTooping.Key, mainTooping.Value);
        }

        Console.ReadLine();

    }


    static void Main(String[] args)
    {
        string json = (new WebClient()).DownloadString(" http://files.olo.com/pizzas.json ");
        JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
        dynamic dobj = jsonSerializer.Deserialize<dynamic>(json);
        ManipulateTheString(dobj);

    }

}

