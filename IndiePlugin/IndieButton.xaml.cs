using Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IndiePlugin
{
    /// <summary>
    /// Interaction logic for IndieButton.xaml
    /// </summary>
    [Contract(CreatedBy = "King", Year = "2024")]
    public partial class IndieButton : UserControl, IContract
    {
        public IndieButton()
        {
            InitializeComponent();
        }

        public void Initialize(StackPanel stackPanel)
        {
            stackPanel.Children.Add(this);
        }

        public void RunMe()
        {
            MyJobs jobs = new MyJobs();
            jobs.Show();
        }

        private void tataButton_Click(object sender, RoutedEventArgs e)
        {
            RunMe();
        }
    }
}
