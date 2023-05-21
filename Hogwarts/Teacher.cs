using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    internal class Teacher : AllowedPerson
    {

        public bool SimultaneousTeaching { get; set; }

        public string TeacherLesson { get; set; }

        public int ClassCapacity { get; set; }


        public Teacher() { }
        public Teacher(string firsname, string lastname, string dateofbithday, string gender,
            string father, string username, string password, string racetype, string role)
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



        public static List<Teacher> Chemistry1Teachers = new List<Teacher>();
        public static List<Teacher> MagicLearning1Teachers = new List<Teacher>();
        public static List<Teacher> Phytology1Teachers = new List<Teacher>();
        public static List<Teacher> Sport1Teachers = new List<Teacher>();
        public static List<Teacher> Astronomy1Teachers = new List<Teacher>();

        public static List<Teacher> Chemistry2Teachers = new List<Teacher>();
        public static List<Teacher> MagicLearning2Teachers = new List<Teacher>();
        public static List<Teacher> Phytology2Teachers = new List<Teacher>();
        public static List<Teacher> Sport2Teachers = new List<Teacher>();
        public static List<Teacher> Astronomy2Teachers = new List<Teacher>();

        public static List<Teacher> Chemistry3Teachers = new List<Teacher>();
        public static List<Teacher> MagicLearning3Teachers = new List<Teacher>();
        public static List<Teacher> Phytology3Teachers = new List<Teacher>();
        public static List<Teacher> Sport3Teachers = new List<Teacher>();
        public static List<Teacher> Astronomy3Teachers = new List<Teacher>();

        public static List<Teacher> Chemistry4Teachers = new List<Teacher>();
        public static List<Teacher> MagicLearning4Teachers = new List<Teacher>();
        public static List<Teacher> Phytology4Teachers = new List<Teacher>();
        public static List<Teacher> Sport4Teachers = new List<Teacher>();
        public static List<Teacher> Astronomy4Teachers = new List<Teacher>();




        public static List<Chemistry> ChemistryClasses = new List<Chemistry>()
        {
             new Chemistry { lessonName = "Chemistry1" , TermNumber = 1 , Capacity = 40 , lessonTime = "Saturday: 8 to 9"},
             new Chemistry { lessonName = "Chemistry1" , TermNumber = 1 , Capacity = 40 , lessonTime = "Monday: 8 to 9"},
             new Chemistry { lessonName = "Chemistry2" , TermNumber = 2 , Capacity = 40 , lessonTime = "Saturday: 9 to 10"},
             new Chemistry { lessonName = "Chemistry2" , TermNumber = 2 , Capacity = 40 , lessonTime = "Monday: 9 to 10"},
             new Chemistry { lessonName = "Chemistry3" , TermNumber = 3 , Capacity = 40 , lessonTime = "Saturday: 10 to 11"},
             new Chemistry { lessonName = "Chemistry3" , TermNumber = 3 , Capacity = 40 , lessonTime = "Monday: 10 to 11"},
             new Chemistry { lessonName = "Chemistry4" , TermNumber = 4 , Capacity = 40 , lessonTime = "Saturday: 11 to 12"},
             new Chemistry { lessonName = "Chemistry4" , TermNumber = 4 , Capacity = 40 , lessonTime = "Monday: 11 to 12"}
        };

        public static List<MagicLearning> MagicLearningClasses = new List<MagicLearning>()
        {
             new MagicLearning { lessonName = "MagicLearning1" , TermNumber = 1 , Capacity = 40 , lessonTime = "Saturday: 12 to 13"},
             new MagicLearning { lessonName = "MagicLearning1" , TermNumber = 1 , Capacity = 40 , lessonTime = "Monday: 12 to 13"},
             new MagicLearning { lessonName = "MagicLearning2" , TermNumber = 2 , Capacity = 40 , lessonTime = "Saturday: 13 to 14"},
             new MagicLearning { lessonName = "MagicLearning2" , TermNumber = 2 , Capacity = 40 , lessonTime = "Monday: 13 to 14"},
             new MagicLearning { lessonName = "MagicLearning3" , TermNumber = 3 , Capacity = 40 , lessonTime = "Saturday: 14 to 15"},
             new MagicLearning { lessonName = "MagicLearning3" , TermNumber = 3 , Capacity = 40 , lessonTime = "Monday: 14 to 15"},
             new MagicLearning { lessonName = "MagicLearning4" , TermNumber = 4 , Capacity = 40 , lessonTime = "Saturday: 15 to 16"},
             new MagicLearning { lessonName = "MagicLearning4" , TermNumber = 4 , Capacity = 40 , lessonTime = "Monday: 15 to 16"}
        };

        public static List<Phytology> PhytologyClasses = new List<Phytology>()
        {
             new Phytology { lessonName = "Phytology1" , TermNumber = 1 , Capacity = 40, lessonTime = "Sunday: 8 to 9"},
             new Phytology { lessonName = "Phytology1" , TermNumber = 1 , Capacity = 40, lessonTime = "Tuesday: 8 to 9"},
             new Phytology { lessonName = "Phytology2" , TermNumber = 2 , Capacity = 40, lessonTime = "Sunday: 9 to 10"},
             new Phytology { lessonName = "Phytology2" , TermNumber = 2 , Capacity = 40, lessonTime = "Tuesday: 9 to 10"},
             new Phytology { lessonName = "Phytology3" , TermNumber = 3 , Capacity = 40, lessonTime = "Sunday: 10 to 12"},
             new Phytology { lessonName = "Phytology3" , TermNumber = 3 , Capacity = 40, lessonTime = "Tuesday: 10 to 12"},
             new Phytology { lessonName = "Phytology4" , TermNumber = 4 , Capacity = 40, lessonTime = "Sunday: 11 to 12"},
             new Phytology { lessonName = "Phytology4" , TermNumber = 4 , Capacity = 40, lessonTime = "Tuesday: 11 to 12"}
        };

        public static List<Astronomy> AstronomyClasses = new List<Astronomy>()
        {
            new Astronomy { lessonName = "Astronomy1" , TermNumber = 1 , Capacity = 40, lessonTime = "Sunday: 12 to 13"},
            new Astronomy { lessonName = "Astronomy1" , TermNumber = 1 , Capacity = 40, lessonTime = "Tuesday: 12 to 13"},
            new Astronomy { lessonName = "Astronomy2" , TermNumber = 2 , Capacity = 40, lessonTime = "Sunday: 13 to 14"},
            new Astronomy { lessonName = "Astronomy2" , TermNumber = 2 , Capacity = 40, lessonTime = "Tuesday: 13 to 14 "},
            new Astronomy { lessonName = "Astronomy3" , TermNumber = 3 , Capacity = 40, lessonTime = "Sunday: 14 to 15"},
            new Astronomy { lessonName = "Astronomy3" , TermNumber = 3 , Capacity = 40, lessonTime = "Tuesday: 14 to 15"},
            new Astronomy { lessonName = "Astronomy4" , TermNumber = 4 , Capacity = 40, lessonTime = "Sunday: 15 to 16"},
            new Astronomy { lessonName = "Astronomy4" , TermNumber = 4 , Capacity = 40, lessonTime = "Tuesday: 15 to 16"}
        };

        public static List<Sport> SportClasses = new List<Sport>()
        {
             new Sport { lessonName = "Sport1" , TermNumber = 1 , Capacity = 40, lessonTime = "Wednesday: 8 to 9"},
             new Sport { lessonName = "Sport1" , TermNumber = 1 , Capacity = 40, lessonTime = "Wednesday: 9 to 10"},
             new Sport { lessonName = "Sport2" , TermNumber = 2 , Capacity = 40, lessonTime = "Wednesday: 10 to 11"},
             new Sport { lessonName = "Sport2" , TermNumber = 2 , Capacity = 40, lessonTime = "Wednesday: 11 to 12"},
             new Sport { lessonName = "Sport3" , TermNumber = 3 , Capacity = 40, lessonTime = "Wednesday: 12 to 13"},
             new Sport { lessonName = "Sport3" , TermNumber = 3 , Capacity = 40, lessonTime = "Wednesday: 13 to 14"},
             new Sport { lessonName = "Sport4" , TermNumber = 4 , Capacity = 40, lessonTime = "Wednesday: 14 to 15"},
             new Sport { lessonName = "Sport4" , TermNumber = 4 , Capacity = 40, lessonTime = "Wednesday: 15 to 16"}
        };

        


        public static void setTeacherLesson()
        {
            Console.Clear();

           for (int i = 0; i < Program.teacherlist.Count ; i++) // set Lesson From List
            {
                Lesson l2 = new Lesson();
                if (i < 8)
                {
                    l2 = ChemistryClasses[i]; 
                }
                if (8 <= i && i < 16) 
                {
                    l2 = MagicLearningClasses[i - 8];
                }
                if (16 <= i && i<24)
                {
                    l2 = PhytologyClasses[i-16];
                }
                if (24 <= i && i<32)
                {
                    l2 = AstronomyClasses[i-24];
                }
                if (32 <= i && i < 40)
                {
                    l2 = SportClasses[i - 32];
                }
                if (40 <= i && i < 48)
                {
                    l2 = ChemistryClasses[i - 40];
                }
                if (48 <= i && i < 56)
                {
                    l2 = MagicLearningClasses[i - 48];
                }
                if (56 <= i && i < 64)
                {
                    l2 = PhytologyClasses[i - 56];
                }
                if (64 <= i && i < 72)
                {
                    l2 = AstronomyClasses[i - 64];
                }
                if (72 <= i && i < 80)
                {
                    l2 = SportClasses[i - 72]; 
                }
               
                Program.teacherlist[i].TeacherEducationPlan = $" Teacher : {Program.teacherlist[i].FirstName}  {Program.teacherlist[i].Lastname}   " +  l2.lessonName + "    " + l2.lessonTime ;
                Program.teacherlist[i].TeacherLesson = l2.lessonName;
            }

            for (int i = 0; i < Program.teacherlist.Count; i++) // print 
            {
                Console.WriteLine( Program.teacherlist[i].TeacherEducationPlan + "\n");
            }

            Console.ReadKey();
        }

    }
}
//Random rand = new Random();
//for (int i = 32; i < Program.teacherlist.Count; i++)
//{
//    Lesson l1 = new Lesson();
//    int u = rand.Next(4);
//    int t = rand.Next(8);
//    switch (u)
//    {
//        case 0:
//            l1 = ChemistryClasses[t];
//            break;
//        case 1:
//            l1 = MagicLearningClasses[t];
//            break;
//        case 2:
//            l1 = PhytologyClasses[t];
//            break;
//        case 3:
//            l1 = SportClasses[t];
//            break;
//    }

//    Program.teacherlist[i].TeacherEducationPlan = l1.lessonName + "    " + l1.lessonTime;
//    Program.teacherlist[i].TeacherLesson = l1.lessonName;
//}



//for (int i = 0; i < 2 ; i++)
// {
//     for (int j = 0; j < 64 ; j++)
//     {
//         Lesson l2 = new Lesson();
//         if (j < 8)
//         {

//             l2 = ChemistryClasses[j];
//             Program.teacherlist[j].TeacherEducationPlan = l2.lessonName + "    " + l2.lessonTime;
//         }


//     }

// }



//if (i < 16)
//{

//}
//else if (i > 15 && i < 32)
//{
//    Program.teacherlist[i].TeacherEducationPlan =  l1.lessonName + l1.lessonTime;
//    Program.teacherlist[i].TeacherLesson = l1.lessonName;
//    Console.WriteLine("Teacher  : " + Program.teacherlist[i].FirstName + "  " + Program.teacherlist[i].TeacherEducationPlan + "\n");
//}
//else if (i > 31 && i < 48)
//{
//    Program.teacherlist[i].TeacherEducationPlan = l1.lessonName + "    " + l1.lessonTime ;
//    Program.teacherlist[i].TeacherLesson = l1.lessonName;
//    Console.WriteLine("Teacher  : " + Program.teacherlist[i].FirstName + "  " + Program.teacherlist[i].TeacherEducationPlan + "\n");
//}
//else if (i > 47 && i < 64)
//{
//    Program.teacherlist[i].TeacherEducationPlan = l1.lessonName + "    " + l1.lessonTime ;
//    Program.teacherlist[i].TeacherLesson = l1.lessonName;
//    Console.WriteLine("Teacher  : " + Program.teacherlist[i].FirstName + "  " + Program.teacherlist[i].TeacherEducationPlan + "\n");
//}
//else if (i > 63 && i < 80)
//{
//    Program.teacherlist[i].TeacherEducationPlan = l1.lessonName + "    " + l1.lessonTime ;
//    Program.teacherlist[i].TeacherLesson = l1.lessonName;
//    Console.WriteLine("Teacher  : " + Program.teacherlist[i].FirstName + "  " + Program.teacherlist[i].TeacherEducationPlan + "\n");

//}