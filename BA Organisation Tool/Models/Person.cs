using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_Organisation_Tool.Models
{
    public class Person
    {
        private int? _ID;
        private string _igName;
        private string _discordName;
        private bool _ozmaReady;
        private bool _hasCleared;
        private JobRoles _roles;

        public int? ID { get => _ID; set => _ID = value; }
        public string IgName { get => _igName; set => _igName = value; }
        public string DiscordName { get => _discordName; set => _discordName = value; }
        public bool OzmaReady { get => _ozmaReady; set => _ozmaReady = value; }
        public bool HasCleared { get => _hasCleared; set => _hasCleared = value; }
        public JobRoles Roles { get => _roles; set => _roles = value; }
        
        public static Person GetEmpty()
        {
            Person EmptyPerson = new Person()
            {
                _ID = null,
                _igName = String.Empty,
                _discordName = String.Empty,
                _ozmaReady = false,
                _hasCleared = false,
                _roles = 0
            };

            return EmptyPerson;
        }
    }
}
