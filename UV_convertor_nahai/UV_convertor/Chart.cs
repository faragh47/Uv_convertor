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
using System.Threading;
using System.Collections.ObjectModel;

using System.Windows.Controls.DataVisualization.Charting;
namespace UV_convertor
{

    class Chart
    {
  
        ObservableCollection<ChartData> lineSeries1Data, lineSeries1Data_desorb;
        ChartData objChartData;
        LineSeries lineSeries;
        Point point;
        private System.Windows.Controls.DataVisualization.Charting.Chart simChart;
        Window Mainwindow;
        LineSeries temp;
        LinearAxis Liney;
        LineSeries chart1;
        double[] y_vd = new double[100];
        public Chart(Window Mainwindow, System.Windows.Controls.DataVisualization.Charting.Chart simChart)
        {

          //  Liney = liney;
           // Cs = (Coordinator_Bet)cs;
            objChartData = new ChartData();
            lineSeries1Data = new ObservableCollection<ChartData>();
            lineSeries1Data_desorb = new ObservableCollection<ChartData>(); ;
            // TODO: Complete member initialization
        
            this.Mainwindow = Mainwindow;
            this.chart1 = chart1;
            this.simChart = simChart;
            AddLineSeries();
          //  AddLineSeries_desorb();
           //  InitializeDataPoints();
            //Liney.Maximum = 0;
            //StartChartDataSimulation(0.3,0.2 );
        }


        private void AddLineSeries()
        {
            lineSeries = AddLineSeries(Brushes.Tomato);
            lineSeries.DependentValuePath = "Value";
            lineSeries.IndependentValuePath = "Name";
            lineSeries.ItemsSource = lineSeries1Data;
            this.simChart.Series.Add(lineSeries);
        }
        private void AddLineSeries_desorb()
        {
            lineSeries = AddLineSeries_desorb(Brushes.Blue);
            lineSeries.DependentValuePath = "Value";
            lineSeries.IndependentValuePath = "Name";
            lineSeries.ItemsSource = lineSeries1Data_desorb;
            this.simChart.Series.Add(lineSeries);
        }
        private LineSeries AddLineSeries(Brush lineColor)
        {
            temp = new LineSeries()
            {
                PolylineStyle = this.Mainwindow.FindResource("PolylineStyle") as Style,
                DataPointStyle = this.Mainwindow.FindResource("LineDataPointStyle") as Style,
                Style = this.Mainwindow.FindResource("CommonLineSeries") as Style,
                Tag = lineColor
            };
            return temp;
        }
        private LineSeries AddLineSeries_desorb(Brush lineColor)
        {
            temp = new LineSeries()
            {
             PolylineStyle = this.Mainwindow.FindResource("PolylineStyle") as Style,
                DataPointStyle = this.Mainwindow.FindResource("LineDataPointStyle") as Style,
                Style = this.Mainwindow.FindResource("CommonLineSeries") as Style,
                Tag = lineColor
            };
            return temp;
        }
   
        public void StartChartDataSimulation(double x,double y)
        {
            point.X = x;
            point.Y = y;
          //  lineSeries1Data.Add(point);
        }
        double counter = 0;
        Thread draw_thread;
        private void InitializeDataPoints()
        {

            lineSeries1Data.Add(new ChartData() { Name = 0.3, Value = 0.0 });
            Thread.Sleep(1000);
            
            for (int i = 0; i < 2; i++)
            {
                lineSeries1Data.Add(new ChartData() { Name = counter, Value = counter+0.15 });
                counter += 0.111;
            }
        }

       
        int counter_i=0;
        public int fist_zero_index = 0;
        public void Draw_graph(double[] x, double[] y)
        {
     
            for (int i = 0; i < fist_zero_index; i++)
            {
                lineSeries1Data.Add(new ChartData() { Name = x[i], Value = y[i] });
            }
        
        }
        private void draw_graph()
        {
          
      
         
        }
        //public void Draw_graph(double[] x, double[] y)
        //{

        //    Point[] Gain = new Point[fist_zero_index];
        //    for (int i = 0; i < fist_zero_index; i++)
        //    {
        //        Gain[i].X = x[i];
        //        Gain[i].Y = y[i];
        //    }
        //    chart1.ItemsSource = Gain;
        //}
    }
    public class ChartData
    {
        double _Name;
        double _Value;

        public double Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public double Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }

    }
}
