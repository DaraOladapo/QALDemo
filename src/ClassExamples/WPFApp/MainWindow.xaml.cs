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

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //myButton.Click += MyButton_Click;
            //myButton.Click += (s, e) => MessageBox.Show("I was clicked");
            myButton.Click += (s, e) => DoSomething();
        }

        //private void MyButton_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Hello there. I was clicked.");
        //}

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Hello there. This button was double clicked.");
        }
        void DoSomething()
        {
            MessageBox.Show("I was clicked");
        }
    }
}
