using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    internal static class ProgramUi
    {
        

        // part 1 : before start year 
        public static int ShowMianMenu()
        {
            Console.Clear();
            Console.WriteLine(" -----------------------  Main Menu -----------------------");

            Console.WriteLine("1 ) Dumbledore Panel ");
            Console.WriteLine("2 ) Teachers Panel ");
            Console.WriteLine("3 ) Students Panel ");
            Console.WriteLine("\n4 ) Students travel ");
            Console.WriteLine("5 ) Exit the program ");

            Console.Write($" Enter Panel Number  : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int DumbledorePanel()
        {
            Console.Clear();
            Console.WriteLine(" ----------------------- Dumbledore Panel -----------------------");

            Console.WriteLine("1 ) Send message of acceptance to students ");
            Console.WriteLine("2 ) Setting lesson plans for teachers ");
            Console.WriteLine("3 ) Back to the main menu ");

            Console.Write($" Enter Panel Number  : ");
            return Convert.ToInt32(Console.ReadLine());

        }

        public static int StudentPanel()
        {

            Console.Clear();
            Console.WriteLine(" ----------------------- Student Panel -----------------------");

            Console.WriteLine("1 ) Received messages from Dumbledor ");
            Console.WriteLine("2 ) Set Education Plan (student of term 2,3,4 )");
            Console.WriteLine("3 ) Back to the main menu ");

            Console.Write($" Enter Panel Number  : ");
            return Convert.ToInt32(Console.ReadLine());

        }

        public static int TeacherPanel()
        {

            Console.Clear();
            Console.WriteLine(" ----------------------- Teacher Panel -----------------------");

            Console.WriteLine("1 ) view unit EducationPlan ");
            Console.WriteLine("2 ) Back to the main menu ");

            Console.Write($" Enter Panel Number  : ");
            return Convert.ToInt32(Console.ReadLine());

        }




        // part 2 : travel and recive to hoqwartz

        public static int EnteringHogwartsPanels()
        {
            Console.Clear();

            Console.WriteLine("-------------------------> The students are now in the cafeteria <-------------------------");
            Console.WriteLine("1) Grouping students ");
            Console.WriteLine("2) Giving dormitory numbers to students ");
            Console.WriteLine("3) Choosing courses unit ");


            Console.WriteLine("\n4) Go to the next panel (If things are done) ");
            Console.WriteLine("5) Exit the program");

            Console.Write($"\n Enter Panel Number  : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int StudentEducationPanle()
        {
            Console.Clear();
            Console.WriteLine("1) Set Plan for first semester students");
            Console.WriteLine("2) Set Plan for other students");

            Console.Write($" Enter Panel Number  : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void StudentTravel()
        {
            Console.Clear();

            if (Travelcondition1 == 1 && Travelcondition2 == 1)
            {
                Random rand = new Random();
                List<string> Move1 = new List<string>();
                List<string> Move2 = new List<string>();
                List<string> Move3 = new List<string>();
                for (int i = 0; i < Program.studentList.Count; i++)
                {
                    int randomNumber = rand.Next(3);
                    switch (randomNumber)
                    {
                        case 0:

                            Move1.Add(Program.studentList[i].FirstName);
                            break;

                        case 1:
                            Move2.Add(Program.studentList[i].FirstName);
                            break;

                        case 2:
                            Move3.Add(Program.studentList[i].FirstName);
                            break;
                    }

                }
                Console.WriteLine(" Students who boarded the train on Saturday 2023/06/25 ");
                Console.WriteLine("------------------------------------------------------");
                for (int i = 0; i < Move1.Count; i++)
                {
                    Console.Write(Move1[i] + "  ");
                }
                Console.WriteLine("\n");
                Console.WriteLine(" Students who boarded the train on Sonday 2023/06/26 ");
                Console.WriteLine("------------------------------------------------------");
                for (int i = 0; i < Move2.Count; i++)
                {
                    Console.Write(Move2[i] + "  ");
                }
                Console.WriteLine("\n");
                Console.WriteLine(" Students who boarded the train on Monday 2023/06/27 ");
                Console.WriteLine("------------------------------------------------------");
                for (int i = 0; i < Move3.Count; i++)
                {
                    Console.Write(Move3[i] + "  ");
                }


                Console.WriteLine("\n\n NOW The students arrived at Hogwarts");

            }
            else
            {
                Console.WriteLine("Some of the necessary processes have not been completed \n" +
                    "It can be one of the following \n" +
                    "1- Sending invitation letter by Dumbledore \n" +
                    "2- Curriculum selection by teachers");

            }

            Console.ReadKey();
        }




        // part 3 : during During the academic year 

        public static int FinalPanle()
        {
            Console.Clear();

            Console.WriteLine(" ------------------------- During the academic year Panels ------------------------- ");
            Console.WriteLine("1 ) Dumbledore Panel ");
            Console.WriteLine("2 ) Teachers Panel ");
            Console.WriteLine("3 ) Students Panel ");


            Console.WriteLine("\n5 ) Exit the program ");
            Console.Write($" Enter Panel Number  : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int FinalDumbledorePanel()
        {
            Console.Clear();
            Console.WriteLine(" ----------------------- Dumbledore Panel -----------------------");

            Console.WriteLine("1 ) answering to received messages from students ");
            //Console.WriteLine("2 ) ");

            //Console.WriteLine("4 ) Display student information ");
            Console.WriteLine("2) Back to the main menu ");
            Console.Write($" Enter Panel Number  : ");
            return Convert.ToInt32(Console.ReadLine());

        }
        public static int FinalStudentPanel()
        {

            Console.Clear();
            Console.WriteLine(" ----------------------- Student Panel -----------------------");

            Console.WriteLine("1 ) Send message for Dumbledor ");
            Console.WriteLine("2 ) The result of the sent message");
            Console.WriteLine("3 ) Education Plan ");
            Console.WriteLine("4 ) View Grades ");

            Console.WriteLine("5 ) Back to the main menu ");

            Console.Write($" Enter Panel Number  : ");
            return Convert.ToInt32(Console.ReadLine());

        }

        public static int FinalTeacherPanel()
        {

            Console.Clear();
            Console.WriteLine(" ----------------------- Teacher Panel -----------------------");

            Console.WriteLine("1 ) view unit EducationPlan ");
            Console.WriteLine("2 ) Grading students ");
            Console.WriteLine("3 ) Back to the main menu ");

            Console.Write($" Enter Panel Number  : ");
            return Convert.ToInt32(Console.ReadLine());

        }
        



        //  login  Methods 
        public static bool StudentLoginMethod()
        {
            Console.Clear();
            Console.WriteLine(" Enter the Stundet username and password ");
            Console.Write(" Enter Your Username : ");
            string username = Console.ReadLine();
            Console.Write(" Enter Your Password : ");
            string password = Console.ReadLine();


            if (Program.studentList.Any(p => p.UserName.Equals(username) && p.PassWord.Equals(password)))
            {

                UsernameSever = username;
                PasswordSever = password;
                int t1 = Program.studentList.FindIndex(user => user.UserName == username && user.PassWord == password);
                Console.WriteLine("welcome in your panel :    " + Program.studentList[t1].FirstName + " " + Program.studentList[t1].Lastname);
                

                return true;
            }
            else
            {
                Console.WriteLine(" Username or Password is wrong ");
                return false;
            }
            Console.ReadKey();
        }
        public static bool TeacherLoginMethod()
        {
            Console.Clear();
            Console.WriteLine("Enter the Teacher username and password ");
            Console.Write(" Enter Your Username : ");
            string username = Console.ReadLine();
            Console.Write(" Enter Your Password : ");
            string password = Console.ReadLine();
            if (Program.teacherlist.Any(p => p.UserName.Equals(username) && p.PassWord.Equals(password)))
            {
                TeacherUserSever = username;
                TeacherPasswordSever = password;
                int t2 = Program.teacherlist.FindIndex(user => user.UserName == username && user.PassWord == password);
                Console.WriteLine("welcome in your panel  : Teacher " + Program.teacherlist[t2].FirstName + " " + Program.teacherlist[t2].Lastname);
                Console.ReadKey();
                return true;

            }
            else
            {
                Console.WriteLine(" Username or Password is wrong ");
                Console.ReadKey();
                return false;
            }
            Console.ReadKey();
        }
        public static bool AdminLoginMethod()
        {
            Console.Clear();
            Console.WriteLine(" Enter the admin username and password ");
            Console.Write(" Enter Your Username : ");
            string username = Console.ReadLine();
            Console.Write(" Enter Your Password : ");
            string password = Console.ReadLine();

            if (username == Dumbledore.Admin.UserName && password == Dumbledore.Admin.PassWord)
            {
                Console.WriteLine(" login succeesfully ");
                Console.ReadKey();
                return true;
            }
            else
            {
                Console.WriteLine(" Username or Password is wrong ");
                Console.ReadKey();
                return false;
            }

        }

        public static string PasswordSever;
        public static string UsernameSever;
        public static string TeacherUserSever;
        public static string TeacherPasswordSever;

        public static void PressWrongKey()
        {
            Console.Clear();
            Console.WriteLine(" The entered number is incorrect ");
            Console.WriteLine(" Press a key to repeat the program ");
            Console.ReadKey();
        }




        public static int Travelcondition1 = 2;
        public static int Travelcondition2 = 2;

        public static bool StartYearcondition1 = false;
        public static bool StartYearcondition2 = false;



        // part 1 : send and recive letters 
        public static void SendMessagesForAcceptedStudents()
        {
            Console.Clear();

            Console.WriteLine(" The invitation message has been sent successfully \n message includes congratulations and ticket details ");

            Console.WriteLine(" \n ");

            Random rnd = new Random();
            Random rnd2 = new Random();

            string letterOfDubmbledore = 
                "You have been accepted to Hogwarts  , Congratulations on your acceptance " +
                $"\n your ticket time is : 2023/06/25 Saturday  10 a.m (If you do not arrive on the set date, you can on the dates Sunday and Mondy at 10 a.m ) " +
                $"\n You have to board at London train station " +
                $"\n your Train cabin number and chair is :  ";


            for (int k = 0; k < Program.studentList.Count; k++)
            {
                int randomNumber = rnd.Next(1,55);
                int randomNumber2 = rnd.Next(1,5);
                Program.studentList[k].RecivedLetter = letterOfDubmbledore + " cabin " + randomNumber  + " chair " + randomNumber2;
            }

            Console.WriteLine("press any key to continue ");
            Console.ReadKey();
            Travelcondition1 = 1;
         
        }
        public static void ReceivedmessagesfromDumbledor()
        {
            if (Travelcondition1 == 1)
            {
                if (Program.studentList.Any(p => p.UserName.Equals(UsernameSever) && p.PassWord.Equals(PasswordSever)))
                {
                    Console.Clear();
                    int t1 = Program.studentList.FindIndex(user => user.UserName == UsernameSever && user.PassWord == PasswordSever);
                    Console.WriteLine("miss or mr  :  " +Program.studentList[t1].FirstName +" "+ Program.studentList[t1].Lastname +"\n"+ Program.studentList[t1].RecivedLetter);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine(" Dumbledore did not send Massege for you " +
                "\n  press any key to cont.. ");
            }
            Console.ReadKey();
        }



        // part 3 : send and recive letters 

        public static List<string> RecivedLetterFromStudents = new List<string>();
        public static List<int> usernameSeverList = new List<int>();

        public static void SendMessagesForDumbledor()
        {
            Console.Clear();
            int IndexNumber = Program.studentList.FindIndex(user => user.UserName == UsernameSever && user.PassWord == PasswordSever);
            usernameSeverList.Add(IndexNumber);

            Console.WriteLine("Type your request letter : ");
            string TypedLetter = $"The student  : ( {Program.studentList[IndexNumber].FirstName + " " + Program.studentList[IndexNumber].Lastname}  ) has sent you a letter :\t" + Console.ReadLine();
            RecivedLetterFromStudents.Add(TypedLetter);


            Console.WriteLine("\nThe letter was sent successfully");
            Console.ReadKey();
        }

        public static void ReceivedmessagesfromStundets()
        {
            Console.Clear();

            for (int i = 0; i < RecivedLetterFromStudents.Count; i++)
            {
                Console.WriteLine(RecivedLetterFromStudents[i]);
                int x = usernameSeverList[i];
                Console.WriteLine("Type your answer : ");
                string answerLetter = Console.ReadLine();
                Program.studentList[x].LetterResult = answerLetter;
            }


            Console.WriteLine("press any key to continue ");
            Console.ReadKey();
        }

        public static void LetterResult()
        {
            Console.Clear();
            int IndexNumber = Program.studentList.FindIndex(user => user.UserName == UsernameSever && user.PassWord == PasswordSever);
           if (Program.studentList[IndexNumber].LetterResult != null)
            {
                Console.WriteLine(Program.studentList[IndexNumber].LetterResult);
            }
            else
            {
                Console.WriteLine("No results found. This can be due to the following reasons:\n 1- You have not sent a message \n 2- No answer has been received from Dumbledore yet");
            }
           
            Console.ReadKey();
        }

      


    



      


    }
}