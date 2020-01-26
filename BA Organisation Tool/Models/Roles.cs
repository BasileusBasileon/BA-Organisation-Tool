using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_Organisation_Tool.Models
{
    [Flags]
    public enum Roles: int
    {
        BALeader = 1,
        GroupLeader = 2,
        Tank = 4,
        MainTank = 8,
        HealerRegen = 16,
        HealerShield = 32,
        DD = 64,
        BlueDPS = 128,
        Refresh = 256,
        Feint = 512,
        Perception = 1024,
        Sacrifice = 2048,
        Shell = 4096,
        Protect = 8192,
        Bravery = 16384,
        SpiritDart = 32768
    }
}
