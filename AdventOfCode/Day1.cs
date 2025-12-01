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
            Console.WriteLine("Day 1 / 1");

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
            Console.WriteLine("Day 1 / 2");

            int CurrentValue = 50;
            int count = 0;

            //string[] input = ["L50", "R6", "L15", "L18", "R24", "R28", "L29", "L41", "L13", "R49", "R18", "R36", "L28", "L10", "R16", "R1", "L47", "R4", "R45", "R45"];
            string[] input = File.ReadAllLines("E:/domin/Documents/AdventOfCode/2025/Files/InputDay1-2.txt");

            foreach (var line in input)
            {
                int value = int.Parse (line.Substring(1));
                if (line[0] == 'R')
                {
                    for (int i = 0; i < value; i++)
                    {
                        CurrentValue++;
                        if (CurrentValue > 99)
                        {
                            CurrentValue = 0;
                        }

                        if (CurrentValue == 0)
                        {
                            count++;
                        }
                    }
                    //while (CurrentValue > 99)
                    //{
                    //    CurrentValue -= 100;
                    //    count++;
                    //}
                }
                else
                {
                    //CurrentValue -= value;
                    for (int i = 0; i < value; i++)
                    {
                        CurrentValue--;
                        if (CurrentValue < 0)
                        {
                            CurrentValue = 99;
                        }

                        if (CurrentValue == 0)
                        {
                            count++;
                        }
                    }
                    //while (CurrentValue < 0)
                    //{
                    //    CurrentValue += 100;
                    //    count++;
                    //}
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
