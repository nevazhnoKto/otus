using System.Diagnostics;
using System.Reflection;

namespace ConsoleApp2
{
    internal class Program
    {
        static private object threadLock = new object();
        static public List<PluginInstanceClass> _listPlugins = new List<PluginInstanceClass>();
        static void Main(string[] args)
        {
            var path = @"C:\test.dll";
            Task.Run(() => LoadDLL(path));
            Task.Run(() => RunLoad());
        }

        static private void LoadDLL(string pathDLL)
        {
            var assembly = Assembly.LoadFrom(pathDLL);
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.GetInterfaces().Any(i => i.Name == "IPlugin"))
                {
                    var instance = Activator.CreateInstance(type);
                    AddInQueue(instance, type.FullName);
                }
            }
            return;
        }
        static private void RunLoad()
        {
            while (_listPlugins.Any(p => !p.IsLoad && p.RetryCount > 2))
            {
                lock (threadLock)
                {
                    foreach (var plug in _listPlugins)
                    {
                        try
                        {
                            var load = plug.GetType().GetMethod("Load");
                            load.Invoke(plug, Array.Empty<object>());
                            plug.IsLoad = true;
                        }
                        catch
                        {
                            plug.RetryCount++;
                        }
                    }

                }
            }
        }

        static private void AddInQueue(object instance, string fullName)
        {
            if (_listPlugins.Any(p => p.FullName == fullName))
                lock (threadLock)
                {
                    _listPlugins.Add(new PluginInstanceClass(instance, fullName));
                }
        }

    }

}