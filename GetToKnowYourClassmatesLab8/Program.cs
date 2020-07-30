using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab8GetToKnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> studentsAndYear = new Dictionary<string, string> ();
            //studentsAndYear.Add("Ann Takamaki", "Junior");
            //studentsAndYear.Add("Ryuji Yamamoto", "Junior");
            //studentsAndYear.Add("Makoto Nijima", "Senior");
            //{ "Ann Takamaki", "Junior" } "Ryuji Yomamoto", "Makoto Nijima", "Haru Okumura", "Yusuke Kitagawa" };
            //Hashtable studentCompendium = new Hashtable();
            //studentCompendium.Add(1, "Ann Takamaki");
            //studentCompendium.Add(2, "Ryuji Yamamoto");
            //studentCompendium.Add(3, "Makoto Nijima");
            //studentCompendium.Add(4, "Yusuke Kitagawa");
            //studentCompendium.Add(5, "Haru Okumura");
            //studentCompendium.Add("Ann Takamaki", "Junior");
            string[] studentArray = { "Ann", "Ryuji", "Makoto", "Yusuke", "Haru" };
            string[] annInfo = { "sophmore", "fashion", "Helsinki" };
            string[] ryujiInfo = { "junior", "track and field", "Tokyo" };
            string[] makotoInfo = { "senior", "criminal justice", "Kyoto" };
            string[] yusukeInfo = { "senior", "painting", "Okinawa" };
            string[] haruInfo = { "freshman", "gardening", "Honolulu" };


            string chooseStudentContinue = "y";
            while (chooseStudentContinue == "y")
            {


                Console.WriteLine("Which student would you like to know more about? (Enter a number 1-5)");
                try
                {
                    int studentNumber = int.Parse(Console.ReadLine());
                    studentNumber = studentNumber - 1;

                    //  Console.WriteLine(studentArray[studentNumber]);
                    string infocontinue = "y";
                    while (infocontinue == "y")
                    {
                        Console.WriteLine("What info would you like to know about " + studentArray[studentNumber] + "? 1.Class year 2.Hobby 3.Hometown");
                        int infoNumber = int.Parse(Console.ReadLine()) - 1;


                        if (studentNumber == 0)
                        {
                            Console.WriteLine(annInfo[infoNumber]);
                        }
                        else if (studentNumber == 1)
                        {
                            Console.WriteLine(ryujiInfo[infoNumber]);
                        }
                        else if (studentNumber == 2)
                        {
                            Console.WriteLine(makotoInfo[infoNumber]);
                        }
                        else if (studentNumber == 3)
                        {
                            Console.WriteLine(yusukeInfo[infoNumber]);
                        }
                        else if (studentNumber == 4)
                        {
                            Console.WriteLine(haruInfo[infoNumber]);
                        }

                        Console.WriteLine("Would you like to know more about " + studentArray[studentNumber] + "? Y/N");
                        infocontinue = Console.ReadLine().ToLower();
                    }
                    Console.WriteLine("Would you like to know about another student? Y/N");
                    chooseStudentContinue = Console.ReadLine().ToLower();
                }


                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid input. Please enter a number within range.");

                }
                catch (FormatException)
                {
                    Console.WriteLine("Oops! Seems like you didn't put a number in. Please enter number within range.");
                }

            }
        }
    }
}
