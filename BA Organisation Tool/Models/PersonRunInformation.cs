namespace BA_Organisation_Tool.Models
{
    public class PersonRunInformation
    {
        private GroupEnum _group;
        private Roles _roles;

        public GroupEnum Group { get => _group; set => _group = value; }
        public Roles Roles { get => _roles; set => _roles = value; }
    }
}