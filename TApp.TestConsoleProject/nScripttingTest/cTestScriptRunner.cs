using Bootstrapper.Core.nApplication;
using Bootstrapper.Core.nAttributes;
using Bootstrapper.Core.nCore;
using Bootstrapper.Core.nScripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TApp.TestConsoleProject.nScripttingTest
{
    [Register(typeof(IScripting))]
    public class cTestScriptRunner : cScriptRunner
    {
        public cTestScriptRunner(cApp _App)
            : base(_App)
        {
            App.Factories.ObjectFactory.RegisterInstance<IScripting>(this);
        }
        public override void Init()
        {
            base.Init();
        }
        protected override string GetClassSourceTemplate()
        {
            return TApp.TestConsoleProject.Properties.Resources.SCRIPTING_CLASS_SOURCE_FOR_TEST;
        }
        protected override string GetCodeSnippetBaseClassName()
        {
            return typeof(cCoreService<>).Name;
        }
        protected override string GetCodeSnippetInjectionClassName()
        {
            return typeof(cCoreServiceContext).Name;
        }

        public override List<string> GetReferencedAssemblies()
        {
            List<string> __Result = base.GetReferencedAssemblies();
            //Eklenmek istenen referance DLL ler burdan eklenir.
            //            __Result.Add("Microsoft.VisualStudio.TestPlatform.TestFramework.dll");
            return __Result;

        }

        protected override string GetClassReplaceWithStringInTemplate()
        {
            return "SOURCE";
        }
    }
}
