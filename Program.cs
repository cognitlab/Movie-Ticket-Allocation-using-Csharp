using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace extra_MovieTicketAllocation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n\t\t\t\t\t\tThere are 5 cinemas in ur city");
            Console.WriteLine("Select Movie From Given :=\n");
            Console.WriteLine("\t\t1.KANTAARA");
            Console.WriteLine("\t\t2.MONEY HEIST");
            Console.WriteLine("\t\t3.SQUID GAME");
            Console.WriteLine("\t\t4.HERA PHERI");
            Console.WriteLine("\t\t5.WEDNESDAY");


            int i;
            for (i = 0; i <= 5; i++)
                {
                    Console.Write("\nENTER YOUR NUMBER = ");
                    i = int.Parse(Console.ReadLine());
                    if (i == 1)
                    {
                        Console.WriteLine("\n---------------Kantaara-------------------");
                        Console.WriteLine("There are 50 Tickets Available");
                        Console.Write("Enter How much want = ");
                        int j = int.Parse(Console.ReadLine());
                            Console.WriteLine("Given = {0}", j);
                            Console.WriteLine("Now Available = {0}", 50 - j);
                            Console.WriteLine("\n<--------Positions----------->");
                            Console.WriteLine("\n1.Orchestra(Down) => 70rs");
                            Console.WriteLine("\n2.Mezzanine(Middle) =>90rs");
                            Console.WriteLine("\n3.Balcony(Box Office) =>120rs");
                            Console.Write("\nSelect any one from above = ");
                            int p = int.Parse(Console.ReadLine());
                            if (p == 1)
                            {
                                Console.WriteLine("\n\t\t\t\t Rupees {0} have to pay", j * 70);
                            }
                            else if (p == 2)
                            {
                                Console.WriteLine("\n\t\t\t\t Rupees {0} have to pay", j * 90);
                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\t\t Rupees {0} have to pay", j * 120);
                            }
                        }

                    
                    else if (i == 2)
                    {
                        Console.WriteLine("\n---------------Money Heist-------------------");
                        Console.WriteLine("\nThere are 150 Tickets Available");
                        Console.Write("\nEnter How much want = ");
                        int j = int.Parse(Console.ReadLine());
                        {
                            Console.WriteLine("\nGiven = {0}", j);
                            Console.WriteLine("\nNow Available = {0}", 150 - j);
                            Console.WriteLine("\n<--------Positions----------->");
                            Console.WriteLine("\n1.Orchestra(Down) => 70rs");
                            Console.WriteLine("\n2.Mezzanine(Middle) =>90rs");
                            Console.WriteLine("\n3.Balcony(Box Office) =>120rs");
                            Console.Write("\nSelect any one from above = ");
                            int p = int.Parse(Console.ReadLine());
                            if (p == 1)
                            {
                                Console.WriteLine("\n\t\t\t\t Rupees {0} have to pay", j * 70);
                            }
                            else if (p == 2)
                            {
                                Console.WriteLine("\n\t\t\t\t Rupees {0} have to pay", j * 90);
                            }
                            else {
                                Console.WriteLine("\n\t\t\t\t Rupees {0} have to pay", j * 120);
                            }
                        }
                    }
                    else if (i == 3)
                    {
                        Console.WriteLine("\n---------------Squid Game-------------------");
                        Console.WriteLine("\nThere are 250 Tickets Available");
                        Console.Write("\nEnter How much want = ");
                        int j = int.Parse(Console.ReadLine());
                        {
                            Console.WriteLine("\nGiven = {0}", j);
                            Console.WriteLine("\nNow Available = {0}", 250 - j);
                            Console.WriteLine("\n<--------Positions----------->");
                            Console.WriteLine("\n1.Orchestra(Down) => 70rs");
                            Console.WriteLine("\n2.Mezzanine(Middle) =>90rs");
                            Console.WriteLine("\n3.Balcony(Box Office) =>120rs");
                            Console.Write("\nSelect any one from above = ");
                            int p = int.Parse(Console.ReadLine());
                            if (p == 1)
                            {
                                Console.WriteLine("\n\t\t\t\t Rupees {0} have to pay", j * 70);
                            }
                            else if (p == 2)
                            {
                                Console.WriteLine("\n\t\t\t\t Rupees {0} have to pay", j * 90);
                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\t\t Rupees {0} have to pay", j * 120);
                            }
                        }
                    }
                    else if (i == 4)
                    {
                        Console.WriteLine("\n---------------Hera Pheri-------------------");
                        Console.WriteLine("\nThere are 200 Tickets Available");
                        Console.Write("\nEnter How much want = ");
                        int j = int.Parse(Console.ReadLine());
                        {
                            Console.WriteLine("\nGiven = {0}", j);
                            Console.WriteLine("\nNow Available = {0}", 200 - j);
                            Console.WriteLine("\n<--------Positions----------->");
                            Console.WriteLine("\n1.Orchestra(Down) => 70rs");
                            Console.WriteLine("\n2.Mezzanine(Middle) =>90rs");
                            Console.WriteLine("\n3.Balcony(Box Office) =>120rs");
                            Console.Write("\nSelect any one from above = ");
                            int p = int.Parse(Console.ReadLine());
                            if (p == 1)
                            {
                                Console.WriteLine("\n\t\t\t\t Rupees {0} have to pay", j * 70);
                            }
                            else if (p == 2)
                            {
                                Console.WriteLine("\n\t\t\t\t Rupees {0} have to pay", j * 90);
                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\t\t Rupees {0} have to pay", j * 120);
                            }
                        }
                    }
                    else if (i == 5)
                    {
                        Console.WriteLine("\n---------------Wednesday-------------------");
                        Console.WriteLine("\nThere are 70 Tickets Available");
                        Console.Write("\nEnter How much want = ");
                        int j = int.Parse(Console.ReadLine());
                        {
                            Console.WriteLine("\nGiven = {0}", j);
                            Console.WriteLine("\nNow Available = {0}", 70 - j);
                            Console.WriteLine("\n<--------Positions----------->");
                            Console.WriteLine("\n1.Orchestra(Down) => 70rs");
                            Console.WriteLine("\n2.Mezzanine(Middle) =>90rs");
                            Console.WriteLine("\n3.Balcony(Box Office) =>120rs");
                            Console.Write("\nSelect any one from above = ");
                            int p = int.Parse(Console.ReadLine());
                            if (p == 1)
                            {
                                Console.WriteLine("\n\t\t\t\t Rupees {0} have to pay", j * 70);
                            }
                            else if (p == 2)
                            {
                                Console.WriteLine("\n\t\t\t\t Rupees {0} have to pay", j * 90);
                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\t\t Rupees {0} have to pay", j * 120);
                            }
                           
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t----------Bye!! Bye!!----------");
                    }

                }
                Console.ReadKey();
            }

        }
    }

    