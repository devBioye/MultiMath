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
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Diagnostics;

namespace MultiMath
{
    
    /// <summary>
    /// Interaction logic for multiMath.xaml
    /// </summary>
    public partial class multiMath : Window
    {
        string value;
        coin one = new coin();
        int operate;
        Random op = new Random();
        Stopwatch stopwatch = new Stopwatch();
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timer1 = new DispatcherTimer();
        string currentTime = string.Empty;
        string[] arr = {"+", "-", "X", "/" };
        public multiMath()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = TimeSpan.FromSeconds(1.0);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = TimeSpan.FromSeconds(1.0);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Licence cs = new Licence();
            cs.Show();
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            //Properties.Settings.Default.time = "";
            //Properties.Settings.Default.coin = "0";
            //Properties.Settings.Default.licenced = "";

            Properties.Settings.Default.coin = one.coins.ToString();

            if (Properties.Settings.Default.time == "")
            {
                Properties.Settings.Default.time = count.ToString();

            }
            else
            {
                Properties.Settings.Default.time = intvalue.ToString();
            }
            Properties.Settings.Default.Save();
            
            //MessageBox.Show(Properties.Settings.Default.time);
            Environment.Exit(0);
        }
        Random rand = new Random();
        Random rand1 = new Random();
        int ivalue = 0;
        int fvalue = 0;
          
        
        
       
        public string lp()
        {
            string strcoin = one.coins.ToString();
            strcoin = Properties.Settings.Default.coin;
            return strcoin;
        }
        
        
        public int result()
        {
            int result = 0;
            
            if (operate.ToString() == "0")
            {
                 result = ivalue + fvalue;
            }
            else if (operate.ToString() == "1")
            {
                 result = ivalue - fvalue;
            }
            else if (operate.ToString() == "2")
            {
                 result = ivalue * fvalue;
            }
            else if (operate.ToString() == "3")
            {
                 result = ivalue / fvalue;
            }
            int res = result;
            return res;
        }
         
        
        private void button10_Click(object sender, RoutedEventArgs e)
        {
            lp();
            if (button1.IsEnabled == true)
            {
                try
                {
                    button13.IsEnabled = true;
                    button10.IsEnabled = false;
                    button13.Visibility = System.Windows.Visibility.Visible;
                    Random rand = new Random();
                    ivalue = rand.Next(20, 50);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(5, 20);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    //textBlock5.Text = "X";

                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer1.Start();
                    stopwatch.Start();



                }
                catch (Exception ex)
                {
                }
            }
            if (button2.IsEnabled == true)
            {
                try
                {
                    button13.IsEnabled = true;
                    button10.IsEnabled = false;
                    button13.Visibility = System.Windows.Visibility.Visible;
                    Random rand = new Random();
                    ivalue = rand.Next(50, 100);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(20, 50);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    //textBlock5.Text = "X";

                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer1.Start();
                    stopwatch.Start();



                }
                catch (Exception ex)
                {
                }
 
            }
            
            if (button3.IsEnabled == true)
            {
                try
                {
                    button13.IsEnabled = true;
                    button10.IsEnabled = false;
                    button13.Visibility = System.Windows.Visibility.Visible;
                    Random rand = new Random();
                    ivalue = rand.Next(100, 300);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(50, 150);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    //textBlock5.Text = "X";

                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer1.Start();
                    stopwatch.Start();



                }
                catch (Exception ex)
                {
                }

            }
            if (button4.IsEnabled == true)
            {
                try
                {
                    button13.IsEnabled = true;
                    button10.IsEnabled = false;
                    button13.Visibility = System.Windows.Visibility.Visible;
                    Random rand = new Random();
                    ivalue = rand.Next(300, 500);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(150, 300);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    //textBlock5.Text = "X";

                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer1.Start();
                    stopwatch.Start();



                }
                catch (Exception ex)
                {
                }

            }
            if (button5.IsEnabled == true)
            {
                try
                {
                    button13.IsEnabled = true;
                    button10.IsEnabled = false;
                    button13.Visibility = System.Windows.Visibility.Visible;
                    Random rand = new Random();
                    ivalue = rand.Next(650, 900);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(20, 50);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    //textBlock5.Text = "X";

                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer1.Start();
                    stopwatch.Start();



                }
                catch (Exception ex)
                {
                }

            }
            if (button6.IsEnabled == true)
            {
                try
                {
                    button13.IsEnabled = true;
                    button10.IsEnabled = false;
                    button13.Visibility = System.Windows.Visibility.Visible;
                    Random rand = new Random();
                    ivalue = rand.Next(1000, 5000);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(10, 30);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    //textBlock5.Text = "X";

                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer1.Start();
                    stopwatch.Start();



                }
                catch (Exception ex)
                {
                }

            }
            if (button7.IsEnabled == true)
            {
                try
                {
                    button13.IsEnabled = true;
                    button10.IsEnabled = false;
                    button13.Visibility = System.Windows.Visibility.Visible;
                    Random rand = new Random();
                    ivalue = rand.Next(500, 900);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(-4500, 9500);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    //textBlock5.Text = "X";

                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer1.Start();
                    stopwatch.Start();



                }
                catch (Exception ex)
                {
                }

            }
            if (button8.IsEnabled == true)
            {
                try
                {
                    button13.IsEnabled = true;
                    button10.IsEnabled = false;
                    button13.Visibility = System.Windows.Visibility.Visible;
                    Random rand = new Random();
                    ivalue = rand.Next(9000, 12000);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(5000, 6000);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    //textBlock5.Text = "X";

                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer1.Start();
                    stopwatch.Start();



                }
                catch (Exception ex)
                {
                }

            }
            if (button2.IsEnabled == true)
            {
                try
                {
                    button13.IsEnabled = true;
                    button10.IsEnabled = false;
                    button13.Visibility = System.Windows.Visibility.Visible;
                    Random rand = new Random();
                    ivalue = rand.Next(50, 100);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(20, 50);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    //textBlock5.Text = "X";

                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer1.Start();
                    stopwatch.Start();



                }
                catch (Exception ex)
                {
                }

            }
                
            



        }
        
        void timer1_Tick(object sender, object e)
        {
            if (stopwatch.IsRunning)
            {
                TimeSpan ts = stopwatch.Elapsed;
                currentTime = String.Format("{0:00}", ts.Seconds);
                textBlock7.Text = currentTime;
            }
            if (currentTime == "50")
            {
                textBlock7.Text = "00";

                stopwatch.Stop();
                timer.Stop();
                stopwatch.Restart();
                one.coins--;
                nextques();
                textBox1.Text = "";
            }
 

        }
         
       
        void nextques()
        {
            if (button1.IsEnabled == true)
            {
                try
                {
                    timer.Stop();


                    Random rand = new Random();
                    ivalue = rand.Next(20, 50);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(5, 20);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    textBlock5.Text = "X";
                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer.Start();
                    stopwatch.Start();
                    if (textBlock7.Text == "50")
                    {
                        
                        MessageBox.Show("Times Up");
                        
                        currentTime = "00";
                        one.coins--;
                        timer.Stop();
                        stopwatch.Stop();
                        stopwatch.Reset();
                        
                        textBox1.Text = "";
                        nextques();
                    }



                }
                catch (Exception ex)
                {
                }
            }
            if (button2.IsEnabled == true)
            {
                try
                {
                     timer.Stop();


                    Random rand = new Random();
                    ivalue = rand.Next(50, 100);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(20, 50);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    textBlock5.Text = "X";
                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer.Start();
                    stopwatch.Start();
                    if (textBlock7.Text == "50")
                    {
                        MessageBox.Show("Times Up");
                        one.coins--;
                        textBlock7.Text = "00";
                        nextques();
                    }




                }
                catch (Exception ex)
                {
                }
                    
          
                
            }
            if (button3.IsEnabled == true)
            {
                try
                {
                    timer.Stop();


                    Random rand = new Random();
                    ivalue = rand.Next(100, 300);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(50, 150);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    textBlock5.Text = "X";
                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer.Start();
                    stopwatch.Start();
                    if (textBlock7.Text == "50")
                    {
                        MessageBox.Show("Times Up");
                        one.coins--;
                        textBlock7.Text = "00";
                        nextques();
                    }
                }
                catch (Exception ex)
                {
                }
            }
            if (button4.IsEnabled == true)
            {
                try
                {
                    timer.Stop();


                    Random rand = new Random();
                    ivalue = rand.Next(300, 500);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(150, 300);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    textBlock5.Text = "X";
                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer.Start();
                    stopwatch.Start();
                    if (textBlock7.Text == "50")
                    {
                        MessageBox.Show("Times Up");
                        one.coins--;
                        textBlock7.Text = "00";
                        nextques();
                    }
                }
                catch (Exception ex)
                {
                }
            }
            if (button5.IsEnabled == true)
            {
                try
                {
                    timer.Stop();


                    Random rand = new Random();
                    ivalue = rand.Next(650, 900);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(20, 50);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    textBlock5.Text = "X";
                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer.Start();
                    stopwatch.Start();
                    if (textBlock7.Text == "50")
                    {
                        MessageBox.Show("Times Up");
                        one.coins--;
                        textBlock7.Text = "00";
                        nextques();
                    }
                }
                catch (Exception ex)
                {
                }
            }
            if (button6.IsEnabled == true)
            {
                try
                {
                    timer.Stop();


                    Random rand = new Random();
                    ivalue = rand.Next(1000, 5000);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(10, 30);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    textBlock5.Text = "X";
                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer.Start();
                    stopwatch.Start();
                    if (textBlock7.Text == "50")
                    {
                        MessageBox.Show("Times Up");
                        one.coins--;
                        textBlock7.Text = "00";
                        nextques();
                    }
                }
                catch (Exception ex)
                {
                }
            }
            if (button7.IsEnabled == true)
            {
                try
                {
                    timer.Stop();


                    Random rand = new Random();
                    ivalue = rand.Next(500, 900);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(-4500, 9500);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    textBlock5.Text = "X";
                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer.Start();
                    stopwatch.Start();
                    if (textBlock7.Text == "50")
                    {
                        MessageBox.Show("Times Up");
                        one.coins--;
                        textBlock7.Text = "00";
                        nextques();
                    }
                }
                catch (Exception ex)
                {
                }
            }
            if (button8.IsEnabled == true)
            {
                try
                {
                    timer.Stop();


                    Random rand = new Random();
                    ivalue = rand.Next(9000, 12000);
                    Random rand1 = new Random();
                    fvalue = rand1.Next(5000, 6000);
                    textBlock4.Text = ivalue.ToString();
                    textBlock6.Text = fvalue.ToString();
                    textBlock5.Text = "X";
                    operate = op.Next(0, 3);
                    string oper = arr[operate];
                    textBlock5.Text = oper;
                    timer.Start();
                    stopwatch.Start();
                    if (textBlock7.Text == "50")
                    {
                        MessageBox.Show("Times Up");
                        one.coins--;
                        textBlock7.Text = "00";
                        nextques();
                    }
                }
                catch (Exception ex)
                {
                }
            }

             
            
        }
       
        void timer_Tick(object sender, object e)
        {
             if (stopwatch.IsRunning)
            {
                TimeSpan ts = stopwatch.Elapsed;
                currentTime = String.Format("{0:00}", ts.Seconds);
                textBlock7.Text = currentTime;
            }
                
           
        } 

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            
            if (one.coins < 20)
            {
                validate();
                button2.IsEnabled = false;
                if (textBox1.Text == result().ToString())
                {
                    

                    timer.Stop();
                    timer1.Stop();
                    stopwatch.Stop();
                    one.coins++;
                    textBlock2.Text = "coins: " + one.coins;
                    MessageBox.Show("You are Correct", "Correct", MessageBoxButton.OK, MessageBoxImage.Information);
                    stopwatch.Reset();
                    textBlock7.Text = "00";
                    textBox1.Text = "";
                    nextques();
                   

                }
                else
                {

                    timer.Stop();
                    timer1.Stop();
                    stopwatch.Stop();
                    one.coins--;
                    textBlock2.Text = "coins: " + one.coins;
                    MessageBox.Show("You are Wrong", "Wrong", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    stopwatch.Reset();
                    textBlock7.Text = "00";
                    textBox1.Text = "";
                    nextques();
                    
                }
               
            }
            if (one.coins == 20)
            {
                              
                    button2.IsEnabled = true;
                    button1.IsEnabled = false;
                    textBlock8.Text = 1.ToString();
                    one.coins++;
                
            }
            if (one.coins > 20 && one.coins < 40)
            {
                validate();
                if (textBox1.Text == result().ToString())
                {


                    timer.Stop();
                    timer1.Stop();
                    stopwatch.Stop();
                    one.coins++;
                    textBlock2.Text = "coins: " + one.coins;
                    MessageBox.Show("You are Correct", "Correct", MessageBoxButton.OK, MessageBoxImage.Information);
                    stopwatch.Reset();
                    textBlock7.Text = "00";
                    textBox1.Text = "";
                    nextques();


                }
                else
                {

                    timer.Stop();
                    timer1.Stop();
                    stopwatch.Stop();
                    one.coins--;
                    textBlock2.Text = "coins: " + one.coins;
                    MessageBox.Show("You are Wrong", "Wrong", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    stopwatch.Reset();
                    textBlock7.Text = "00";
                    textBox1.Text = "";
                    nextques();

                }
               
 
            }
            if (one.coins == 40)
            {
                button3.IsEnabled = true;
                button2.IsEnabled = false;
                textBlock8.Text = 2.ToString();
                one.coins++;
            }
            if (one.coins > 40 && one.coins < 60)
            {
                validate();
                if (textBox1.Text == result().ToString())
                {


                    timer.Stop();
                    timer1.Stop();
                    stopwatch.Stop();
                    one.coins++;
                    textBlock2.Text = "coins: " + one.coins;
                    MessageBox.Show("You are Correct", "Correct", MessageBoxButton.OK, MessageBoxImage.Information);
                    stopwatch.Reset();
                    textBlock7.Text = "00";
                    textBox1.Text = "";
                    nextques();


                }
                else
                {

                    timer.Stop();
                    timer1.Stop();
                    stopwatch.Stop();
                    one.coins--;
                    textBlock2.Text = "coins: " + one.coins;
                    MessageBox.Show("You are Wrong", "Wrong", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    stopwatch.Reset();
                    textBlock7.Text = "00";
                    textBox1.Text = "";
                    nextques();

                }
               
 
            }
            if (one.coins == 60)
            {
                button3.IsEnabled = false;
                button4.IsEnabled = true;
                one.coins++;
                textBlock8.Text = 3.ToString();
            }
            if (one.coins > 60 && one.coins < 80)
            {
                validate();
                if (textBox1.Text == result().ToString())
                {


                    timer.Stop();
                    timer1.Stop();
                    stopwatch.Stop();
                    one.coins++;
                    textBlock2.Text = "coins: " + one.coins;
                    MessageBox.Show("You are Correct", "Correct", MessageBoxButton.OK, MessageBoxImage.Information);
                    stopwatch.Reset();
                    textBlock7.Text = "00";
                    textBox1.Text = "";
                    nextques();


                }
                else
                {

                    timer.Stop();
                    timer1.Stop();
                    stopwatch.Stop();
                    one.coins--;
                    textBlock2.Text = "coins: " + one.coins;
                    MessageBox.Show("You are Wrong", "Wrong", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    stopwatch.Reset();
                    textBlock7.Text = "00";
                    textBox1.Text = "";
                    nextques();

                }
               
 
            }
            if (one.coins == 80)
            {
                button4.IsEnabled = false;
                button5.IsEnabled = true;
                one.coins++;
                textBlock8.Text = 4.ToString();
            }
            if (one.coins > 80 && one.coins < 100)
            {
                validate();
                if (textBox1.Text == result().ToString())
                {


                    timer.Stop();
                    timer1.Stop();
                    stopwatch.Stop();
                    one.coins++;
                    textBlock2.Text = "coins: " + one.coins;
                    MessageBox.Show("You are Correct", "Correct", MessageBoxButton.OK, MessageBoxImage.Information);
                    stopwatch.Reset();
                    textBlock7.Text = "00";
                    textBox1.Text = "";
                    nextques();


                }
                else
                {

                    timer.Stop();
                    timer1.Stop();
                    stopwatch.Stop();
                    one.coins--;
                    textBlock2.Text = "coins: " + one.coins;
                    MessageBox.Show("You are Wrong", "Wrong", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    stopwatch.Reset();
                    textBlock7.Text = "00";
                    textBox1.Text = "";
                    nextques();

                }
               
 
            }
            if (one.coins == 100)
            {
                button5.IsEnabled = false;
                button6.IsEnabled = true;
                one.coins++;
                textBlock8.Text = 5.ToString();
            }
            if (one.coins > 100 && one.coins < 120)
            {
                validate();
                if (textBox1.Text == result().ToString())
                {


                    timer.Stop();
                    timer1.Stop();
                    stopwatch.Stop();
                    one.coins++;
                    textBlock2.Text = "coins: " + one.coins;
                    MessageBox.Show("You are Correct","Correct",MessageBoxButton.OK,MessageBoxImage.Information);
                    stopwatch.Reset();
                    textBlock7.Text = "00";
                    textBox1.Text = "";
                    nextques();


                }
                else
                {

                    timer.Stop();
                    timer1.Stop();
                    stopwatch.Stop();
                    one.coins--;
                    textBlock2.Text = "coin: " + one.coins;
                    MessageBox.Show("You are Wrong", "Wrong", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    stopwatch.Reset();
                    textBlock7.Text = "00";
                    textBox1.Text = "";
                    nextques();

                }
               
 
            }
            if (one.coins == 120)
            {
                button6.IsEnabled = false;
                button7.IsEnabled = true;
                one.coins++;
                textBlock8.Text = 6.ToString();
            }
            if (one.coins > 120 && one.coins < 140)
            {
                validate();
                if (textBox1.Text == result().ToString())
                {


                    timer.Stop();
                    timer1.Stop();
                    stopwatch.Stop();
                    one.coins++;
                    textBlock2.Text = "coin: " + one.coins;
                    MessageBox.Show("You are Correct", "Correct", MessageBoxButton.OK, MessageBoxImage.Information);
                    stopwatch.Reset();
                    textBlock7.Text = "00";
                    textBox1.Text = "";
                    nextques();


                }
                else
                {

                    timer.Stop();
                    timer1.Stop();
                    stopwatch.Stop();
                    one.coins--;
                    textBlock2.Text = "coins: " + one.coins;
                    MessageBox.Show("You are Wrong", "Wrong", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    stopwatch.Reset();
                    textBlock7.Text = "00";
                    textBox1.Text = "";
                    nextques();

                }
               
 
            }
            
            if (one.coins == 140)
            {
                button7.IsEnabled = false;
                button8.IsEnabled = true;
                one.coins++;
                textBlock8.Text = 7.ToString();
            }
            if (one.coins > 140 && one.coins < 160)
            {
                validate();
                if (one.coins > 120 && one.coins < 140)
                {
                    if (textBox1.Text == result().ToString())
                    {


                        timer.Stop();
                        timer1.Stop();
                        stopwatch.Stop();
                        one.coins++;
                        textBlock2.Text = "coins: " + one.coins;
                        MessageBox.Show("You are Correct", "Correct", MessageBoxButton.OK, MessageBoxImage.Information);
                        stopwatch.Reset();
                        textBlock7.Text = "00";
                        textBox1.Text = "";
                        nextques();


                    }
                    else
                    {

                        timer.Stop();
                        timer1.Stop();
                        stopwatch.Stop();
                        one.coins--;
                        textBlock2.Text = "coins: " + one.coins;
                        MessageBox.Show("You are Wrong", "Wrong", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        stopwatch.Reset();
                        textBlock7.Text = "00";
                        textBox1.Text = "";
                        nextques();

                    }


                }
                
            }
            if (one.coins == 160)
            {
                textBlock8.Text = 8.ToString();
                MessageBox.Show("Course Completed.You are now a pro in arithmetic calculation", "Course Completed", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                button12.Visibility = System.Windows.Visibility.Visible;
            }


        }
        int intvalue;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            button13.IsEnabled = false;
            //string strcoins = one.coins.ToString();
            //strone.coins = Properties.Settings.Default.cois;

            if (Properties.Settings.Default.coin == "")
            {
                one.coins = 0;
                textBlock2.Text = "coin: " + one.coins;
            }
            else
            {
                string strcoin = Properties.Settings.Default.coin;
                one.coins = Convert.ToInt32(strcoin);
                textBlock2.Text = "coin: " + one.coins;
            }
            validate();
            if (Properties.Settings.Default.licenced == "")
            {
                if (Properties.Settings.Default.time == "")
                {
                    licencevalid();
                }
                else
                {
                    value = Properties.Settings.Default.time;
                    intvalue = Convert.ToInt32(value);
                    try
                    {

                        d.Interval = TimeSpan.FromSeconds(1.0);
                        d.Tick += d_Tick;

                        d.Start();



                    }
                    catch (Exception ex)
                    {

                    }
                }

                //textBlock2.Text = "coins: " + one.coins;

            }
            else
            {
                button9.Visibility = System.Windows.Visibility.Hidden;
                textBlock3.Text = "This app is licenced";
            }
        }
        
        
        
        void d_Tick(object sender, object e)
        {
            intvalue -= 1;
            if (intvalue == 0)
            {
                Licence l = new Licence();
                l.Show();
                this.Hide();
            }
        }
        DispatcherTimer d = new DispatcherTimer();
        DispatcherTimer dt = new DispatcherTimer();
        public void licencevalid()
        {
            
            try
            {
                
                dt.Interval = TimeSpan.FromSeconds(1.0);
                dt.Tick += dt_Tick;

                dt.Start();

                

            }
            catch (Exception ex)
            {

            }

        }

        int count = 32400;
        
        void dt_Tick(object sender, object e)
        {
            count -= 1;
            if (count == 0)
            {
                Licence l = new Licence();
                l.Show();
                this.Hide();
            }
           

        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            

        }
        public void validate()
        {
            if (one.coins > 0 && one.coins <= 20)
            {
                textBlock8.Text = 1.ToString();
                button1.IsEnabled = true;
                //button2.IsEnabled = false;
            }
            
            if (one.coins > 20 && one.coins <= 40)
            {
                textBlock8.Text = 2.ToString();
                button2.IsEnabled = true;
                button1.IsEnabled = false;
            }
            if (one.coins > 40 && one.coins <= 60)
            {
                textBlock8.Text = 3.ToString();
                button3.IsEnabled = true;
                button1.IsEnabled = false;
            }
            if (one.coins > 60 && one.coins <= 80)
            {
                textBlock8.Text = 4.ToString();
                button4.IsEnabled = true;
                button1.IsEnabled = false;
            }
            if (one.coins > 80 && one.coins <= 100)
            {
                textBlock8.Text = 5.ToString();
                button5.IsEnabled = true;
                button1.IsEnabled = false;
            }
            if (one.coins > 100 && one.coins <= 120)
            {
                textBlock8.Text = 6.ToString();
                button6.IsEnabled = true;
                button1.IsEnabled = false;
            }
            if (one.coins > 120 && one.coins <= 140)
            {
                textBlock8.Text = 7.ToString();
                button7.IsEnabled = true;
                button1.IsEnabled = false;
            }
            if (one.coins > 140 && one.coins <= 160)
            {
                textBlock8.Text = 8.ToString();
                button8.IsEnabled = true;
                button1.IsEnabled = false;
            }
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.coin = 0.ToString();
            button12.Visibility = System.Windows.Visibility.Hidden;
        }
       
    }
}
