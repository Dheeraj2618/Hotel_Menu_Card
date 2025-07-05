using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.Marshalling;

namespace mini_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


 int total = 0;
            Console.WriteLine("------MD RESTAURANT----");
            Console.WriteLine("good mornig sir/madam.....................");
            do
            {
               
                Console.WriteLine("  ----kya lena pasand kroge--- \n 1.starter \n 2.maincourse \n 3.desert");
                int menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        {
                            do { 
                            Console.WriteLine("--------starter--------");
                            Console.WriteLine(" \n 1.springroll-RS150 \n 2.noodles-RS200 \n 3.chilli potato-Rs180 \n 4.manchurian-Rs300 \n 5.momos-Rs90 \n 6.pasta-Rs250 \n 7. chilli paneer-Rs400  ");
                            int start = Convert.ToInt32(Console.ReadLine());
                                switch (start)
                                {
                                    case 1:
                                        Console.WriteLine("\t Spring Roll");
                                        total += 150;
                                        Console.WriteLine("Total Amount:-  Rs. " + total);
                                        break;
                                    case 2:
                                        Console.WriteLine("\t noodles");
                                        total += 200;
                                        Console.WriteLine("Total Amount:-  Rs. " + total);
                                        break;
                                    case 3:
                                        Console.WriteLine("\t chilli potato");
                                        total += 180;
                                        Console.WriteLine("Total Amount:-  Rs." + total);
                                        break;
                                    case 4:
                                        Console.WriteLine("\t manchurian ");
                                        total += 300;
                                        Console.WriteLine("Total Amount:-  Rs." + total);

                                        break;
                                    case 5:
                                        Console.WriteLine("\t momos ");
                                        total += 90;
                                        Console.WriteLine("Total Amount:-  Rs." + total);


                                        break;
                                    case 6:
                                        Console.WriteLine("\t pasta ");
                                        total += 250;
                                        Console.WriteLine("Total Amount:-  Rs." + total);

                                        break;
                                    case 7:
                                        Console.WriteLine("\t chilli paneer ");
                                        total += 400;
                                        Console.WriteLine("Total Amount:-  Rs." + total);

                                        break;
                                    default:
                                        Console.WriteLine(" please enter valid starter choice");
                                        break;
                                 }     
                                Console.WriteLine("do you want more in starters");
                                } while (Console.ReadLine().ToLower() == "y") ;

                            
                        }

                        break;

                    case 2:
                        do { 
                        Console.WriteLine("--------maincourse--------");
                        Console.WriteLine(" \n 1.daal makhni-RS150 \n 2.tava paneer-RS200 \n 3. Butter paneer-Rs280 \n 4.mix veg-Rs200 \n 5.butter naan-Rs45");
                        int main = Convert.ToInt32(Console.ReadLine());
                            switch (main)
                            {
                                case 1:
                                    Console.WriteLine("\t daal makhni ");
                                    total += 150;
                                    Console.WriteLine("Total Amount:-  Rs." + total);
                                    break;
                                case 2:
                                    Console.WriteLine("\t tava paneer ");
                                    total += 200;
                                    Console.WriteLine("Total Amount:-  Rs." + total);
                                    break;
                                case 3:
                                    Console.WriteLine("\t Butter paneer ");
                                    total += 280;
                                    Console.WriteLine("Total Amount:-  Rs." + total);
                                    break;
                                case 4:
                                    Console.WriteLine("\t mix veg ");
                                    total += 200;
                                    Console.WriteLine("Total Amount:-  Rs." + total);
                                    break;
                                case 5:
                                    Console.WriteLine("\t butter naan");
                                    total += 45;
                                    Console.WriteLine("Total Amount:-  Rs." + total);
                                    break;

                                default:
                                    Console.WriteLine("please enter a valid main course choice");
                                    break;
                            }  Console.WriteLine("do you want mor in main course");

                        } while (Console.ReadLine().ToLower() == "y");

                        break;

                    case 3:
                        do { 
                        Console.WriteLine("--------Deserts--------");
                        Console.WriteLine(" \n 1.shake-RS150 \n 2.ras mlai-RS60 \n 3. ice cream-Rs180 \n 4.coldrink-Rs50 \n 5.choco lava-Rs45");
                        int desert = Convert.ToInt32(Console.ReadLine());
                            switch (desert)
                            {
                                case 1:
                                    Console.WriteLine("\t shake");
                                    total += 150;
                                    Console.WriteLine("Total Amount:-  Rs." + total);
                                    break;

                                case 2:
                                    Console.WriteLine("\t ras mlai");
                                    total += 60;
                                    Console.WriteLine("Total Amount:-  Rs." + total);
                                    break;

                                case 3:
                                    Console.WriteLine("\t ice cream");
                                    total += 180;
                                    Console.WriteLine("Total Amount:-  Rs." + total);
                                    break;
                                case 4:
                                    Console.WriteLine("\t cold drink");
                                    total += 50;
                                    Console.WriteLine("Total Amount:-  Rs." + total);
                                    break;
                                case 5:
                                    Console.WriteLine("\t choco lava");
                                    total += 45;
                                    Console.WriteLine("Total Amount:-  Rs." + total);
                                    break;

                                default:
                                    Console.WriteLine("please enter a valid desert choice");
                                    break;
                            }  Console.WriteLine("Do you want mor in dessert");
                        } while (Console.ReadLine().ToLower() == "y");

                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;

                }
                Console.WriteLine("do you wnat any thing else in any course");// restoautant mai ye pcuhta h vo sorry
            } while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine("thank you for comming...... \n have a nice day!");
        }
    }
}
