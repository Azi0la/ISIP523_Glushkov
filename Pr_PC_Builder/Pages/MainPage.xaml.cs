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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        public List<parttype_> Types = Core.Context.parttype_.ToList();
        
        public MainPage()
        {
            InitializeComponent();
            UnitList.ItemsSource = MainWindow.ass.partlist;

            cpu_ cpu = MainWindow.ass.partlist.FirstOrDefault(p => p.parttypeid == 1).cpu_;
            gpu_ gpu = MainWindow.ass.partlist.FirstOrDefault(p => p.parttypeid == 2).gpu_;
            ram_ ram = MainWindow.ass.partlist.FirstOrDefault(p => p.parttypeid == 3).ram_;
            motherboard_ motherboard = MainWindow.ass.partlist.FirstOrDefault(p => p.parttypeid == 4).motherboard_;
            case_ casee = MainWindow.ass.partlist.FirstOrDefault(p => p.parttypeid == 5).case_;
            powersupply_ powersupply = MainWindow.ass.partlist.FirstOrDefault(p => p.parttypeid == 6).powersupply_;
            processorcooler_ processorcooler = MainWindow.ass.partlist.FirstOrDefault(p => p.parttypeid == 7).processorcooler_;
            storagedevice_ storagedevice = MainWindow.ass.partlist.FirstOrDefault(p => p.parttypeid == 8).storagedevice_;

            if (cpu != null && motherboard != null)
            {
                if(cpu.socketid != motherboard.socketid)
                {
                    CompatTB.Text += ("ОШИБКА: Сокеты процессора и \nмат. платы несовместимы! \n");
                }
            }
            if (casee != null && motherboard != null)
            {
                if (casee.sizeid != motherboard.formfactorid)
                {
                    CompatTB.Text += ("ОШИБКА Размер корпуса и \nформ-фактор мат. платы несовместимы! \n");
                    CompatBTN.IsEnabled = false;
                }
            }
            if(motherboard != null && ram != null)
            {
                if(motherboard.memorytypeid != ram.memorytypeid)
                {
                    CompatTB.Text += ("ОШИБКА Типы памяти у мат. платы и \nОЗУ несовместимы! \n");
                    CompatBTN.IsEnabled = false;
                }
            }
            if (gpu != null && powersupply != null)
            {
                if (gpu.recommendpower > powersupply.power)
                {
                    CompatTB.Text += ("ОШИБКА Мощность блока питания и \nпотребление мощности видеокарты\n несовместимы\n");
                    CompatBTN.IsEnabled = false;
                }
            }
            if(cpu != null && gpu != null && ram != null && motherboard != null && casee != null && powersupply != null && processorcooler != null && storagedevice != null)
            {
                if(cpu.socketid == motherboard.socketid && casee.sizeid == motherboard.formfactorid && motherboard.memorytypeid == ram.memorytypeid && gpu.recommendpower <= powersupply.power)
                CompatTB.Text += ("Сборка совместима!");
                CompatBTN.IsEnabled = true;
            }


            if (UnitList.SelectedItem != null)
            {
                //Добавить сюда либо пропажу кнопки добавления, либо поменять на изменение, но пока я хз как обратиться
            }
        }
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            basepart_ selectedPart = btn.DataContext as basepart_;
            parttype_ pt = Types.FirstOrDefault(type => type.id == selectedPart.parttypeid);
            NavigationService.Navigate(new PartPage(pt));
        }

        private void CompatBTN_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(NameTB.Text))
            {
                //Прописать переход на страницу сэйвов
            }
            else
            {
                MessageBox.Show("Введите название для сборки!");
            }
        }
    }
}
