using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hogwarts
{
    internal class Program
    {

        public static List<Student> studentList = new List<Student>();
        public static List<Teacher> teacherlist = new List<Teacher>();

       
        static void Main(string[] args)
        {



            #region فایل تعریف نمونه

            using (StreamReader file = new StreamReader(@"file.tsv")) 
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    string[] human = ln.Split('\t').ToArray<string>();

                    if (human[8] == "student")
                    {
                        Student student = new Student(human[0], human[1], human[2], human[3], human[4], human[5], human[6], human[7], human[8]);
                        studentList.Add(student);
                    }

                    else if (human[8] == "teacher")
                    {
                        Teacher teacher = new Teacher(human[0], human[1], human[2], human[3], human[4], human[5], human[6], human[7], human[8]);
                        teacherlist.Add(teacher);
                    }

                }
                file.Close();
            }
            Student.SetTermNumber();

            Dumbledore.Admin.UserName = "admin";
            Dumbledore.Admin.PassWord = "admin";


            #endregion پایان 


            #region پنل ها 

            bool loop = true;
            bool loop2 = true;
            bool loop3 = true;

            bool t1, t2, t3 ;
            bool z1, z2, z3;

            int secondPanels;
            int thirdPanels;
            int panelNumber = ProgramUi.ShowMianMenu();

            while (loop == true) ///////////////////// loop 1
            {

                switch (panelNumber)    // main menu
                {

                    case 1:
                        if (t1 = ProgramUi.AdminLoginMethod())
                        {
                            while (t1 == true)
                            {
                                switch (ProgramUi.DumbledorePanel())  //  dumbledor panel
                                {
                                    case 1:
                                        ProgramUi.SendMessagesForAcceptedStudents();
                                        break;

                                    case 2:
                                        Teacher.setTeacherLesson();
                                        ProgramUi.Travelcondition2 = 1;
                                        Teacher.MakeListLesson();
                                        break;

                                    case 3:
                                        panelNumber = ProgramUi.ShowMianMenu();
                                        t1 = false;
                                        break;
                                }
                            }
                        }
                        break;

                    case 2:
                        if (t2 = ProgramUi.TeacherLoginMethod())
                        {
                            while (t2 == true)
                            {
                                switch (ProgramUi.TeacherPanel())  //  teacher  panel
                                {
                                    case 1:
                                        ProgramUi.EducationPlanOfTeacher();
                                        break;
                                 
                                    case 2:
                                        panelNumber = ProgramUi.ShowMianMenu();
                                        t2 = false;
                                        break;

                                }
                            }
                        }
                            break;

                    case 3:
                        if (t3 = ProgramUi.StudentLoginMethod())
                        {
                            while (t3 == true)
                            {
                                switch (ProgramUi.StudentPanel())   //  student panel
                                {

                                    case 1:
                                        ProgramUi.ReceivedmessagesfromDumbledor();
                                        break;

                                    case 2:
                                       
                                        Student.SetEducationPlanForStudentsByHand();
                                        Console.ReadKey();
                                        break;

                                    case 3:
                                        panelNumber = ProgramUi.ShowMianMenu();
                                        t3 = false;
                                        break;
                                }
                            }
                        }
                            break;

                    case 4:
                            if (ProgramUi.Travelcondition1 == 1 && ProgramUi.Travelcondition2 == 1)
                            {
                                ProgramUi.StudentTravel();
                                loop = false;
                            }
                            else
                            {
                                ProgramUi.StudentTravel();
                                panelNumber = ProgramUi.ShowMianMenu();
                            }
                      
                        break;
                    


                    case 5:  // Exit Panel
                        loop = false;
                        loop2 = false;
                        loop3 = false;
                        break;


                    case 9:
                        loop = false;
                        break;
                    default:
                        ProgramUi.PressWrongKey();
                        panelNumber = ProgramUi.ShowMianMenu();
                        break;

                }
                Console.Clear();
               
            } ////////////////// End loop 1


            while (loop2) ///////////////// loop 2
            {
               switch (secondPanels = ProgramUi.EnteringHogwartsPanels())
                {
                    case 1:
                        Student.GroupingStudents();
                        Console.WriteLine("\n");
                        Student.NumberOfGroupMembers();

                        //secondPanels = ProgramUi.EnteringHogwartsPanels();
                        break;
                    case 2:
                        Khabgah.SetDorm();
                        Khabgah.ShowDormInfo();
                        break;
                    case 3:
                        switch (ProgramUi.StudentEducationPanle())
                        {

                            case 1:
                                Student.SetEducationPlanForFirstSemesterStudents();
                                break;
                            case 2:
                                Student.SetPlanForTerm2ByDefult();
                                Student.SetPlanForTerm3ByDefult();
                                Student.SetPlanForTerm4ByDefult();
                                break;
                        }
                        break;

                    case 4:
                      if (ProgramUi.StartYearcondition1 == true && ProgramUi.StartYearcondition2)
                        {
                            loop2 = false;
                        }
                      else
                        {
                            Console.WriteLine(" task are not done yet ");
                        }
                        break;
                    case 5:
                        loop2 = false;
                        loop3 = false;
                        break;

                    case 9:
                        loop2 = false;
                        break;

                    default:
                        ProgramUi.PressWrongKey();
                        
                        break;

                }
                
            }///////////////////////  END loop2

            
            while (loop3 == true)////////////////////////////////// loop 3 
            {
                switch(thirdPanels = ProgramUi.FinalPanle())
                {
                    case 1:
                        if (z1 = ProgramUi.AdminLoginMethod())
                        {
                            while (z1 == true)
                            {
                                switch (ProgramUi.FinalDumbledorePanel())  //  dumbledor panel
                                {
                                    case 1:
                                        ProgramUi.ReceivedmessagesfromStundets();
                                        break;
                                    case 2:
                                        z1 = false;
                                        break;
                                    
                                }
                            }
                        }
                        break; 
                    case 2:
                        if (z2 = ProgramUi.TeacherLoginMethod())
                        {
                            while (z2 == true)
                            {
                                switch (ProgramUi.FinalTeacherPanel())  //  teacher  panel
                                {
                                    case 1:
                                        ProgramUi.EducationPlanOfTeacher();
                                        break;
                                    case 2:
                                        Teacher.GreadingToStudents();
                                        break;
                                    case 3:
                                        z2 = false;
                                        break;

                                }
                            }
                            break;
                        }
                        break;
                    case 3:
                        if (z3 = ProgramUi.StudentLoginMethod())
                        {
                            while (z3 == true)
                            {
                                switch (ProgramUi.FinalStudentPanel())   //  student panel
                                {

                                    case 1:
                                        ProgramUi.SendMessagesForDumbledor();
                                        break;

                                    case 2:
                                        ProgramUi.LetterResult();
                                        break;
                                    case 3:
                                        Student.viewStudentPlan();
                                        break;
                                    case 4:
                                        Student.viewGrade();
                                        
                                        break;
                                    case 5:
                                        z3 = false;
                                        break;
                                    
                                }
                            }
                            break;
                        }
                        break;

                    case 4:
                        loop3 = false;
                        break;

                    default:
                        ProgramUi.PressWrongKey();
                        break;
                }

            }///////////////////// loop3 



            Console.Clear();
            Console.WriteLine(" The program is finished ");
        }
        #endregion

    }
}
