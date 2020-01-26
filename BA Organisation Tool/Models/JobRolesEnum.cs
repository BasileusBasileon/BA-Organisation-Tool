using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_Organisation_Tool.Models
{
    [Flags]
    public enum JobRoles: int
    {
        Tank = 1,
        HealerRegen = 2,
        HealerShield = 4,
        DD = 8,
        BlueDD = 16
    }
}
