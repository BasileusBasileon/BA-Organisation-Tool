using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_Organisation_Tool.Models
{
    public class BARun
    {
        private Person _leader;
        private Person _mainTank;
        private Dictionary<Person, PersonRunInformation> _people = new Dictionary<Person, PersonRunInformation>();

        private bool? _clearedArtOwain;
        private bool? _clearedRaiden;
        private bool? _clearedAV;
        private bool? _clearedOzma;

        private bool _runOver;

        public Person Leader { get => _leader; set => _leader = value; }
        public Person MainTank { get => _mainTank; set => _mainTank = value; }
        public Dictionary<Person, PersonRunInformation> People { get => _people; }

        public bool? ClearedArtOwain { get => _clearedArtOwain; set => _clearedArtOwain = value; }
        public bool? ClearedRaiden { get => _clearedRaiden; set => _clearedRaiden = value; }
        public bool? ClearedAV { get => _clearedAV; set => _clearedAV = value; }
        public bool? ClearedOzma { get => _clearedOzma; set => _clearedOzma = value; }

        public bool RunOver { get => _runOver; set => _runOver = value; }

        public BARun(IEnumerable<(Person, PersonRunInformation)> people)
        {
            foreach((Person, PersonRunInformation) pair in people)
            {
                People.Add(pair.Item1, pair.Item2);
            }
        }
    }
}
