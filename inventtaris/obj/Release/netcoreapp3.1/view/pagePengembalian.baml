   M S B A M L   `   `   `  ���� F  Binventtaris, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:inventtaris.viewinventtaris.view  '    !inventtaris.view.pagePengembalian   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:inventtaris.view       N� Title$  pagePengembalian��.���  � ColumnDefinitions �� $��* ��� $��* �.+��  � RowDefinitions �� $��50 ��� $��* �.+��� $��Data Pengembalian��$
��Left=�$��10,0,0,0q�$��Center=�$	��209��$
��Bold"�$��20(�&   System.Windows.Controls.DataGrid  $��10,10,10,10q�   AutoGenerateColumns$
 True��$��1��� $��1�� �� $
��Auto �.+��� $
}�True�� �� CornerRadius$ 10�����#f3f5f9$��0��$��10,58,10,-123q�$
��Auto��$
��Auto��._�� $��2q� �� $	��110 ��� $	��200 �.+��  �� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 �.+��� $��0��$	��0,5q�$��ID Peminjaman:��$��Center=�$��Right=��� $��1��$	��0,5q�$��Nama Member:��$��Center=�$��Right=��� $��2��$	��0,5q�$��Nama Barang:��$��Center=�$��Right=��� $��3��$	��0,5q�$��Jumlah Barang:��$��Center=�$��Right=�� $��1�� �� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 �.+��� -    ��Name$ lisPeminjaman��$��0��$
��Left=�$��Center=�$	��200��$��20��.@��� .��Peminjaman Satu�� .��Peminjaman Dua�� .��Peminjaman Tiga�� .��Peminjaman Empat�� -    ��Name$ namaPeminjam��$��1��$
��Left=�$��Center=� �� TextWrapping$
 Wrap=�$	��200��${�False�����	#FF7D879C � UseLayoutRounding$
 True���� -   $ 
namaBarang��$��2��$
��Left=�$��Center=�$
 Wrap=�$	��200��${�False�����	#FF7D879C�� -   $ jumlahBarang��$��3��$
��Left=�$��Center=�$
 Wrap=�$	��200��${�False�����	#FF7D879C� $��4�� �� $	��100 ��� $	��100 �.+��� -   	 ��Name$	 	btnTambah��$��0��$��Tambah��$
��Left=�$��Center=����#0d6efd
�������$��70��
 � 	Resources
  �� 
TargetType �� Property �� Value��%9   '��       �� " ��.���  �@��CornerRadius$ 2��