using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    internal class Groups : AllowedPerson
    {

        enum Groupsss
        {
            Hufflepuff , Gryffindor , Ravenclaw , Slytherin

        }

        public int Point { get; set; }
        public string GroupList { get; set; }
        public string ListOfQuidditchPlayers { get; set; }



        public static List<string> HufflepuffListNames = new List<string>();
        public static List<string> GryffindorNames = new List<string>();
        public static List<string> RavenclawNames = new List<string>();
        public static List<string> SlytherinNames = new List<string>();



    }
}
