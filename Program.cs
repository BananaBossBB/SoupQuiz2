using System;

class Program
{
    static void Main(string[] args)
    {
        double max = 0;
        double min = 0;
        double mean = 0;
        double count = 0;

        bool loopBreak1 = true;
        while(loopBreak1 == true)
        {
            Console.Write("Input number or End : ");
            string str = Console.ReadLine();

            try 
            {
                double num = double.Parse(str);
                if(num > max)
                {
                    max = num;
                }
                if(num < min)
                {
                    min = num;
                }
                count++;

                mean = (mean + num)/count;

            }
                catch (FormatException) {
                Console.WriteLine("Input string is invalid.");
            }
            
            switch(str)
            {
                case "End":
                Console.Write("Enter FindMax or FindMin or FindMean : ");
                string mode = Console.ReadLine();
                loopBreak1 = false;
                {
                    bool loopBreak2 = true;
                    while(loopBreak2 == true)
                    {
                        switch(mode)
                        {
                            case "FindMax":
                            Console.WriteLine(max);
                            loopBreak2 = false;
                            break;
                            case "FindMin":
                            Console.WriteLine(min);
                            loopBreak2 = false;
                            break;
                            case "FindMean":
                            Console.WriteLine(mean);
                            loopBreak2 = false;
                            break;
                            default:
                            break;
                        }
                    }
                }
                break;
            }
        }
    }
}
