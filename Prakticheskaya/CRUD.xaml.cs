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
using System.Windows.Shapes;

namespace Prakticheskaya
{
    /// <summary>
    /// Логика взаимодействия для CRUD.xaml
    /// </summary>
    public partial class CRUD : Window
    {
       
        public CRUD(int x)
        {
            InitializeComponent();
            AddData addData = new AddData();
            switch(x)
            {
                case 1:
                    MainFrame.Content = addData;
                    break;
            }
        }

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
