using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    internal class Student : AllowedPerson
    {
        public string passedUnit { get; set; }
        public int termNumber { get; set; }
        public long khabgahNumber { get; set; }
        public string RecivedLetter { get; set; }

        public string EducationPlanOfStudent { get; set; }
        public string Group { get; set; }

        public string LetterResult { get; set; }

        


        public Student() 
        { }

        public Student(string firsname , string lastname , string dateofbithday , string gender ,
            string father, string username, string password, string racetype, string role  )
        {
            FirstName = firsname;
            Lastname = lastname;
            DataOfBirth = dateofbithday;
            Gender = gender;
            Father = father;
            UserName = username;
            PassWord = password;
            PersonNejad = racetype;
            Role = role;
        }
        
       

        public static void SetTermNumber()
        {
            //Random rand = new Random();
            //int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;

            for (int i = 0; i < 55 ; i++)
            { 
                Program.studentList[i].termNumber = 1 ;
                
            }
            for (int i = 55; i < 110; i++)
            {
                Program.studentList[i].termNumber = 2;
            }
            for (int i = 110; i < 165; i++)
            {
                Program.studentList[i].termNumber = 3;
            }
            for(int i = 165; i< Program.studentList.Count; i++)
            {
                Program.studentList[i].termNumber = 4;
            }



            //for (int i = 0; i < Program.studentList.Count; i++)
            //{
            //    if (Program.studentList[i].termNumber == 1)
            //    {
            //        sum1 += 1;
            //    }
            //    else if (Program.studentList[i].termNumber == 2)
            //    {
            //        sum2 += 1;
            //    }
            //    else if (Program.studentList[i].termNumber == 3)
            //    {
            //        sum3 += 1;
            //    }
            //    else if (Program.studentList[i].termNumber == 4)
            //    {
            //        sum4 += 1;
            //    }


               
            //}
            //Console.WriteLine($"Number of first semester students  :{sum1}" +
            //       $"\nNumber of second semester students : {sum2}" +
            //       $"\nNumber of third semester students :{sum3}" +
            //       $"\nNumber of fourth semester student :{sum4} ");

        }
        
        public static void GroupingStudents()
        {
            Console.Clear();

            Random rand = new Random();
            string gr = "nothing";
            for (int i = 0; i < Program.studentList.Count ; i++)
            {
                int x = rand.Next(1, 5);
                switch (x)
                {
                    case 1:
                        gr = "Hufflepuff";
                        Program.studentList[i].Group = gr;
                        Groups.HufflepuffListNames.Add(Program.studentList[i].FirstName);
                        break;
                    case 2:
                        gr = "Gryffindor";
                        Program.studentList[i].Group = gr;
                        Groups.GryffindorNames.Add(Program.studentList[i].FirstName);
                        break;
                    case 3:
                        gr = "Ravenclaw";
                        Program.studentList[i].Group = gr;
                        Groups.RavenclawNames.Add(Program.studentList[i].FirstName);
                        break;
                    case 4:
                        gr = "Slytherin";
                        Program.studentList[i].Group = gr;
                        Groups.SlytherinNames.Add(Program.studentList[i].FirstName);
                        break;
                }
               
                Console.WriteLine(Program.studentList[i].FirstName + " " + Program.studentList[i].Lastname + " Group is : " + Program.studentList[i].Group );
            
            }
            
            Console.ReadKey();
        }

        public static void NumberOfGroupMembers()
        {
            int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;

            for (int i = 0; i < Program.studentList.Count; i++)
            {
                if (Program.studentList[i].Group == "Hufflepuff")
                {
                    sum1 += 1;
                }
                else if (Program.studentList[i].Group == "Gryffindor")
                {
                    sum2 += 1;
                }
                else if (Program.studentList[i].Group == "Ravenclaw")
                {
                    sum3 += 1;
                }
                else if (Program.studentList[i].Group == "Slytherin")
                {
                    sum4 += 1;
                }

            }

            Console.WriteLine($"Number of Hufflepuff students  :{sum1}" +
               $"\nNumber of Gryffindor students : {sum2}" +
               $"\nNumber of Ravenclaw students :{sum3}" +
               $"\nNumber of Slytherin student :{sum4} ");

            Console.ReadKey();
        }
           

         public static void SetEducationPlanForFirstSemesterStudents()
         {
            Console.Clear();
           
           

            List<Teacher> Chemistry1Teachers = new List<Teacher>();
            List<Teacher> MagicLearning1Teachers = new List<Teacher>();
            List<Teacher> Phytology1Teachers = new List<Teacher>();
            List<Teacher> Sport1Teachers = new List<Teacher>();
            List<Teacher> Astronomy1Teachers = new List<Teacher>();


            for (int i = 0; i < Program.teacherlist.Count; i++)
            {
               if( Program.teacherlist[i].TeacherLesson == "Chemistry1")
                {
                    Chemistry1Teachers.Add(Program.teacherlist[i]);
                }else if (Program.teacherlist[i].TeacherLesson == "MagicLearning1")
                {
                    MagicLearning1Teachers.Add(Program.teacherlist[i]);
                }else if (Program.teacherlist[i].TeacherLesson == "Phytology1")
                {
                    Phytology1Teachers.Add(Program.teacherlist[i]);
                }else if (Program.teacherlist[i].TeacherLesson == "Sport1")
                {
                    Sport1Teachers.Add(Program.teacherlist[i]);
                }else if (Program.teacherlist[i].TeacherLesson == "Astronomy1")
                {
                    Astronomy1Teachers.Add(Program.teacherlist[i]);
                }

           }

            for (int j = 0; j < 55 ; j++)
            {
                if (j < 15)
                {
                    Program.studentList[j].StudentEducationPlan =
                                      Chemistry1Teachers[0].TeacherEducationPlan + "\tTeacher : " + Chemistry1Teachers[0].FirstName + "  " + Chemistry1Teachers[0].Lastname + "\n" +
                                      MagicLearning1Teachers[0].TeacherEducationPlan + "\tTeacher : " + MagicLearning1Teachers[0].FirstName + "  " + MagicLearning1Teachers[0].Lastname + "\n" +
                                      Phytology1Teachers[0].TeacherEducationPlan + "\tTeacher : " + Phytology1Teachers[0].FirstName + "  " + Phytology1Teachers[0].Lastname + "\n" +
                                      Astronomy1Teachers[0].TeacherEducationPlan + "\tTeacher : " + Astronomy1Teachers[0].FirstName + "  " + Astronomy1Teachers[0].Lastname + "\n" +
                                      Sport1Teachers[0].TeacherEducationPlan + "\tTeacher : " + Sport1Teachers[0].FirstName + "  " + Sport1Teachers[0].Lastname + "\n";
                }
                else if (j < 30)
                {
                    Program.studentList[j].StudentEducationPlan =
                                      Chemistry1Teachers[1].TeacherEducationPlan + "\tTeacher : " + Chemistry1Teachers[1].FirstName + "  " + Chemistry1Teachers[1].Lastname + "\n" +
                                      MagicLearning1Teachers[1].TeacherEducationPlan + "\tTeacher : " + MagicLearning1Teachers[1].FirstName + "  " + MagicLearning1Teachers[1].Lastname + "\n" +
                                      Phytology1Teachers[1].TeacherEducationPlan + "\tTeacher : " + Phytology1Teachers[1].FirstName + "  " + Phytology1Teachers[1].Lastname + "\n" +
                                      Astronomy1Teachers[1].TeacherEducationPlan + "\tTeacher : " + Astronomy1Teachers[1].FirstName + "  " + Astronomy1Teachers[1].Lastname + "\n" +
                                      Sport1Teachers[1].TeacherEducationPlan + "\tTeacher : " + Sport1Teachers[1].FirstName + "  " + Sport1Teachers[1].Lastname + "\n";
                }
                else if (j < 45)
                {
                    Program.studentList[j].StudentEducationPlan =
                                      Chemistry1Teachers[2].TeacherEducationPlan + "\tTeacher : " + Chemistry1Teachers[2].FirstName + "  " + Chemistry1Teachers[2].Lastname + "\n" +
                                      MagicLearning1Teachers[2].TeacherEducationPlan + "\tTeacher : " + MagicLearning1Teachers[2].FirstName + "  " + MagicLearning1Teachers[2].Lastname + "\n" +
                                      Phytology1Teachers[2].TeacherEducationPlan + "\tTeacher : " + Phytology1Teachers[2].FirstName + "  " + Phytology1Teachers[2].Lastname + "\n" +
                                      Astronomy1Teachers[2].TeacherEducationPlan + "\tTeacher : " + Astronomy1Teachers[2].FirstName + "  " + Astronomy1Teachers[2].Lastname + "\n" +
                                      Sport1Teachers[2].TeacherEducationPlan + "\tTeacher : " + Sport1Teachers[2].FirstName + "  " + Sport1Teachers[2].Lastname + "\n";
                }
                else if (j < 55)
                {
                    Program.studentList[j].StudentEducationPlan =
                                      Chemistry1Teachers[3].TeacherEducationPlan + "\tTeacher : " + Chemistry1Teachers[3].FirstName + "  " + Chemistry1Teachers[3].Lastname + "\n" +
                                      MagicLearning1Teachers[3].TeacherEducationPlan + "\tTeacher : " + MagicLearning1Teachers[3].FirstName + "  " + MagicLearning1Teachers[3].Lastname + "\n" +
                                      Phytology1Teachers[3].TeacherEducationPlan + "\tTeacher : " + Phytology1Teachers[3].FirstName + "  " + Phytology1Teachers[3].Lastname + "\n" +
                                      Astronomy1Teachers[3].TeacherEducationPlan + "\tTeacher : " + Astronomy1Teachers[3].FirstName + "  " + Astronomy1Teachers[3].Lastname + "\n" +
                                      Sport1Teachers[3].TeacherEducationPlan + "\tTeacher : " + Sport1Teachers[3].FirstName + "  " + Sport1Teachers[3].Lastname + "\n";
                }


                Console.WriteLine(Program.studentList[j].FirstName +" " + Program.studentList[j].Lastname + "  plan is :\n " +
                                  "----------------------------------- \n" + Program.studentList[j].StudentEducationPlan);
             
                Console.ReadKey();
            }
        }


        public static void SetEducationPlanForStudentsByHand()// by hand 
        {
            Console.Clear();

                int studentIndex = Program.studentList.FindIndex(user => user.UserName == ProgramUi.UsernameSever && user.PassWord == ProgramUi.PasswordSever);
                int termNumber = Program.studentList[studentIndex].termNumber;
                int x;


                if (termNumber == 1)
                {
                Console.WriteLine(" your plan will be set by Admin when you recive to Hoqwarts ");
                }
                else if (termNumber == 2)
                {
                Console.WriteLine($"your term number is : {termNumber}");
                Console.WriteLine("you must chose lessens : Chemistry2 , MagicLearning2 , Phytology2 , Sport2  , Astronomy2");

                // Chemistry2 list 
                Console.WriteLine("\n choose from Chemistry2 Clases : ");
                for (int i = 0; i < Teacher.Chemistry2Teachers.Count; i++)
                {
                    Console.WriteLine($" {i + 1} : " + Teacher.Chemistry2Teachers[i].TeacherEducationPlan);
                }
                Console.Write(" choose one : ");
                x = Convert.ToInt32(Console.ReadLine());
                Program.studentList[studentIndex].StudentEducationPlan += Teacher.Chemistry2Teachers[x - 1].TeacherEducationPlan + "\n";
                // MagicLearning2 List
                Console.WriteLine("\n choose from MagicLearning2 Clases : ");
                for (int i = 0; i < Teacher.MagicLearning2Teachers.Count; i++)
                {
                    Console.WriteLine($" {i + 1} : " + Teacher.MagicLearning2Teachers[i].TeacherEducationPlan);
                }
                Console.Write(" choose one : ");
                x = Convert.ToInt32(Console.ReadLine());
                Program.studentList[studentIndex].StudentEducationPlan += Teacher.MagicLearning2Teachers[x - 1].TeacherEducationPlan + "\n";
                // Phytology2 List
                Console.WriteLine("\n choose from  Phytology2 Clases : ");
                for (int i = 0; i < Teacher.Phytology2Teachers.Count; i++)
                {
                    Console.WriteLine($" {i + 1} : " + Teacher.Phytology2Teachers[i].TeacherEducationPlan);
                }
                Console.Write(" choose one : ");
                x = Convert.ToInt32(Console.ReadLine());
                Program.studentList[studentIndex].StudentEducationPlan += Teacher.Phytology2Teachers[x - 1].TeacherEducationPlan + "\n";
                // Astronomy2 List
                Console.WriteLine("\n choose from  Phytology2 Clases : ");
                for (int i = 0; i < Teacher.Astronomy2Teachers.Count; i++)
                {
                    Console.WriteLine($" {i + 1} : " + Teacher.Astronomy2Teachers[i].TeacherEducationPlan);
                }
                Console.Write(" choose one : ");
                x = Convert.ToInt32(Console.ReadLine());
                Program.studentList[studentIndex].StudentEducationPlan += Teacher.Astronomy2Teachers[x - 1].TeacherEducationPlan + "\n";
                // Sport2 List
                Console.WriteLine("\n choose from  Sport2 Clases : ");
                for (int i = 0; i < Teacher.Sport2Teachers.Count; i++)
                {
                    Console.WriteLine($" {i + 1} : " + Teacher.Sport2Teachers[i].TeacherEducationPlan);
                }
                Console.Write(" choose one : ");
                x = Convert.ToInt32(Console.ReadLine());
                Program.studentList[studentIndex].StudentEducationPlan += Teacher.Sport2Teachers[x - 1].TeacherEducationPlan + "\n";




            }
                else if (termNumber == 3)
                {
                        Console.WriteLine($"your term number is : {termNumber}");
                        Console.WriteLine("you must chose lessens : Chemistry3 , MagicLearning3 , Phytology3 , Sport3  , Astronomy3");

                        // Chemistry3 list 
                        Console.WriteLine("\n choose from Chemistry3 Clases : ");
                        for (int i = 0; i < Teacher.Chemistry3Teachers.Count; i++)
                        {
                            Console.WriteLine($" {i + 1} : " + Teacher.Chemistry3Teachers[i].TeacherEducationPlan);
                        }
                        Console.Write(" choose one : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Program.studentList[studentIndex].StudentEducationPlan += Teacher.Chemistry3Teachers[x - 1].TeacherEducationPlan + "\n";
                        // MagicLearning3 List
                        Console.WriteLine("\n chose from MagicLearning3 Clases : ");
                        for (int i = 0; i < Teacher.MagicLearning3Teachers.Count; i++)
                        {
                            Console.WriteLine($" {i + 1} : " + Teacher.MagicLearning3Teachers[i].TeacherEducationPlan);
                        }
                        Console.Write(" choose one : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Program.studentList[studentIndex].StudentEducationPlan += Teacher.MagicLearning3Teachers[x - 1].TeacherEducationPlan + "\n";
                        // Phytology3 List
                        Console.WriteLine("\n choose from  Phytology3 Clases : ");
                        for (int i = 0; i < Teacher.Phytology3Teachers.Count; i++)
                        {
                            Console.WriteLine($" {i + 1} : " + Teacher.Phytology3Teachers[i].TeacherEducationPlan);
                        }
                        Console.Write(" choose one : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Program.studentList[studentIndex].StudentEducationPlan += Teacher.Phytology3Teachers[x - 1].TeacherEducationPlan + "\n";
                        // Astronomy3 List
                        Console.WriteLine("\n chose from  Astronomy3 Clases : ");
                        for (int i = 0; i < Teacher.Astronomy3Teachers.Count; i++)
                        {
                            Console.WriteLine($" {i + 1} : " + Teacher.Astronomy3Teachers[i].TeacherEducationPlan);
                        }
                        Console.Write(" choose one : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Program.studentList[studentIndex].StudentEducationPlan += Teacher.Astronomy3Teachers[x - 1].TeacherEducationPlan + "\n";
                        // Sport3 List
                        Console.WriteLine("\n choose from  Sport3 Clases : ");
                        for (int i = 0; i < Teacher.Sport3Teachers.Count; i++)
                        {
                            Console.WriteLine($" {i + 1} : " + Teacher.Sport3Teachers[i].TeacherEducationPlan);
                        }
                        Console.Write(" choose one : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Program.studentList[studentIndex].StudentEducationPlan += Teacher.Sport3Teachers[x - 1].TeacherEducationPlan + "\n";

            }
                else if (termNumber == 4)
                {
                Console.WriteLine($"your term number is : {termNumber}");
                Console.WriteLine("you must chose lessens : Chemistry4 , MagicLearning4 , Phytology4 , Sport4  , Astronomy4 ");

                // Chemistry2 list 
                Console.WriteLine("\n choose from Chemistry4 Clases : ");
                for (int i = 0; i < Teacher.Chemistry4Teachers.Count; i++)
                {
                    Console.WriteLine($" {i + 1} : " + Teacher.Chemistry4Teachers[i].TeacherEducationPlan);
                }
                Console.Write(" choose one : ");
                x = Convert.ToInt32(Console.ReadLine());
                Program.studentList[studentIndex].StudentEducationPlan += Teacher.Chemistry4Teachers[x - 1].TeacherEducationPlan + "\n";
                // MagicLearning2 List
                Console.WriteLine("\n choose from MagicLearning4 Clases : ");
                for (int i = 0; i < Teacher.MagicLearning4Teachers.Count; i++)
                {
                    Console.WriteLine($" {i + 1} : " + Teacher.MagicLearning4Teachers[i].TeacherEducationPlan);
                }
                Console.Write(" choose one : ");
                x = Convert.ToInt32(Console.ReadLine());
                Program.studentList[studentIndex].StudentEducationPlan += Teacher.MagicLearning4Teachers[x - 1].TeacherEducationPlan + "\n";
                // Phytology4 List
                Console.WriteLine("\n chose from  Phytology4 Clases : ");
                for (int i = 0; i < Teacher.Phytology4Teachers.Count; i++)
                {
                    Console.WriteLine($" {i + 1} : " + Teacher.Phytology4Teachers[i].TeacherEducationPlan);
                }
                Console.Write(" choose one : ");
                x = Convert.ToInt32(Console.ReadLine());
                Program.studentList[studentIndex].StudentEducationPlan += Teacher.Phytology4Teachers[x - 1].TeacherEducationPlan + "\n";
                // Astronomy4 List
                Console.WriteLine("\n chose from  Astronomy2 Clases : ");
                for (int i = 0; i < Teacher.Astronomy4Teachers.Count; i++)
                {
                    Console.WriteLine($" {i + 1} : " + Teacher.Astronomy4Teachers[i].TeacherEducationPlan);
                }
                Console.Write(" choose one : ");
                x = Convert.ToInt32(Console.ReadLine());
                Program.studentList[studentIndex].StudentEducationPlan += Teacher.Astronomy4Teachers[x - 1].TeacherEducationPlan + "\n";
                // Sport4 List
                Console.WriteLine("\n chose from  Sport4 Clases : ");
                for (int i = 0; i < Teacher.Sport4Teachers.Count; i++)
                {
                    Console.WriteLine($" {i + 1} : " + Teacher.Sport4Teachers[i].TeacherEducationPlan);
                }
                Console.Write(" choose one : ");
                x = Convert.ToInt32(Console.ReadLine());
                Program.studentList[studentIndex].StudentEducationPlan += Teacher.Sport4Teachers[x - 1].TeacherEducationPlan + "\n";

            }

            Console.WriteLine($"\nstudent : {Program.studentList[studentIndex].FirstName }  {Program.studentList[studentIndex].Lastname}" +
                $"\nyour choosed plan is :\n ------------------------------ \n {Program.studentList[studentIndex].StudentEducationPlan}");

        }


        public static void SetListLesson()
        {

            for (int i = 0; i < Program.teacherlist.Count; i++)
            {
                if (Program.teacherlist[i].TeacherLesson == "Chemistry2")
                {
                    Teacher.Chemistry2Teachers.Add(Program.teacherlist[i]);
                }
                else if (Program.teacherlist[i].TeacherLesson == "MagicLearning2")
                {
                    Teacher.MagicLearning2Teachers.Add(Program.teacherlist[i]);
                }
                else if (Program.teacherlist[i].TeacherLesson == "Phytology2")
                {
                    Teacher.Phytology2Teachers.Add(Program.teacherlist[i]);
                }
                else if (Program.teacherlist[i].TeacherLesson == "Sport2")
                {
                    Teacher.Sport2Teachers.Add(Program.teacherlist[i]);
                }
                else if (Program.teacherlist[i].TeacherLesson == "Astronomy2")
                {
                    Teacher.Astronomy2Teachers.Add(Program.teacherlist[i]);
                }
            }

            for (int i = 0; i < Program.teacherlist.Count; i++)
            {
                if (Program.teacherlist[i].TeacherLesson == "Chemistry3")
                {
                    Teacher.Chemistry3Teachers.Add(Program.teacherlist[i]);
                }
                else if (Program.teacherlist[i].TeacherLesson == "MagicLearning3")
                {
                    Teacher.MagicLearning3Teachers.Add(Program.teacherlist[i]);
                }
                else if (Program.teacherlist[i].TeacherLesson == "Phytology3")
                {
                    Teacher.Phytology3Teachers.Add(Program.teacherlist[i]);
                }
                else if (Program.teacherlist[i].TeacherLesson == "Sport3")
                {
                    Teacher.Sport3Teachers.Add(Program.teacherlist[i]);
                }
                else if (Program.teacherlist[i].TeacherLesson == "Astronomy3")
                {
                    Teacher.Astronomy3Teachers.Add(Program.teacherlist[i]);
                }
            }

            for (int i = 0; i < Program.teacherlist.Count; i++)
            {
                if (Program.teacherlist[i].TeacherLesson == "Chemistry4")
                {
                    Teacher.Chemistry4Teachers.Add(Program.teacherlist[i]);
                }
                else if (Program.teacherlist[i].TeacherLesson == "MagicLearning4")
                {
                    Teacher.MagicLearning4Teachers.Add(Program.teacherlist[i]);
                }
                else if (Program.teacherlist[i].TeacherLesson == "Phytology4")
                {
                    Teacher.Phytology4Teachers.Add(Program.teacherlist[i]);
                }
                else if (Program.teacherlist[i].TeacherLesson == "Sport4")
                {
                    Teacher.Sport4Teachers.Add(Program.teacherlist[i]);
                }
                else if (Program.teacherlist[i].TeacherLesson == "Astronomy4")
                {
                    Teacher.Astronomy4Teachers.Add(Program.teacherlist[i]);
                }
            }


        }
    }
}
//Random rand = new Random();
//int x1 = 0, x2, x3, x4;
//x1 = rand.Next();
//x2 = rand.Next(MagicLearning1Teachers.Count);
//x3 = rand.Next(Phytology1Teachers.Count);
//x4 = rand.Next(Sport1Teachers.Count);
///////////////////
//int t1 = Program.teacherlist.FindIndex(u => u.TeacherEducationPlan == Chemistry1Teachers[x1].TeacherEducationPlan);
//int t2 = Program.teacherlist.FindIndex(u => u.TeacherEducationPlan == MagicLearning1Teachers[x2].TeacherEducationPlan);
//int t3 = Program.teacherlist.FindIndex(u => u.TeacherEducationPlan == Phytology1Teachers[x3].TeacherEducationPlan);
//int t4 = Program.teacherlist.FindIndex(u => u.TeacherEducationPlan == Sport1Teachers[x4].TeacherEducationPlan);
//Program.teacherlist[t1].ClassCapacity += 1;
//Program.teacherlist[t2].ClassCapacity += 1;

/////////////////////////
//    int t1 = Program.teacherlist.FindIndex(u => u.TeacherEducationPlan == Chemistry1Teachers[x1].TeacherEducationPlan);
//    int t2 = Program.teacherlist.FindIndex(u => u.TeacherEducationPlan == MagicLearning1Teachers[x2].TeacherEducationPlan);
//    int t3 = Program.teacherlist.FindIndex(u => u.TeacherEducationPlan == Phytology1Teachers[x3].TeacherEducationPlan);
//    int t4 = Program.teacherlist.FindIndex(u => u.TeacherEducationPlan == Sport1Teachers[x4].TeacherEducationPlan);


//loopp:

//    if (Chemistry1Teachers[x1].TeacherEducationPlan == Program.teacherlist[t1].TeacherEducationPlan)
//    {
//        sum1 += 1;
//        Program.teacherlist[t1].ClassCapacity += 1;
//    }
//    if (MagicLearning1Teachers[x2].TeacherEducationPlan == Program.teacherlist[t2].TeacherEducationPlan)
//    {
//        sum2 += 1;
//        Program.teacherlist[t2].ClassCapacity += 1;
//    }
//    if (Phytology1Teachers[x3].TeacherEducationPlan == Program.teacherlist[t3].TeacherEducationPlan)
//    {
//        sum3 += 1;
//        Program.teacherlist[t3].ClassCapacity += 1;
//    }
//    if (Sport1Teachers[x4].TeacherEducationPlan == Program.teacherlist[t4].TeacherEducationPlan)
//    {
//        sum4 += 1;
//        Program.teacherlist[t4].ClassCapacity += 1;
//    }


//    if (sum1 < 41 )
//    {
//        s1 = Chemistry1Teachers[x1].TeacherEducationPlan + "\tTeacher : " + Chemistry1Teachers[x1].FirstName + "  " + Chemistry1Teachers[x1].Lastname;
//    }
//    else
//    {
//        x1 = rand.Next(Chemistry1Teachers.Count);
//        sum1 = sum1 -  1;sum2 -= 1;sum3 -= 1;sum4 -= 1;
//        goto loopp;
//    }
//    if (sum2 <41)
//    {
//        s2 = MagicLearning1Teachers[x2].TeacherEducationPlan + "\tTeacher : " + MagicLearning1Teachers[x2].FirstName + "  " + MagicLearning1Teachers[x2].Lastname;
//    }
//    else
//    {
//        x2 = rand.Next(MagicLearning1Teachers.Count);
//        sum1 -= 1; sum2 -= 1; sum3 -= 1; sum4 -= 1;
//        goto loopp;
//    }
//    if (sum3 < 41)
//    {
//        s3 = Phytology1Teachers[x3].TeacherEducationPlan + "\tTeacher : " + Phytology1Teachers[x3].FirstName + "  " + Phytology1Teachers[x3].Lastname;
//    }
//    else
//    {
//        x3 = rand.Next(Phytology1Teachers.Count);
//        sum1 -= 1; sum2 -= 1; sum3 -= 1; sum4 -= 1;
//        goto loopp;
//    }
//    if (sum4 < 41)
//    {
//        s4 = Sport1Teachers[x4].TeacherEducationPlan + "\tTeacher : " + Sport1Teachers[x4].FirstName + "  " + Sport1Teachers[x4].Lastname ;
//    }
//    else
//    {
//        x4 = rand.Next(Sport1Teachers.Count);
//        sum1 -= 1; sum2 -= 1; sum3 -= 1; sum4 -= 1;
//        goto loopp;
//    }
