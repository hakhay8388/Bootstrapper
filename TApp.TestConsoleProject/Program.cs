using TApp.TestConsoleProject.nTestObjects;
using Bootstrapper.Boundary.nCore.nBootType;
using Bootstrapper.Core.nApplication;
using Bootstrapper.Core.nApplication.nConfiguration;
using Bootstrapper.Core.nApplication.nFactories;
using TApp.TestConsoleProject.nHookedObject;
using TApp.TestConsoleProject.nScripttingTest;
using System;

namespace TApp.TestConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //first create configuration
            cConfiguration __DataConfiguration = new cConfiguration(EBootType.Console);

            //this is domain search layer order 
            //this application name is starting with App (TApp.TestConsoleProject) so like this 
            // if you have many layer you can add your domain from core to app layer
            __DataConfiguration.DomainNames.Add("TApp.TestConsoleProject");

            // this is culture
            __DataConfiguration.UICultureName = "tr-TR";


            // You can change other configuration at here
            //__DataConfiguration.

            cApp __App = cApp.Start<cStarter>(__DataConfiguration);

            //You can install what you want.

            //You can install take configuration at here
            //_App.Configuration.

            //App have many handler, you can use where you want
            //_App.Handlers.
            //--------------------
            // AssemblyHandler
            // LambdaHandler
            // ReflectionHandler
            // FileHandler
            // StringHandler
            // HashTableHandler
            // DateTimeHandler
            // ProcessHandler
            // HashHandler
            // ValidationHandler
            // ContextHandler
            // DefaultDataHandler
            // EmailHandler
            // ExcelHandler
            // StackHandler
            // XmlHandler

            //App have Factories, you can use where you want
            // Factories
            //--------------------
            //_App.Factories.ObjectFactory -> Resolve object
            //_App.Factories.HookedObjectFactory -> Layz Load supoorted object


            //App have Loggers, you can use where you want
            //--------------------------------
            //_App.Loggers.CoreLogger
            // You can define new looger


            // Some Utils
            //--------------------------------
            //_App.Utils { get; set; }

            cTestObject __TestObject = __App.Factories.ObjectFactory.ResolveInstance<cTestObject>();
            Console.WriteLine(__TestObject.TestInner.Temp);


            /////////////
            /// Layz Load Sample
            /// TestUserDetail Filling lazy
            ////////////
            cTestUserEnity __TestUserEnity = (cTestUserEnity)__App.Factories.HookedObjectFactory.PropertyHookedObjectFactory.GetInstance(typeof(cTestUserEnity));
            Console.WriteLine(__TestUserEnity.TestUserDetail.Detail1);


            /////////////
            /// Scriptting manager with Sample  With roslyn
            ////////////

            cScripttingTest __ScripttingTest = __App.Factories.ObjectFactory.ResolveInstance<cScripttingTest>();
            __ScripttingTest.ScripttingTest();
            __ScripttingTest.CodeSnippetTest();
            __ScripttingTest.CodeSnippetTest_NonReturnType();

            Console.ReadLine();


        }

    }
}
