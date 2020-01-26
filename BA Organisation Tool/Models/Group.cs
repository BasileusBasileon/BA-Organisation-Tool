using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_Organisation_Tool.Models
{
    public class Group
    {
        private GroupEnum _group;
        private Person _leader;
        private List<Person> _people;

        public GroupEnum GroupType { get => _group; set => _group = value; }
        public Person Leader { get => _leader; set => _leader = value; }
        public List<Person> People { get => _people; set => _people = value; }
    }
}
