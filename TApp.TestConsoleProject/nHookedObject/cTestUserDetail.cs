using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TApp.TestConsoleProject.nHookedObject
{
    public class cTestUserDetail : cTestBaseEntity
    {
        public virtual string Detail1 { get; set; }
        public virtual string Detail2 { get; set; }
        public virtual string Detail3 { get; set; }
        public cTestUserDetail()
            :base()
        {
            //// Buranın DB den dolduğu varsayılıyor.
            Detail1 = "TestUserDetail1";
            Detail2 = "TestUserDetail2";
            Detail3 = "TestUserDetail3";
        }
    }
}
