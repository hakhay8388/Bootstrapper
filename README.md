# .Net Core Bootstrapper
 
## Hello

This project developed for bootstapping your project. Bootstrapper is using Unity container.
Bootstrapper traverses all domain and registers all class. Dependency Injection is using deeply in this project.

### Handlers
This prject has many handler for your help.
You can access handlers from App.
Please look Program.cs file how to access App class.
-------------------
AssemblyHandler
LambdaHandler
ReflectionHandler
FileHandler
StringHandler
HashTableHandler
DateTimeHandler
ProcessHandler
HashHandler
ValidationHandler
ContextHandler
DefaultDataHandler
EmailHandler
ExcelHandler
StackHandler
XmlHandler

### Factories
App have Factories, you can use where you want for resoleve class 
Factories
--------------------
App.Factories.ObjectFactory -> Resolve object
App.Factories.HookedObjectFactory -> Layz Load supoorted object

#### Layz load sample in project
you can develop your custom lazy load. Project supports that.	

### Loggers
App have Loggers, you can use where you want.
You can define new looger.
--------------------------------
App.Loggers.CoreLogger

### Loggers
Some Utils in here.
--------------------------------
App.Utils


### Scriptting
you can find in "Program.cs" how to use scriptting.
You can develop your custom script loader.


## Your questions

IF you have questions, You can send mail to [hakhay8388@hotmail.com](mailto:hakhay8388@hotmail.com).


