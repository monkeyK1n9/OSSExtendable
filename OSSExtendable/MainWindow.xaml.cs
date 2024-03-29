using Contract;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace OSSExtendable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddPlugins();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I was clicked from the main app");
        }

        private void AddPlugins()
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly(); // sfsdfsd/sfdsfsdf/OSSExtendable.dll

            string path = Directory.GetParent(currentAssembly.Location) + "/Plugins";

            Directory.CreateDirectory(path);

            string pluginsPath = Path.GetFullPath(path);

            PluginManager pluginManager = new PluginManager();
            List<IContract> plugins = pluginManager.LoadPlugins(pluginsPath);

            foreach (IContract contract in plugins)
            {
                contract.Initialize(tabBar);
            }
        }
    }
}