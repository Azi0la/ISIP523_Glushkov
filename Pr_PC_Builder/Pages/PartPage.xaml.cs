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
    /// Логика взаимодействия для PartPage.xaml
    /// </summary>
    public partial class PartPage : Page
    {
        public List <basepart_> allparts = Core.Context.basepart_.ToList ();
        public PartPage(parttype_ prt)
        {
            InitializeComponent();
            TypeList.ItemsSource = allparts.Where(c => c.parttypeid == prt.id).ToList();

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void TypeList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
         {
            
            basepart_ selectpart = TypeList.SelectedItem as basepart_;
            int index = Assemble.partlist.IndexOf(Assemble.partlist.FirstOrDefault(p => p.parttypeid == selectpart.parttypeid));
            Assemble.partlist.RemoveAt(index);
            Assemble.partlist.Insert(index, selectpart);
            
            

            if (NavigationService.CanGoBack)
            {
                NavigationService.Navigate(new MainPage());
            }
        }
    }
}
