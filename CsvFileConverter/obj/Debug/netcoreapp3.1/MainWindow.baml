   M S B A M L   `   `   `  ����K  GCsvFileConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CsvFileConverterCsvFileConverter  5   	   !    CsvFileConverter.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CsvFileConverter     5   	     � Title$  CsvConverter��5   	   $	��450��6   $	��800��6+    � 
ResizeMode$ NoResize=�5	   	   .��5
      � $	��434��6   $��Bottom=�6    � ColumnDefinitions 5   
   �� 5      $��120px �6   �� 5      $��120px �6   �� 5      $��120px �6   �� 5      $��120px �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��20px �6   �� 5      $
��50px �6   �� 5      $
��50px �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ openFileBtn��5   (   $��Wczytaj plik��6   $
��Left=�6=   $��1��6X   $��Center=�6e   $	��110��6�   $��30��6�   $��5,0,0,0q�6�   �� 5   
   -   5        $ sortByNameBtn��5   .   $��Posortuj po nazwie��6   ${�False��6E   $
��Left=�6W   $��1��6r   $��1��6   $��Center=�6�   $	��110��6�   $��30��6�   $��5,0,0,0q�6�   �� 5   
   -   5        $ sortByPriceBtn��5   -   $��Posortuj po cenie��6   ${�False��6E   $��Center=�6W   $��1��6t   $��2��6�   $��Center=�6�   $	��110��6�   $��30��6�   6�   �� 5   
   -   5        $ searchByDescBtn��5   "   $��Szukaj��6   ${�False��6;   $
��Left=�6N   $��1��6i   $��3��6v   $��Center=�6�   $	��110��6�   $��30��6�   $��5,0,0,0q�6�   �� 5   
   -   5         ��Name$ searchTextBox��5      $�� ��6    �� TextWrapping$
 Wrap=�61   $
��Left=�6E   $��1��6`   $��4��6m   $��Center=�6}   $	��300��6�   $��5,0,0,0q�6�   $��29��6�   �� 5   
   -   5         ��Name$ fileNameLabel��5   )   $��Scieżka pliku:��6   $
��Left=�6@   $��Center=�6[   $��2��6v   $��0��6�   $��5��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataGrid��5       $
��Auto��6      AlternatingRowBackground
 ��ح�$��3��6Y   $��0��6f   $��5��6v   	 �� AlternationCount$	 2��6�   
   AutoGenerateColumns$
 False��6�      Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Nazwa��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 15* 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Name+6Q     5"      $
 Cena��6%   $	 15* 6Q    65   �� *Price+6Q     5#      $ Opis A��6%   $	 35* 6[    67   �� *Description.A+6[     5$      $ Opis B��6%   $	 35* 6[    67   �� *Description.B+6[   5&      5,      5/      