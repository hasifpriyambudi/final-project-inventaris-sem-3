   M S B A M L   `   `   `  ����F  Binventtaris, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:inventtaris.viewinventtaris.view  5      '    !inventtaris.view.pagePengembalian   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:inventtaris.view     5        N� Title$  pagePengembalian��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �  � RowDefinitions 5      �� 5      $��50 �6    �� 5      $��* �6    .+�5      �� $��Data Pengembalian��6   $
��Left=�60   $��10,0,0,0q�6K   $��Center=�6]   $	��209��6x   $
��Bold"�6�   $��20(�6�   &   System.Windows.Controls.DataGrid  5      $��10,10,10,10q�6      AutoGenerateColumns$
 True��6,   $��1��6G   5      � 5   
   $��1��6    5      �� 5      $
��Auto �6    .+�5      �� $
}�True��6    �� CornerRadius$ 10��6)   ���#f3f5f9$��0��6P   $��10,58,10,-123q�6]   $
��Auto��6t   $
��Auto��6�   ._�5      � $��2q�6    5      �� 5       $	��110 �6+   �� 5!      $	��200 �6+   .+�5#      �  5$      �� 5%      $��50 �6,   �� 5&      $��50 �6,   �� 5'      $��50 �6,   �� 5(      $��50 �6,   �� 5)      $��50 �6,   .+�5+      �� $��0��6    $	��0,5q�6-   $��ID Peminjaman:��6:   $��Center=�6S   $��Right=�6u   �� 5,      $��1��6    $	��0,5q�6-   $��Nama Member:��6:   $��Center=�6Q   $��Right=�6s   �� 5-      $��2��6    $	��0,5q�6-   $��Nama Barang:��6:   $��Center=�6Q   $��Right=�6s   �� 5.      $��3��6    $	��0,5q�6-   $��Jumlah Barang:��6:   $��Center=�6S   $��Right=�6u   5/      � 51      $��1��6    52      �� 53      $��50 �6,   �� 54      $��50 �6,   �� 55      $��50 �6,   �� 56      $��50 �6,   �� 57      $��50 �6,   .+�59      �� -   5         ��Name$ listPeminjaman��59   #   $��0��6;   $
��Left=�6H   $��Center=�6c   $	��200��6~   $��20��6�   �� 5:      -   5         ��Name$ namaPeminjam��5:   "   $��1��68   $
��Left=�6E   $��Center=�6`    �� TextWrapping$
 Wrap=�6{   $	��200��6�   ${�False��6�   ���	#FF7D879C � UseLayoutRounding$
 True��6�   �� 5;      -   5        $ 
namaBarang��5;   "   $��2��66   $
��Left=�6C   $��Center=�6^   $
 Wrap=�6y   $	��200��6�   ${�False��6�   ���	#FF7D879C6�   �� 5<      -   5        $ jumlahBarang��5<   "   $��3��68   $
��Left=�6E   $��Center=�6`   $
 Wrap=�6{   $	��200��6�   ${�False��6�   ���	#FF7D879C6�   � 5=      $��4��6    5>      �� 5?   "   $	��100 �63   �� 5@   "   $	��100 �63   .+�5B      �� -   5        	 ��Name$	 	btnTambah��5B   %   $��0��68   $��Tambah��6H   $
��Left=�6Y   $��Center=�6t   ���#0d6efd
�������$��70��6�   
 � 	Resources
 5C   "    �� 
TargetType �� Property �� Value��%^   '��       �� 5D   &   " ��6,   .�5E   *   ��  �@��CornerRadius$ 2��6I   5F   '   5G   #   5H      5I      5J      5K      5L      5M      5N      5O      