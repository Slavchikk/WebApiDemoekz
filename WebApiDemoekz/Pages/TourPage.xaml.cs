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

namespace WebApiDemoekz.Pages
{
    /// <summary>
    /// Логика взаимодействия для TourPage.xaml
    /// </summary>
    public partial class TourPage : Page
    {
        public TourPage()
        {
            InitializeComponent();
            listTour.ItemsSource = BaseClass.tBD.Tour.ToList();

        }

        private void tbAct_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;  // получаем доступ к TextBlock из шаблона
            bool index = Convert.ToBoolean(tb.Uid);  // получаем числовой Uid элемента списка (в разметке предварительно нужно связать номер ячейки с номером кота в базе данных)

            // ищем в таблице, где хранятится информация о кормах для кота, которые соответсвуют определенному коту
           if(index == true)
            {
                tb.Text = "Актуален";
            }
            else
            {
                tb.Text = "Не актуален";
            }
           
            
        }
    }
}
