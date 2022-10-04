
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
                        Console.WriteLine("Void Result -> Script Başarı ile Çağrıldı");
                        return true;
                    }
                }
            }