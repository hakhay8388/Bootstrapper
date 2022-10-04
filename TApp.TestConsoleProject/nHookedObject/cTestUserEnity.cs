using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TApp.TestConsoleProject.nHookedObject
{
    public class cTestUserEnity : cTestBaseEntity
    {
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual cTestUserDetail TestUserDetail { get; set; }
        public cTestUserEnity()
            :base()
        {
            //// Buranın DB den dolduğu varsayılıyor.
            //// Beklenen şudurki UserDetail çağırıldığı anda cTestBaseEntity 
            //// sınııfındaki HookedFuction otomatik olarak çağrılsın ve 
            //// veritabanına ulaşılıp doldurusun
            Name = "TestUser";
            Surname = "TestUser";
        }
    }
}
