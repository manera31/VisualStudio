   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   H DClaseEmpleado, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null<.clr-namespace:Empleados;assembly=ClaseEmpleado	Empleados 5   	    	Empleados   Empleados.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7core&clr-namespace:System;assembly=mscorlib     5   	   @local.clr-namespace:Empleados;assembly=ClaseEmpleado     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
       
  myEnum S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� Type  Empleados.Party��%e   &	        S� 5   
   $ 	GetValues��6,   "  6C    5      M� 5      "  6"   5      5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5         AlternatingRowBackground
 ��ح� �� AlternationCount$ 2��6J   	   AutoGenerateColumns	 .  $��0,0,0,52q�6{   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6L     5      $ Title��6%    .  64   �� *Title+6N   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ 	ReElected��6)    .  6<   �� *WasReElected+6]    � ContextMenu 5      �� 5      .@�5      m� -   5        $
��Edit��5      6-   5      5!      �� 5"   
   -   5        $��Nuevo empleado��5"      $
��Left=�6*   $��
27,381,0,0q�6E   $	��Top=�6Y   $	��100��6q   6}   5#      5$      