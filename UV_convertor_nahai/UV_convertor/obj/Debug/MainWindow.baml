   M S B A M L   `   `   `  ����|  xSystem.Windows.Controls.DataVisualization.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35�rclr-namespace:System.Windows.Controls.DataVisualization;assembly=System.Windows.Controls.DataVisualization.Toolkit)System.Windows.Controls.DataVisualization  5      �{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting  5      �{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting  5   	   �rclr-namespace:System.Windows.Controls.DataVisualization;assembly=System.Windows.Controls.DataVisualization.Toolkit)System.Windows.Controls.DataVisualization  6�    UV_convertor   UV_convertor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   �datavisrclr-namespace:System.Windows.Controls.DataVisualization;assembly=System.Windows.Controls.DataVisualization.Toolkit     5      �chrt{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     5      �chartingToolkit{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     5   	   �visualizationToolkitrclr-namespace:System.Windows.Controls.DataVisualization;assembly=System.Windows.Controls.DataVisualization.Toolkit     6�   -   5          �Name$  
Mainwindow��5   -   � Title$ 
MainWindow��5   	   $	��350��6   $	��525��6)    � WindowStyle$
 None=�65    � 
ResizeMode$ NoResize=�6H    � WindowStartupLocation$ CenterScreen=�6^    � WindowState$ 	Maximized=�6�    � 	Resources 5         PolylineStyle �� 
TargetType �� Property	 �� Value  NumericAxisLabelStyleI   CSystem.Windows.Controls.DataVisualization.Charting.NumericAxisLabelB   <System.Windows.Controls.DataVisualization.Charting.AxisLabel
 �� 
TargetType   FormattedContent  NormalBrush1 �� EndPoint �� 
StartPoint � Color � Offset  PlotAreaStyle  ChartTitleStyle25   /System.Windows.Controls.DataVisualization.Title  LineDataPointStyleF   @System.Windows.Controls.DataVisualization.Charting.LineDataPoint �� Path �� RelativeSource �� AncestorTypeC   =System.Windows.Controls.DataVisualization.Charting.LineSeries �Name J� Opacity ^� ToolTipB   <System.Windows.Controls.DataVisualization.Charting.DataPoint   IndependentValue �� ContentStringFormat   DependentValue  CommonLineSeries �� BasedOn ��Name   Points � Points   PolylineStyle  NumericAxisLabelStyle2  PlotAreaStyle2��%�  &	        &	 G     &	 �    &	 d    &	 �    &	 )    &	 �    7 &	 �    &	     7  �� 5   
   " �6&   .�5      ��  � ��$	 5��60   5      �� 5   
   "  6.   .�5      ��  � ��
	 �����6+   �� 5       � ��$	 Tahama)�6+   �� 5       � ��$	 14(�6)   �� 5       � ��	 .  6*   �� 5       �@ StringFormat$	 	{0:0.###}��6-   �� 5       � ��	 5      �� 5      "
  6&   .R�5      �� #��z 6$   5      5      �� 5       � ��$	 SemiBold"�6+   5      �� 5   
   $	 1,0&�63   $	 0,0&�6B   .��5      � $ 	#FF51FF00��6   $ 5Q�6-   � 5      $ 	#FF1F1F1F��6   $ .1Q�6-   5       �� 5!   
   " �6&   .�5"      ��  � ��
	 �   �6+   5#      �� 5$   
   "  6)   .�5%      ��  � y�$	 	Collapsed=�6+   �� 5&       � ��	 �	#FF8B52526+   5'      �� 5*   
   "  6+   .�5,      ��  � ��	 5-      �� 5.      $	 Tag�6    6)   �� "  50      �� 51       � ��	 6,   Z� �� 52       � ��$	 2q�60   �� 53       � ��	 .  6*   �� 54       � ��$	 0��6'   �� 55       � ��$	 0��6&   �� 56       � ��	 57      �� 58      "
  6&   .R�59      � $
 Root��6   $ 1Q�6-    5:      �� 5;   "   $��2,2,2,2q�6-   .+�5<   &   �� #��z 65   $ X-Value: {0:HH:mm:ss}��6b   �� 5=   &   #��z 65   $ Y-Value: {0:###.###}��6`   5>   #   .+�5@      A� #��z��6&   #��z��6Z   #��z��6�   5A      5B      5D      5E      �� 5G   
   "  6)   8   .�5H      ��  � ��	 5I      �� 5J      "
  6&   .R�5K      �� $ PlotArea��6!   .+�5L      � # z 6'   #��z 6�   ��6I   �� *Tag+ �� "  6�   5M      5N      5P      5Q      �� 5R   
   "  6/   .�5S      ��  � ��	 �	#FF2EFF006+   �� 5T       � ��$	 Tahama)�6+   �� 5U       � ��$	 9(�6)   �� 5V       � ��	 .  6*   �� 5W       �@ StringFormat$	 	{0:0.###}��6-   �� 5X       � ��	 5Y      �� 5Z      "
  6&   .R�5[      �� #��z 6$   5\      5^      5_      �� 5`   
   " �6'   .�5a      ��  � ��8	   6+   5b      5c      ��5d      �� 5e   
   $ 0.5,1&�6   $ 0.5,0&�6/   .��5f      � $ Black��6   $ 0Q�6)   � 5g      $ White��6   $ 1Q�6)   5h      .��5j      � ���	#FF667D8D.+�5k   
   � -   5        $ Gservice��5k      $��21��6!   $	��Top=�6-   $
��Left=�6�   $��45��6�   .+�5l      �� $
��Open��6   $��0,-3,-3,-10q�6#   $
��Left=�68   $��48��6S   $��SemiBold"�6^   
�������6t   � 5m      -   5        $ Gservice_measurement��5m      $
��Left=�61   $	��100��6L   $��0,21,-76,-100q�6Y   $	��Top=�6p   $	��121��6�   $y�Hidden=�6�   .+�5n      � -   5        $ gmeasurement��5n      $
��Left=�6-   $��21��6H   $	��Top=�6T   $	��121��6l   
���   �.+�5o      �� $��Measurement��6   $
��Left=�62   $��0,-2,0,0q�6M   $	��Top=�6_   $	��100��6w   $��23��6�   $��Medium"�6�   
�������6�   5p      5q      5r      � 5s   
   -   5        $ GClose��5s       J� RenderTransformOrigin$ 1.388,0.487&�6   $��Right=�6r   $��19��6�   
���   �$��0,3,5,0q�6�   $��23��6�   $	��Top=�6�   z�5t      V� 5u      .~�5v      �� �� 5w      �� 5x      T� 5y      5z      .+�5|      �� -   5         ��Name$ RCLose��5|      ���	#FF10BAEC$ 0.5,0.5&�6<   ��5}      �� 5~        �� ImageSource$  	close.png��6!   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      5�      5�      � 5�   
   -   5        $
 GMin��5�      $ 
2.488,0.48&�6   $��Right=�6q   $��21��6�   $��0,3,29,0q�6�   
���   �$��23��6�   $	��Top=�6�   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      .+�5�      �� -   5        $
 RMIN��5�      ���	#FF10BAEC$ 0.5,0.5&�69   ��5�      �� 5�      $  minimize.png��6!   ! j� Stretch$! Uniform=�6<   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      5�      5�      � 5�   
   -	   5        $ grdMain��5�      $��63,90,75,27q�6    " � RowDefinitions" 5�      �� 5�      $��6* �6    �� 5�      $
��Auto �6    .+�5�      >   8System.Windows.Controls.DataVisualization.Charting.Chart  -
   5        #  Name$# simChart��5�   $   $   PlotAreaStyle#$ [ 67   %   
TitleStyle#% [ 6g   $��
0,-25,0,-3q�6�   $��2��6�   ��6�   Z� &   LegendStyle& 5�      �� 5�      6   0System.Windows.Controls.DataVisualization.Legend"  6   .�5�      ��  � ��$	 0��62   5�      '   Axes' 5�      C	   =System.Windows.Controls.DataVisualization.Charting.LinearAxis	  -   5        ( 	 Name$( linex��5�   1   D
   >System.Windows.Controls.DataVisualization.Charting.DisplayAxis) 
  AxisLabelStyle#) [ 6@   =   7System.Windows.Controls.DataVisualization.Charting.Axis*   Orientation$* X=�6x   D   >System.Windows.Controls.DataVisualization.Charting.NumericAxis+   Minimum�   �System.Windows.Controls.DataVisualization.Charting.NullableConverter`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]$+ 0 6�   ,   Maximum$	, 1.1 6�   - 
  ShowGridLines- . . 
  Title$.  ��6�   / 	  Interval$	/ 0.1 6�   ���	#FFF3E49F$��	0,3,1,-52q�6�   $��22(�6�   $��Times New Roman)�6  $ 0.5,0.5&�6$  	  5�      -   5        $( liney��5�   1   #) [ 6@   $* Y=�6x   $+ 0 6�   $, 2 6�   - . $.  ��6�   $��
-23,4,1,-2q�6�   ���	#FFF3E49F$/ 1 6�   $��Times New Roman)�6�   $��24(�6  $��Right=�6!  $��51��6=  5�      5�      �� 5�   
   $��Graph:��6   $
��Left=�6!   $��	96,29,0,0q�6<   $	��Top=�6O   
�������$��20(�6z   $��SemiBold"�6�   5�      5�      