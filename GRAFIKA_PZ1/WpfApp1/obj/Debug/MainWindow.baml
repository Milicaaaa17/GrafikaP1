   M S B A M L   `   `   `  ����\  XGMap.NET.WindowsForms, Version=1.7.0.0, Culture=neutral, PublicKeyToken=b85b9027b614afef\Bclr-namespace:GMap.NET.WindowsForms;assembly=GMap.NET.WindowsFormsGMap.NET.WindowsForms  5   	   T PGMap.NET.Core, Version=1.7.0.0, Culture=neutral, PublicKeyToken=b85b9027b614afef:-clr-namespace:GMap.NET;assembly=GMap.NET.CoreGMap.NET 5   	   [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms 5   	   B >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1 5	   	      WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   RgmfBclr-namespace:GMap.NET.WindowsForms;assembly=GMap.NET.WindowsForms     5   	   <gm-clr-namespace:GMap.NET;assembly=GMap.NET.Core     5   	   Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	   'localclr-namespace:WpfApp1     5	   	     � Title$  PZ1_Milica_Radovanovic��5   	   $	��450��6(   $	��800��65   .��5      � .+�5   
   ]� 
�������.+�5      o� -   5         o�Name$
 Menu��5      $	��Top=�6!   .@�5      m� -   5         m�Name$ DrawEllipse��5      $��Ellipse��60   
��� ��� �� Left$ 10��6X   $��Center=�6i   6�   m� 5      -   5        $ DrawPolygon��5      $��Polygon��60   
��� ���$ 50��6X   $��Center=�6i   6�   m� 5      -   5        $ AddText��5      $��Add text��6,   
��� ���$	 150��6U   $��Center=�6g   6�   m� 5      -   5        $
 Undo��5      $
��Undo��6)   
��� ���$	 200��6N   $��Center=�6`   6{   m� 5      -   5        $
 Redo��5      $
��Redo��6)   
��� ���$	 250��6O   $��Center=�6a   6|   m� 5      -   5        $ Clear��5      $��Clear��6*   
��� ���$	 300��6P   $��Center=�6b   6}   5      �� 5      -   5         ��Name$ slider��5       � Value$ 1Q�6%   $	��Top=�6/    � Minimum$ .1Q�6D    � Maximum$ 20Q�6Q   �� 5      -	   5        $
��Auto=�5      $
��Auto=�6>   .��5      �� -
   5         ��Name$ Canvass��5      
�������$
��1800��6F   $
��1800��6S   	 J� RenderTransformOrigin$	 	0.457,0.5&�6a   
 � LayoutTransform
 5      �� 5       �� ScaleX 6)   ��  �� ElementName$ slider�� �� Path$ Value� �� ScaleY 6[   �� $ slider��$ Value�5      5      5      5      5       