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
        public static List<basepart_> pageParts = new List<basepart_>();
        public static List<string> manufacturers = new List<string>() { "Все" };
        public PartPage(parttype_ prt)
        {
            InitializeComponent();
            manufacturers = new List<string>() { "Все" };
            pageParts = allparts.Where(c => c.parttypeid == prt.id).ToList();
            TypeList.ItemsSource = pageParts;
            foreach (basepart_ item in pageParts)
            {
                manufacturers.Add(item.manufacturer_.name);
            }
            manufacturers = manufacturers.Distinct().ToList();
            ManufactCB.ItemsSource = manufacturers;
            ManufactCB.SelectedIndex = 0;

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
            int index = Core.ass.partlist.IndexOf(Core.ass.partlist.FirstOrDefault(p => p.parttypeid == selectpart.parttypeid));
            Core.ass.partlist.RemoveAt(index);
            Core.ass.partlist.Insert(index, selectpart);
            
            

            if (NavigationService.CanGoBack)
            {
                NavigationService.Navigate(new MainPage());
            }
        }

        private void ManufactCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();
        }

        public void UpdateData()
        {
            List<basepart_> Filtered = pageParts;
            Filtered = Filtered.Where(p => p.name.ToLower().Contains(SearchTB.Text.ToLower())).ToList();
            if (ManufactCB.SelectedItem as string != "Все")
            {
                Filtered = Filtered.Where(p => p.manufacturer_.name.Contains(ManufactCB.SelectedItem as string)).ToList();
            }
            TypeList.ItemsSource = Filtered;
        }
    }
}
