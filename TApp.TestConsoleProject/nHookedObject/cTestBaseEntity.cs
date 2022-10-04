using Bootstrapper.Core.nApplication.nFactories.nHookedObjectFactory.nPropertyHookedObjectFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TApp.TestConsoleProject.nHookedObject
{

    public class cTestBaseEntity : cPropertyHookController
    {
        public cTestBaseEntity()
            : base()
        {
        }
        public override void HookedFuction(object _Instance, string _PropertyName, object _PropertyInner)
        {
            if (_PropertyInner == null)
            {
                Type __Type = _Instance.GetType();
                if (__Type.FullName.Contains("__Proxy__"))
                {
                    __Type = __Type.BaseType;
                }
                __Type = App.Handlers.AssemblyHandler.FindFirstType(__Type.FullName);
                PropertyInfo __Prob = __Type.GetProperty(_PropertyName);
                MethodInfo __MethodInfo = __Prob.GetSetMethod();
                if (!__Type.IsPrimitiveWithString())
                {
                    //Bu Row için (_PropertyName + "ID") kolon değerin databaseden çekildiğin düşünüyoruz.
                    //ve varyasalımki bu kullanıcının detay ID si 12 olsun
                    object __InnerTypeInstance = App.Factories.HookedObjectFactory.PropertyHookedObjectFactory.GetInstance(__Prob.PropertyType);
                    
                    //12 ID li detay çekildikten sonra oluşan instance içine değerler dağıtılacak

                    __MethodInfo.Invoke(_Instance, new object[] { __InnerTypeInstance });
                }                
            }
        }
    }
}
