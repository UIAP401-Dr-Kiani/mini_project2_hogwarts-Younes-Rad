using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hogwarts
{

    enum Nejad
    {
        Halfblood, Pureblood , Muggleblood 
    }
    internal class Person
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string DataOfBirth { get; set; }  
        public string Gender { get; set; }
        public string Father { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string PersonNejad { get; set; }

        public string  Role { get; set; }

        
        

    }
}
