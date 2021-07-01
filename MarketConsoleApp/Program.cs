using MarketConsoleApp.Services;
using System;

namespace MarketConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Marketable marketable = new Marketable();

            bool myBool = false;
            bool sechim = false;

            while (!myBool)
            {
                Console.WriteLine("1 - Mehsullar uzerinde emeliyyat aparmaq");
                Console.WriteLine("2 - Satishlar uzerinde emeliyyat aparmaq");
                Console.WriteLine("3 - Sistemden chixmaq");
                Console.Write("Sechim edin: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        while (!sechim)
                        {
                            Console.WriteLine("1 - Yeni mehsul elave et");
                            Console.WriteLine("2 - Mehsul uzerinde duzelish et");
                            Console.WriteLine("3 - Mehsulu sil");
                            Console.WriteLine("4 - Butun mehsullari goster");
                            Console.WriteLine("5 - Kateqoriyaya uygun mehsullari goster");
                            Console.WriteLine("6 - Qiymet araligina gore mehsullari goster");
                            Console.WriteLine("7 - Ada gore mehsul axtar");
                            Console.WriteLine("8 - Esas menyuya qayitmaq");
                            Console.Write("Sechim edin: ");

                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.Clear();
                                    break;
                                case "2":
                                    Console.Clear();
                                    break;
                                case "3":
                                    Console.Clear();
                                    break;
                                case "4":
                                    Console.Clear();
                                    break;
                                case "5":
                                    Console.Clear();
                                    break;
                                case "6":
                                    Console.Clear();
                                    break;
                                case "7":
                                    Console.Clear();
                                    break;
                                case "8":
                                    Console.Clear();
                                    sechim = true;
                                    break;
                                default:
                                    Console.WriteLine("Duzgun sechim edin.");
                                    break;
                            }
                        }
                        sechim = false;
                        break;
                    case "2":
                        Console.Clear();
                        while (!sechim)
                        {
                            Console.WriteLine("1 - Yeni satish elave et");
                            Console.WriteLine("2 - Satishdan mehsul chixartmaq");
                            Console.WriteLine("3 - Satishin silinmesi");
                            Console.WriteLine("4 - Butun satishlari goster");
                            Console.WriteLine("5 - Tarix araligina gore satishlari goster");
                            Console.WriteLine("6 - Mebleg araligina gore satishlari goster");
                            Console.WriteLine("7 - Deqiq tarixe uygun satishlari goster");
                            Console.WriteLine("8 - Nomresine uygun satishin melumatlarini goster");
                            Console.WriteLine("9 - Esas menyuya qayit");
                            Console.Write("Sechim edin: ");

                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.Clear();
                                    break;
                                case "2":
                                    Console.Clear();
                                    break;
                                case "3":
                                    Console.Clear();
                                    break;
                                case "4":
                                    Console.Clear();
                                    break;
                                case "5":
                                    Console.Clear();
                                    break;
                                case "6":
                                    Console.Clear();
                                    break;
                                case "7":
                                    Console.Clear();
                                    break;
                                case "8":
                                    Console.Clear();
                                    break;
                                case "9":
                                    Console.Clear();
                                    sechim = true;
                                    break;
                                default:
                                    Console.WriteLine("Duzgun sechim edin.");
                                    break;
                            }
                        }
                        sechim = false;
                        break;
                    case "3":
                        myBool = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Duzgun sechim edin.");
                        break;
                }
            }

        }
        public static void Addorder(Marketable marketable)
        {
            bool oldloop = true;
            do
            {


            } while (oldloop);
        } 
    }
}
