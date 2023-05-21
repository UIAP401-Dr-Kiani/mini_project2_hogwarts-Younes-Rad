using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{


    internal class AllowedPerson : Person
    {
        enum Pet
        {
            rat, cat, owl
        }

        enum Role
        {
            teacher, student
        }


        public string StudentEducationPlan { get; set; }
        public string TeacherEducationPlan { get; set; }
        public bool Suitcase { get; set; }
        public string[] Receivedletter { get; set; }

        

       

    }
}
