   M S B A M L   `   `   `  ����F  Binventtaris, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:inventtaris.viewinventtaris.view  5      %    inventtaris.view.pagePeminjaman   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:inventtaris.view     5        N� Title$  pagePeminjaman��5	      .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �  � RowDefinitions 5      �� 5      $��50 �6    �� 5      $	��200 �6    �� 5      $��30 �6    .+�5      � $��0��6    5      �� 5      $��* �6'   �� 5      $��70 �6'   �� 5      $	��200 �6'   .+�5      �� $��0��6   $��Data Peminjaman��6(   $
��Left=�6B   $��10,0,0,0q�6]   $��Center=�6o   $
��Bold"�6�   $��20(�6�   �� 5      $
��Cari��6   $��1��6'   $��Right=�67   $��7,0,0,0q�6S   $��Center=�6d   $
��Bold"�6   �� 5      -   5         ��Name$ 	keySearch��5      $��2��6-   $
��Left=�6=   $��Center=�6X   $��0 0 10 0q�6s    �� TextWrapping$
 Wrap=�6�   $	��140��6�   6�   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgPeminjaman��5      $��10,10,10,10q�6-      AutoGenerateColumns$ False��6B   $��1��6^      Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ ID Peminjaman��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 6b   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6@   �� *id_peminjaman+6b     5"      $ Nama Peminjam��6)   $		 120 6`   
 6@   �� *nama_member+6`     5#      $ Nama Barang��6)   $		 120 6^   
 6>   �� *nama_barang+6^     5$      $ Jumlah��6)   $	 70 6T   
 69   �� *jumlah+6T     5%      $ Tanggal��6)   $		 170 6a   
 6:   �� *tanggal_peminjaman+6a     5&      $ 
Nama Admin��6)   $		 120 6\   
 6=   �� *
nama_admin+6\   5(      � 5)      $��2��6    5*      �� 5+      $	��100 �6'   �� 5,      $	��100 �6'   .+�5.      � $��0��6   .+�5/      �� $��Total Data:��6   $��Right=�62   $	��Top=�6N   $
��Bold"�6f   50      � 51      $��1��6   .+�52      �� -   5         ��Name$ lblTotalData��52      $
��Left=�62   $	��Top=�6M   $
��Bold"�6e   53      54      55      � 57   
   $��1��6    58      �� 59      $
��Auto �6    .+�5;      �� $
}�True��6    �� CornerRadius$ 10��6)   ���#f3f5f9$��0��6P   $��10,58,10,-123q�6]   $
��Auto��6t   $
��Auto��6�   ._�5<      � $��2q�6    5=      �� 5>      $	��110 �6+   �� 5?      $	��200 �6+   .+�5A      �  5B      �� 5C      $��50 �6,   �� 5D      $��50 �6,   �� 5E      $��50 �6,   �� 5F      $��50 �6,   �� 5G      $��50 �6,   .+�5I      �� $��0��6    $	��0,5q�6-   $��Nama Member:��6:   $��Center=�6Q   $��Right=�6s   �� 5J      $��1��6    $	��0,5q�6-   $��Nama Barang:��6:   $��Center=�6Q   $��Right=�6s   �� 5K      $��2��6    $	��0,5q�6-   $��Jumlah Barang:��6:   $��Center=�6S   $��Right=�6u   �� 5L      $��3��6    $	��0,5q�6-   $��Jumlah Pinjam:��6:   $��Center=�6S   $��Right=�6u   5M      � 5O      $��1��6    5P      �� 5Q      $��50 �6,   �� 5R      $��50 �6,   �� 5S      $��50 �6,   �� 5T      $��50 �6,   �� 5U      $��50 �6,   .+�5W      �� -   5         ��Name$ 
listMember��5W   #   $��0��67   $
��Left=�6D   $��Center=�6_   $	��200��6z   ��6�   �� �� 5X      -   5        $ 
listBarang��5X   #   $��1��67   $
��Left=�6D   $��Center=�6_   $	��200��6z    �� SelectedValuePath$	 Tag��6�   6�   �� 5Y      -   5        $ jumlahBarang��5Y   "   $��2��68   $
��Left=�6E   $��Center=�6`   $
 Wrap=�6{   $	��200��6�   ${�False��6�   �� 5Z      -   5        $ jumlahPinjam��5Z   "   $��3��68   $
��Left=�6E   $��Center=�6`   $
 Wrap=�6{   $	��200��6�   6�   � 5[      $��5��6    5\      �� 5]   "   $	��100 �63   �� 5^   "   $	��100 �63   .+�5`      �� -   5         ��Name$ 	btnTambah��5`   %   $��0��68   $��Tambah��6H   $
��Left=�6Y   $��Center=�6t   ���#0d6efd
�������$��70��6�    � 	Resources 5a   "    �� 
TargetType �� Property �� Value��%^   '��       �� 5b   &   " ��6,   .�5c   *   ��  �@��CornerRadius$ 2��6I   5d   '   5e   #   5f      5g      5h      5i      5j      5k      5l      5m      