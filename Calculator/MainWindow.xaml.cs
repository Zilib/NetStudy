using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _text;
        public string Text
        { 
            get => _text;
            set
            {
                _text = value;
            }
        }
        private void AddToString(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var Value = button.Tag.ToString();
            Text += Value;
            BindingExpression binding = textBox.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
           // textBox.Text = Text;
        }

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }
    }
   
}

