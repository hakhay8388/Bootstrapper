using Bootstrapper.Core.nApplication;
using Bootstrapper.Core.nApplication.nCoreLoggers;
using Bootstrapper.Core.nApplication.nFactories;
using Bootstrapper.Core.nApplication.nStarter;
using Bootstrapper.Core.nCore;
using Bootstrapper.Core.nHandlers;
using Bootstrapper.Core.nHandlers.nContextHandler;
using Bootstrapper.Core.nHandlers.nDateTimeHandler;
using Bootstrapper.Core.nHandlers.nDefaultDataHandler;
using Bootstrapper.Core.nHandlers.nEmailHandler;
using Bootstrapper.Core.nHandlers.nExcelHandler;
using Bootstrapper.Core.nHandlers.nFileHandler;
using Bootstrapper.Core.nHandlers.nHashHandler;
using Bootstrapper.Core.nHandlers.nHashTableHandler;
using Bootstrapper.Core.nHandlers.nLambdaHandler;
using Bootstrapper.Core.nHandlers.nProcessHandler;
using Bootstrapper.Core.nHandlers.nReflectionHandler;
using Bootstrapper.Core.nHandlers.nStackHandler;
using Bootstrapper.Core.nHandlers.nStringHandler;
using Bootstrapper.Core.nHandlers.nValidationHandler;
using Bootstrapper.Core.nHandlers.nXmlHandler;
using Bootstrapper.Core.nUtils;

namespace TApp.TestConsoleProject
{
    public class cStarter : cCoreObject, IStarter
    {
        public cStarter(cApp _App)
            : base(_App)
        {
        }

        public void Start(cApp _App)
        {
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
        }
    }
}
