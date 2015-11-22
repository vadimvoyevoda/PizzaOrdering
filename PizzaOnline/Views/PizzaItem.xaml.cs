using System;
using System.Windows;
using System.Windows.Controls;
using PizzaOnline.Models;

namespace PizzaOnline.Views
{
    /// <summary>
    /// Interaction logic for PizzaItem.xaml
    /// </summary>
    public partial class PizzaItem : UserControl
    {
        public PizzaItemModel Source
        {
            get { return (PizzaItemModel)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        public static readonly DependencyProperty SourceProperty =
          DependencyProperty.Register("Source", typeof(PizzaItemModel), typeof(PizzaItem), null);

        public PizzaItem()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            Source.Counter++;
        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            Source.Counter--;
        }

    }
}
