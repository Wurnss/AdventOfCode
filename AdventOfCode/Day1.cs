using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day1
    {
        public int SolveFirstDay()
        {
            int CurrentValue = 50;
            int count = 0;

            string[] input = File.ReadAllLines("E:/domin/Documents/AdventOfCode/2025/Files/InputDay1-1.txt");

            foreach (var line in input)
            {
                if (line[0] == 'R')
                {
                    int value = int.Parse(line.Substring(1));
                    CurrentValue += value;
                    while (CurrentValue > 99)
                    {
                        CurrentValue -= 100;
                    }
                }
                else
                {
                    int value = int.Parse(line.Substring(1));
                    CurrentValue -= value;
                    while (CurrentValue < 0)
                    {
                        CurrentValue += 100;
                    }
                }
                if (CurrentValue == 0)
                {
                    count += 1;
                }
            }
            return count;
        }

        public int SolveSecondDay()
        {
            int CurrentValue = 50;
            int count = 0;

            //string[] input = ["L50", "R6", "L15", "L18", "R24", "R28", "L29", "L41", "L13", "R49", "R18", "R36", "L28", "L10", "R16", "R1", "L47", "R4", "R45", "R45"];
            //string[] input = ["L201", "R300"];
            //string[] input = ["R150", "R50"];
            string[] input = File.ReadAllLines("E:/domin/Documents/AdventOfCode/2025/Files/InputDay1-2.txt");

            foreach (var line in input)
            {
                int value = int.Parse(line.Substring(1));
                int wraps = 0;
                if (line[0] == 'R')
                {
                    for(int i = 0; i < value; i++)
                    {
                        CurrentValue++;
                        if (CurrentValue > 99)
                        {
                            CurrentValue = 0;
                            count++;
                            wraps++;
                        }
                    }
                    if (CurrentValue == 0 )//when landing on 0
                    {
                        count--;
                    }
                }
                else
                {
                    if (CurrentValue == 0)//when starting on 0
                    {
                        count--;
                    }
                    for (int i = 0; i < value; i++)
                    {
                        CurrentValue--;
                        if (CurrentValue < 0)
                        {
                            CurrentValue = 99;
                            count++;
                            wraps++;
                        }
                    }
                }
                if (CurrentValue == 0)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
