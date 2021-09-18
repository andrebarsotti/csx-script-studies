# Script com EF Core

Nos testes com EF Core a utilização de script apresentou erro abaixo. Estou tentando localizar uma forma de corrigir esse problema.

~~~
System.IO.FileLoadException: Could not load file or assembly 'Microsoft.Extensions.DependencyInjection, Version=5.0.0.1, Culture=neutral, PublicKeyToken=adb9793829ddae60'. Could not find or load a specific file. (0x80131621)
File name: 'Microsoft.Extensions.DependencyInjection, Version=5.0.0.1, Culture=neutral, PublicKeyToken=adb9793829ddae60'
 ---> System.IO.FileLoadException: Could not load file or assembly 'Microsoft.Extensions.DependencyInjection, Version=5.0.0.1, Culture=neutral, PublicKeyToken=adb9793829ddae60'.
   at System.Runtime.Loader.AssemblyLoadContext.LoadFromPath(IntPtr ptrNativeAssemblyLoadContext, String ilPath, String niPath, ObjectHandleOnStack retAssembly)
   at System.Runtime.Loader.AssemblyLoadContext.LoadFromAssemblyPath(String assemblyPath)
   at System.Reflection.Assembly.LoadFrom(String assemblyFile)
   at System.Reflection.Assembly.LoadFromResolveHandler(Object sender, ResolveEventArgs args)
   at System.Runtime.Loader.AssemblyLoadContext.InvokeResolveEvent(ResolveEventHandler eventHandler, RuntimeAssembly assembly, String name)
   at System.Runtime.Loader.AssemblyLoadContext.OnAssemblyResolve(RuntimeAssembly assembly, String assemblyFullName)
   at Microsoft.EntityFrameworkCore.Internal.ServiceProviderCache.<>c__DisplayClass4_0.<GetOrAdd>g__BuildServiceProvider|3()
   at Microsoft.EntityFrameworkCore.Internal.ServiceProviderCache.<>c__DisplayClass4_0.<GetOrAdd>b__2(Int64 k)
   at System.Collections.Concurrent.ConcurrentDictionary`2.GetOrAdd(TKey key, Func`2 valueFactory)
   at Microsoft.EntityFrameworkCore.Internal.ServiceProviderCache.GetOrAdd(IDbContextOptions options, Boolean providerRequired)
   at Microsoft.EntityFrameworkCore.DbContext..ctor(DbContextOptions options)
   at Microsoft.EntityFrameworkCore.DbContext..ctor()
   at Submission#0.BloggingContext..ctor() in /workspace/ef-core-sample/main.csx:line 49
   at Submission#0.Run() in /workspace/ef-core-sample/main.csx:line 10
   at Submission#0.<<Initialize>>d__0.MoveNext() in /workspace/ef-core-sample/main.csx:line 6
--- End of stack trace from previous location ---
   at Dotnet.Script.Core.ScriptRunner.Execute[TReturn](String dllPath, IEnumerable`1 commandLineArgs) in C:\Users\VssAdministrator\AppData\Local\Temp\tmpBFB\Dotnet.Script.Core\ScriptRunner.cs:line 110
~~~

# Referências

https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli