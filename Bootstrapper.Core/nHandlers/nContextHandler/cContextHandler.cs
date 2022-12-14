using Bootstrapper.Core.nApplication;
using Bootstrapper.Core.nApplication.nCoreLoggers;
//using Bootstrapper.Core.nApplication.nCoreLoggers.nMethodCallLogger;
using Bootstrapper.Core.nAttributes;
using Bootstrapper.Core.nCore;
using Bootstrapper.Core.nExceptions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bootstrapper.Core.nHandlers.nContextHandler
{
    public class cContextHandler : cCoreObject
    {
        List<cContextItem> ContextList { get; set; }
        public cContextHandler(nApplication.cApp _App)
            :base(_App)
        {
            ContextList = new List<cContextItem>();
        }

        public override void Init()
        {
            App.Factories.ObjectFactory.RegisterInstance<cContextHandler>(this);
        }


        public void AddContext(HttpContext _Context)
        {
            lock(ContextList)
            {
                ContextList.RemoveAll(__Item => DateTime.Now.Subtract(__Item.UpdateTime).TotalSeconds > 36000);
                cContextItem __ContextItem = ContextList.Where(__Item => __Item.ThreadId == Thread.CurrentThread.ManagedThreadId).FirstOrDefault();
                if (__ContextItem == null)
                {
                    ContextList.Add(new cContextItem(_Context, Thread.CurrentThread.ManagedThreadId));
                }
                else
                {
                    __ContextItem.Refresh(_Context);
                }
            }
            
        }

        public cContextItem CurrentContextItem
        {
            get
            {
                lock (ContextList)
                {
                    List<cContextItem> __ContextItems = ContextList.Where(__Item => __Item.ThreadId == Thread.CurrentThread.ManagedThreadId).ToList();
                    if (__ContextItems.Count == 1)
                    {
                        return __ContextItems[0];
                    }
                    else
                    {
                        throw new Exception("Ayn?? Thread'e ba??l?? birden fazla context var yada hi?? bir context yok");
                    }                   
                }
            }
        }
    }
}
