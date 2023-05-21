using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    internal class Khabgah
    {
        public static List<Khabgah> MalekhabgahList = new List<Khabgah>();
        public static List<Khabgah> FamaleKhabgahList = new List<Khabgah>();

        public int DormGroup { get; set; }
        public int FloorNumber { get; set; } // طبقه

        public int RoomNumber { get; set; }

        public int BedNumber { get; set; }

        public int GenderTypeCode { get; set; }

        public string GenderType { get; set; }

        public Khabgah()
        { }

        public Khabgah(int x1, int x2, int x3, int x4, int x5)
        {
            DormGroup = x1;
            FloorNumber = x2;
            RoomNumber = x3;
            BedNumber = x4;
            GenderTypeCode = x5;

            if(x5 == 1)
            {
                GenderType = "male";
            }else if(x5 == 2)
            {
                GenderType = "famale";
            }

        }


        public static void SetDorm()
        {
            //studentList[20].khabgahNumber = 11111;
            //int x = studentList[20].khabgahNumber;


            Random rand = new Random();
            for (int i = 0; i < Program.studentList.Count ; i++)
            {

                if (Program.studentList[i].Gender == "male") // male code: 1 
                {
                loopHelp1: // goto 1 end
                    int e1 = 1;
                    int e2 = rand.Next(1,7);
                    int e3 = rand.Next(0,10);
                    int e4 = rand.Next(1,6);
                    int e5 = rand.Next(1, 6);

                    long yu = Convert.ToInt64(e1 + "" + e2 + "" + e3 + "" + e4);
                    if ( Program.studentList.Any(x => x.khabgahNumber.Equals(yu) ))
                    {
                        goto loopHelp1; // goto 1 start
                    }

                    Khabgah khabgahMale = new Khabgah(e5, e2, e3, e4, e1);
                    MalekhabgahList.Add(khabgahMale);

                    Program.studentList[i].khabgahNumber =  yu;
                }
                else if (Program.studentList[i].Gender == "female") 
                {
                 loopHelp2: // goto 2 end
                    int e1 = 2;
                    int e2 = rand.Next(1, 7);
                    int e3 = rand.Next(1, 11);
                    int e4 = rand.Next(1, 6);
                    int e5 = rand.Next(1, 6);

                    
                    long yu = Convert.ToInt64(e1 + "" + e2 + "" + e3 + "" + e4);
                    if (Program.studentList.Any(x => x.khabgahNumber.Equals(yu)))
                    {
                        goto loopHelp2; // goto 1 start
                    }

                    Khabgah khabgahWoman = new Khabgah(e1, e2, e3, e4, e5);
                    FamaleKhabgahList.Add(khabgahWoman);

                    Program.studentList[i].khabgahNumber = yu; 
                }
            }

        }

        public static void ShowDormInfo()
        {
            Console.Clear();
            Console.WriteLine("  Specifications of the received code from left to right:" +
                "\n 1- Men's or women's dormitory building Code 1: Men, Code 2: Women  " +
                "\n 2- Floor number" +
                "\n 3- Room number" +
                "\n 4- Bed number");
            for (int i = 0; i < Program.studentList.Count; i++)
            {

                Console.WriteLine(Program.studentList[i].FirstName + " dorm code : " + Program.studentList[i].khabgahNumber);

            }

            Console.ReadKey(); 
        }
    }


}
