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
using System.Windows.Controls.DataVisualization.Charting;
namespace UV_convertor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Chart chart;
        public MainWindow()
        {
            InitializeComponent();
            chart = new Chart(Mainwindow, simChart);
        }

        private void Gservice_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Gservice_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Gservice_measurement.Visibility == Visibility.Visible)
            {
                Gservice_measurement.Visibility = Visibility.Hidden;
                Gservice.Background = new SolidColorBrush((Color)(ColorConverter.ConvertFromString("#FF667D8D")));
            }
            else if (Gservice_measurement.Visibility == Visibility.Hidden)
            {
                Gservice.Background = new SolidColorBrush((Color)(ColorConverter.ConvertFromString("#FF000000")));
                Gservice_measurement.Visibility = Visibility.Visible;
            
            }
          

        }

        private void GBSetting_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            string[] s = { "" };
            Microsoft.Win32.OpenFileDialog op = new Microsoft.Win32.OpenFileDialog();
            op.DefaultExt = ".txt";
            op.Filter = "txt documents (.txt)|*.txt";
          
            if (op.ShowDialog() == true)
            {
                s = System.IO.File.ReadAllLines(op.FileName);
            }

            calculate_data(s);
        }

        string[] first;
        string[] last;
        double []y;
        double[] y_Data;
        double []x;
      
        public void calculate_data(string[] s)
        {
            chart.fist_zero_index = 0;
            
            y = new double[s.Length];
            x = new double[s.Length];
            y_Data = new double[s.Length];
            first = s[0].Split('\t');
            double interval_data;
            last = s[s.Length-1].Split('\t');
            double firstd=double.Parse(first[0]);
            double lastd = double.Parse(last[0]);
           
            for (int i = 0; i < s.Length; i++)
            {
                first =(s[i].Split('\t'));
                if (first[1] == "0")
                {
                    y[i] = 0;
                   
                }
                else
                {

                    y[i] = double.Parse(first[1]);
                }
                if (y[i] == 0 && y[i - 1] == 0 && y[i -2] == 0)
                {
                    
                    if (chart.fist_zero_index==0) chart.fist_zero_index = i;
                
                }

              
               //  line= s[i].Split('\t');
            }
            chart.fist_zero_index -= 2;
            double delta = firstd -( s.Length - chart.fist_zero_index);
            firstd = s.Length-chart.fist_zero_index;
            lastd = delta;
            interval_data = (firstd - lastd) /  chart.fist_zero_index;
            x[0] = firstd;
            for (int i = 1; i < chart.fist_zero_index; i++)
            {

                x[i] = x[i - 1] - interval_data;


            }
            if (chart.fist_zero_index != 0)
            {
                //for (int i = 0; i < count_zero; i++)
                //{

                //    y_Data[i] = y[i];
                
                
                //}
                //for(int i=count_zero;i<(s.Length-count_zero)+1;i++)
                //{
                //    y_Data[i] =y[i];
                //}
            }
                linex.Maximum = firstd;
                linex.Minimum = lastd-200;
                linex.Interval = (firstd - lastd) / 10;
                liney.Maximum = Max(y)+1;
                liney.Minimum = 0;
                liney.Interval = (Max(y) - 0) / 10;
                
                chart.Draw_graph(x,y);
             

            
          
        }
        double Min(double[] number)
        {
            double min=number[0];
            for (int i = 0; i < number.Length;i++ )
            {

                if (min >= number[i]) min = number[i];


            }
            return min;
        }
        double Max(double[] number)
        {
            double max = number[0];
            for(int i=0;i<number.Length;i++)
            {
                if (max <= number[i]) max = number[i];
            
            
            
            }
            return max;

        }
        private void gmeasurement_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void gmeasurement_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void GMin_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Mainwindow.WindowState = WindowState.Minimized;
        }

        private void Gmin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Mainwindow.Close();
        }

        private void GClose_MouseLeave(object sender, MouseEventArgs e)
        {
            GClose.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF000000"));
        }

        private void GClose_MouseEnter(object sender, MouseEventArgs e)
        {
            GClose.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC71C1C"));
        }
    }
}
