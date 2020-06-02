using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/* Don't change anything here.
 * Do not add any other imports. You need to write
 * this program using only these libraries 
 */

namespace ProgramNamespace
{
    public class Program
    {

        /* DO NOT CHANGE ANYTHING ABOVE THIS LINE */

        public static Dictionary<String,int> processData(
                                        IEnumerable<string> lines)
        {
            Dictionary<int, int> engEmpDetails = new Dictionary<int, int>();
            Dictionary<int, int> testingEmpDetails = new Dictionary<int, int>();

            foreach (var item in lines)
            {
                int id = Convert.ToInt32(item.Split(',')[0]);
                string department = item.Split(',')[2];
                int salary = Convert.ToInt32(item.Split(',')[3]);
                if (department.Contains("Engineering"))
                {
                    engEmpDetails.Add(id, salary);
                }
                else
                {
                    testingEmpDetails.Add(id, salary);
                }

            }
            int engMaxKey = engEmpDetails.Keys.Max();
            int myengVal = engEmpDetails.FirstOrDefault(x => x.Key == engMaxKey).Value;
            int testingMaxKey = testingEmpDetails.Keys.Max();
            int mytestingVal = testingEmpDetails.FirstOrDefault(x => x.Key == testingMaxKey).Value;

            Dictionary<String, int> retVal = new Dictionary<String, int>();
            retVal.Add("Engineering", myengVal);
            retVal.Add("Testing", mytestingVal);
            return retVal;
        }

        /* DO NOT CHANGE ANYTHING BELOW THIS LINE */

        static void Main(string[] args)
        {
            try
            {
                Dictionary<String,int> retVal = processData(
                                      File.ReadAllLines("input.txt"));
                File.WriteAllLines("output.txt",
                    retVal.Select(x => x.Key + ": " + x.Value).ToArray());
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
