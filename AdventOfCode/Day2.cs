using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdventOfCode
{
    internal class Day2
    {
        public long SolveFirstDay()
        {
            List<long> wrongIDs = new List<long>();
            List<string> ranges = new List<string>();
            List<long> from = new List<long>();
            List<long> to = new List<long>();
            long sum = 0;

            string input = File.ReadAllText("E:/domin/Documents/AdventOfCode/2025/Files/InputDay2-1.txt");
            int count = 0;

            //split by comma into ranges
            foreach (var ch in input)
            {
                count++;
                if (ch == ',')
                {
                    ranges.Add(input.Substring(0, count - 1));
                    input = input.Substring(count);
                    count = 0;
                }
            }

            foreach (var range in ranges)//split by - into from and to
            {
                from.Add(Int64.Parse(range.Substring(0, range.IndexOf('-'))));
                to.Add(Int64.Parse(range.Substring(range.IndexOf('-') + 1)));
            }

            for(int i = 0; i < from.Count; i++) //loop through ranges
            {
                for(long j = from[i]; j <= to[i]; j++)
                {
                    //count digits
                    int digits = 0;
                    foreach (var ch in j.ToString())
                    {
                        digits++;
                    }

                    if(digits % 2 == 0)
                    {
                        string firstHalf = j.ToString().Substring(0, digits / 2);
                        string secondHalf = j.ToString().Substring(digits / 2);
                        if(firstHalf == secondHalf)
                        {
                            wrongIDs.Add(j);
                        }
                    }
                }
            }
            foreach(var id in wrongIDs)
            {
                Console.WriteLine(id);
                sum += id;
            }
            return sum;
        }

    }
}
