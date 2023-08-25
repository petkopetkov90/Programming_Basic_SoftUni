using System;

namespace Travel_Agency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string type = Console.ReadLine();
            string vipOrNot = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double pricePerDay = 0.0;
            bool invalid = false;

            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else
            {
                if (city == "Bansko" || city == "Borovets")
                {
                    if (type == "noEquipment")
                    {
                        pricePerDay = 80;

                        if (vipOrNot == "yes")
                        {
                            pricePerDay = pricePerDay * 0.95;
                        }
                    }
                    else if (type == "withEquipment")
                    {
                        pricePerDay = 100;

                        if (vipOrNot == "yes")
                        {
                            pricePerDay = pricePerDay * 0.90;
                        }
                    }
                    else
                    {
                        invalid = true;
                    }
                }
                else if (city == "Varna" || city == "Burgas")
                {

                    if (type == "noBreakfast")
                    {
                        pricePerDay = 100;

                        if (vipOrNot == "yes")
                        {
                            pricePerDay = pricePerDay * 0.93;
                        }
                    }
                    else if (type == "withBreakfast")
                    {
                        pricePerDay = 130;

                        if (vipOrNot == "yes")
                        {
                            pricePerDay = pricePerDay * 0.88;
                        }
                    }
                    else
                    {
                        invalid = true;
                    }

                }
                else
                {
                    invalid = true;
                }

                if (days > 7)
                {
                    days = days - 1;
                }

                double total = days * pricePerDay;

                if (invalid)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    Console.WriteLine($"The price is {total:f2}lv! Have a nice time!");

                }
            }
        }
    }
}