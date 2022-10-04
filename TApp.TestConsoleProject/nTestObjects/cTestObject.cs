using Bootstrapper.Core.nApplication;
using Bootstrapper.Core.nCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TApp.TestConsoleProject.nTestObjects
{
    public class cTestObject : cCoreObject
    {
        public cTestInner TestInner { get; set; }
        public cTestObject(cApp _App, cTestInner _TestInner)
            :base(_App)
        {
            TestInner = _TestInner;
        }
    }
}
