   M S B A M L   `   `   `  ����D  @WPF_MySQL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPF_MySQL	WPF_MySQL  5   	       WPF_MySQL.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WPF_MySQL     5   	   -   5          � Title$  WPF-MySql User CRUD��5   	   $	��230��6%   $	��370��62    � 
ResizeMode$ NoResize=�6>    � WindowStartupLocation$ CenterScreen=�6T    � Icon$ resources/person.png��6y   .��5	      � .+�5
   
   ]� .+�5      c� -   5         c�Name$ toolbarNavigation��5      $	��Top=�61   $
��auto��6F   $��32��6S   .@�5      �� -   5         ��Name$ btnFirst��5       � ToolTip$  Muestra el primer registro��6+   .��5      �� $��resources/first.png��6   $��24��69   6F   5      �� 5      -   5        $ btnPrevious��5      $" Muestra el registro anterior��6.   .��5      �� $��resources/previous.png��6   $��24��6<   6I   5      �� 5      -   5        $ btnNext��5      $# Muestra el siguiente registro��6*   .��5      �� $��resources/next.png��6   $��24��68   6E   5      �� 5      -   5        $ btnLast��5      $! Muestra el último registro��6*   .��5      �� $��resources/last.png��6   $��24��68   6E   5      �� 5      �� 5      -   5        $ 	btnInsert��5      $ Inserta un registro��6,   .��5      �� $��resources/new.png��6   $��24��67   6D   5      �� 5      -   5        $ btnSave��5      $ Guarda un registro��6*   .��5      �� $��resources/save.png��6   $��24��68   6E   5      �� 5      -	   5        $ 	btnDelete��5      $ Borra un registro��6,   .��5       �� $��resources/delete.png��6   $��24��6:   6G   5!      �� 5"      �� 5#      -
   5        $ btnTable��5#      $( "Mostrar los registros en una tabla��6+   .��5$      �� $��resources/table.png��6   $��24��69   6F   5%      �� 5&      5'      � 5(      -   5         �Name$ 	gridUsers��5(      $��Bottom=�6&   $y�Visible=�6>    � ColumnDefinitions 5)      �� 5*      $��0.75* �6'   67   �� 5+      $��2.25* �6'   67   	 � RowDefinitions	 5-      �� 5.      $��1* �6$   62   �� 5/      $��1* �6$   62   �� 50      $��1* �6$   62   �� 51      $��1* �6$   62   .+�53      �� $��0��6   $��0��6(   $��ID��65   $��26��6B   $��72��6N   $��10, 5, 5, 5q�6Y   �� 54      $��0��6   $��1��6(   $��Nombre��65   $��26��6F   $��72��6R   $��10, 5, 5, 5q�6]   �� 55      $��0��6   $��2��6(   $��	Apellidos��65   $��26��6I   $��72��6U   $��10, 5, 5, 5q�6`   �� 56      $��0��6   $��3��6(   $��	Timestamp��65   $��26��6I   $��72��6U   $��10, 5, 5, 5q�6`   �� 57      -   5        
 ��Name$
 txtId��57   7   $��1��6   $��0��6*    �� TextWrapping$
 Wrap=�6F   $�� ��6Z   $��24��6b   $��50��6n   $��
5, 5, 5, 5q�6y   $
��Left=�6�   {�.  6�   �� 58      -   5        $
 txtName��58   7   $��1��6   $��1��6*   $
 Wrap=�6H   $�� ��6\   $��24��6d   $	��240��6p   $��
5, 5, 5, 5q�6|   $
��Left=�6�   6�   �� 59      -   5        $
 
txtSurname��59   7   $��1��6   $��2��6*   $
 Wrap=�6K   $�� ��6_   $��24��6g   $	��240��6s   $��
5, 5, 5, 5q�6   $
��Left=�6�   6�   �� 5:      -   5        $
 txtTimestamp��5:   7   $��1��6   $��3��6*   $
 Wrap=�6M   $�� ��6a   $��24��6j   $	��240��6v   $��
5, 5, 5, 5q�6�   $
��Left=�6�   {�.  6�   5;      5<      5=      5>      