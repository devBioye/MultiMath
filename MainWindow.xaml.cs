using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MultiMath
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
               
                timer.Interval = TimeSpan.FromSeconds(1.0);
                timer.Tick += timer_Tick;
                
                timer.Start();
                
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connecting to the app");
            }



        }
        int count = 10;
        
        void timer_Tick(object sender, object e)
        {
            count -= 1;
            textBlock1.Text = count.ToString();
            if (count == 0)
            {
                this.Hide();
                multiMath mm = new multiMath();
                mm.Show();
               
            }
 
        }

        
    }
}
