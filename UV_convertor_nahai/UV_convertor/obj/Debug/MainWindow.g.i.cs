﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3F3362698A5E609C688E368ECB493169"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace UV_convertor {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal UV_convertor.MainWindow Mainwindow;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Gservice;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Gservice_measurement;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gmeasurement;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GClose;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle RCLose;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GMin;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle RMIN;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdMain;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.Chart simChart;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.LinearAxis linex;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.LinearAxis liney;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UV_convertor;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Mainwindow = ((UV_convertor.MainWindow)(target));
            return;
            case 2:
            this.Gservice = ((System.Windows.Controls.Grid)(target));
            
            #line 107 "..\..\MainWindow.xaml"
            this.Gservice.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Gservice_MouseEnter);
            
            #line default
            #line hidden
            
            #line 107 "..\..\MainWindow.xaml"
            this.Gservice.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Gservice_MouseLeave);
            
            #line default
            #line hidden
            
            #line 107 "..\..\MainWindow.xaml"
            this.Gservice.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Gservice_measurement = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.gmeasurement = ((System.Windows.Controls.Grid)(target));
            
            #line 110 "..\..\MainWindow.xaml"
            this.gmeasurement.MouseEnter += new System.Windows.Input.MouseEventHandler(this.gmeasurement_MouseEnter);
            
            #line default
            #line hidden
            
            #line 110 "..\..\MainWindow.xaml"
            this.gmeasurement.MouseLeave += new System.Windows.Input.MouseEventHandler(this.gmeasurement_MouseLeave);
            
            #line default
            #line hidden
            
            #line 110 "..\..\MainWindow.xaml"
            this.gmeasurement.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GBSetting_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GClose = ((System.Windows.Controls.Grid)(target));
            
            #line 115 "..\..\MainWindow.xaml"
            this.GClose.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Gmin_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 115 "..\..\MainWindow.xaml"
            this.GClose.MouseLeave += new System.Windows.Input.MouseEventHandler(this.GClose_MouseLeave);
            
            #line default
            #line hidden
            
            #line 115 "..\..\MainWindow.xaml"
            this.GClose.MouseEnter += new System.Windows.Input.MouseEventHandler(this.GClose_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RCLose = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 7:
            this.GMin = ((System.Windows.Controls.Grid)(target));
            
            #line 138 "..\..\MainWindow.xaml"
            this.GMin.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GMin_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RMIN = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 9:
            this.grdMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.simChart = ((System.Windows.Controls.DataVisualization.Charting.Chart)(target));
            return;
            case 11:
            this.linex = ((System.Windows.Controls.DataVisualization.Charting.LinearAxis)(target));
            return;
            case 12:
            this.liney = ((System.Windows.Controls.DataVisualization.Charting.LinearAxis)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
