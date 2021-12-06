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

namespace WpfTesterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
         InitializeComponent();
            this.Closed += MainWindow_OnClosed;
            this.Closing += MainWindow_Closing;
            this.KeyDown += MainWindow_KeyDown;

            //this.MouseMove += MainWindow_MouseMove;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            //Display key press on the button.
            clickMe.Content = e.Key.ToString();
        }

        //private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        //{
        //    //set the title of the window to the current (x,y) of the mouse.
        //    this.Title = e.GetPosition(this).ToString();
        //}

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //see if the user really want to shut down this window.
            string msg = "Do You want to close without saving?";
            MessageBoxResult result = MessageBox.Show(msg, "My App", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result==MessageBoxResult.No)
            {
                //if the user does not to close, cancel closure.
                e.Cancel = true;
            }

        }

        private void MainWindow_OnClosed(object sender, EventArgs e)
        {
            MessageBox.Show("See ya!");
        }


        private void Calendar_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked the button!");

        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            this.Title = e.GetPosition(this).ToString();
        }
    }
}
