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

namespace PizzaOnline
{//парар
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void SetTabItemsWidth()
        {
            double width = tcMain.ActualWidth - tcMain.BorderThickness.Left - tcMain.BorderThickness.Right;
            tiMenu.Width = width / 2 - 1;
            tiConstr.Width = width / 2 - 1;
                      
        }
        
        private void Window_SizeChanged_1(object sender, SizeChangedEventArgs e)
        {
            SetTabItemsWidth();
        }
    }
}
