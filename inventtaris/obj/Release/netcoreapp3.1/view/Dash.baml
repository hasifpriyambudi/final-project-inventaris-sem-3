   M S B A M L   `   `   `  ���� F  Binventtaris, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:inventtaris.viewinventtaris.view      inventtaris.view.Dash   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:inventtaris.view       � Title$
  Dash��$	��450��$	��800��.���  � ColumnDefinitions �� $	��130 ��� .+�� -    �Name$ 	sidePanel��$
��Left=����#4e54c8 � RowDefinitions �� $��50 ��� $��30 ��� $��30 ��� $��30 ��� $��30 ��� $��10 ��� $��30 �.+��� -   $��50��$��0��$��
Inventaris��
�������$��16(�$��Center=�$��Center=�$
��Bold"�$
��Left=�$	��130��]� -    ]�Name$ 
menuMember��$��1��$��30��.+��� $��30��$��1��$��Member��
�������$��12(�$��10,0,0,0q�$��Center=�]� -   $ 
menuBarang��$��2��$��30��.+��� $��30��$��2��$��Barang��
�������$��12(�$��10,0,0,0q�$��Center=�]� -   $ menuPeminjaman��$��3��$��30��.+��� $��30��$��3��$��Peminjamaan��
�������$��12(�$��10,0,0,0q�$��Center=�]� -   $ menuPengembalian��$��4��$��30��.+��� $��30��$��4��$��Pengembalian��
�������$��12(�$��10,0,0,0q�$��Center=�]� $��5��$��10��.+��� $��1q�$��5��
���   �$	��118��$��2�� �� CornerRadius$ 5,5,5,5��]� -   $ 
menuLogout��$��6��$��30��.+��� $��30��$��6��$��Logout��
�������$��12(�$��10,0,0,0q�$��Center=�� $��1�� �� $��50 ��� .+�� $��	20,0,20,0q� �� �� .+��� $��Hai, Selamat Datang��$��14(�$��DemiBold"�$��Center=� � -     �Name$ 	FrameMain��$��1��$��	10,0,10,0q�  � NavigationUIVisibility$ Hidden=�  � Source$ pageHome.xaml?�