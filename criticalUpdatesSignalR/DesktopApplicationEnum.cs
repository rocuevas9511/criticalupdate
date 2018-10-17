using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criticalUpdatesSignalR
{
    public enum DesktopApplicationTypeEnum
    {
        NotSet = 0,
        [EnumGuid("B0959B75-2258-48B8-A703-780A8F58C79D")]
        [Description("Point of Sale")]
        PointOfSales = 1,
        [EnumGuid("BDFB3FAD-BCDF-476D-9694-86EA85B1A175")]
        [Description("Queuing")]
        Queueing = 2,
        [EnumGuid("88F1592F-2ED7-4E8D-AE1E-70ABC4CB4FC1")]
        [Description("Entry and Exit")]
        EntryAndExit = 3
    }
}
