using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Collections.Concurrent;

namespace ConsoleApp2
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            ConcurrentList<object> concurrentList = new ConcurrentList<Object>()
            var path = @"C:\work\OTUS_new\Spacebattle\ConsoleApp3\bin\Debug\net8.0\ConsoleApp3.dll";
            var assembly = Assembly.LoadFrom(path);
            var types = assembly.GetTypes();
            foreach(var type in types)
            {
                if (type.GetInterfaces().Any(i => i.Name == "IPlugin"))
                {
                    var instance = Activator.CreateInstance(type);

                    AddInSequesnce();
                    var load = type.GetMethod("Load");
                    load.Invoke(instance, Array.Empty<object>());

                    
                }
            }
        }

    }
}