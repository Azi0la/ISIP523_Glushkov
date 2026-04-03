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

namespace Pr_PC_Builder.Pages
{
    /// <summary>
    /// Логика взаимодействия для SavedPage.xaml
    /// </summary>
    public partial class SavedPage : Page
    {
        public List <partassembly_> Fullparts = Core.Context.partassembly_.ToList ();
        public List<assembly_> FullBundle = Core.Context.assembly_.ToList();

        public SavedPage()
        {
            InitializeComponent();
            SavedList.ItemsSource = FullBundle;
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
