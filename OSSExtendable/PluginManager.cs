using Contract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OSSExtendable
{
    public class PluginManager
    {
        public List<IContract> LoadPlugins(string directory)
        {
            List<IContract> plugins = new List<IContract>();

            foreach(string file in Directory.GetFiles(directory))
            {
                try
                {
                    Assembly assembly = Assembly.LoadFrom(file);


                    if (assembly != null)
                    {
                        foreach(Type type in  assembly.GetTypes())
                        {
                            if (typeof(IContract).IsAssignableFrom(type))
                            {
                                IContract? plugin = Activator.CreateInstance(type) as IContract;

                                if(plugin != null)
                                {
                                    plugins.Add(plugin);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Failed to load plugin: " + ex.Message);
                }
            }

            return plugins;
        }
    }
}
