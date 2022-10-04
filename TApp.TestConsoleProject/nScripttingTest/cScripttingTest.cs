using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Bootstrapper.Core.nCore;
using Bootstrapper.Core.nApplication;

namespace TApp.TestConsoleProject.nScripttingTest
{
    public class cScripttingTest : cCoreObject
    {
        public cScripttingTest(cApp _App)
            : base(_App)
        {
        }

        public void ScripttingTest()
        {
            
            string __ExecutableScript = @"
            namespace Scripting
            {
                public class cScriptTesterClass : cCoreObject
                {
                    public cScriptTesterClass(cApp _App)
                        : base(_App)
                    {
                    }

                    public bool Test1()
                    {
                        Console.WriteLine(""Void Result -> Script Başarı ile Çağrıldı"");
                        return true;
                    }
                }
            }"
            ;

            cTestScriptRunner __TestScriptRunner = new cTestScriptRunner(App);
            App.Handlers.FileHandler.WriteString(__ExecutableScript, Path.Combine(App.Configuration.ScriptPath, "cScriptTesterClass.cs"));
            if (__TestScriptRunner.ExecMethod<bool>("Scripting.cScriptTesterClass.Test1", new object[] { }))
            {
                Console.WriteLine("Scripting Running Success..");
            }
            else
            {
                Console.WriteLine("Scripting Fail...");
            }
        }

        public void CodeSnippetTest()
        {
            string __CodeSnippet = @"
                Console.WriteLine(""CodeSnippet Running Success..{0}, {1}"",_Param0.ToString(),_Param1.ToString());
                Result = true;
            ";


            cTestScriptRunner __TestScriptRunner = new cTestScriptRunner(App);
            if (__TestScriptRunner.EvalCode<bool>(__CodeSnippet,"Deneme", "Parametreleri"))
            {

                Console.WriteLine("CodeSnippet Running Success..");
            }
            else
            {
                Console.WriteLine("CodeSnippet Fail...");
            }
        }

        public void CodeSnippetTest_NonReturnType()
        {
            string __CodeSnippet = @"
                Console.WriteLine(""CodeSnippet Running Success..{0}, {1}, {2}"",_Param0.ToString(),_Param1.ToString() ,_Param1.ToString());
            ";

            cTestScriptRunner __TestScriptRunner = new cTestScriptRunner(App);
            __TestScriptRunner.EvalCode(__CodeSnippet, "Çeşitli", "Parametreler", "Gönderilebilir");
            Console.WriteLine("CodeSnippet Running Success..");
        }
    }
}
