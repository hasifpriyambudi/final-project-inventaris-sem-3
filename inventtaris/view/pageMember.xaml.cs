using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace inventtaris.view{
    /// <summary>
    /// Interaction logic for pageMember.xaml
    /// </summary>
    public partial class pageMember : Page{

        // deklarasi objek
        controller.c_Member c_Member;

        // function yang akan dijalankan saat tampilan dibuka
        public pageMember(){
            InitializeComponent();
            // inisialisasi controller
            c_Member = new controller.c_Member(this);
            // get datagrid member
            c_Member.getData();
            // get total data member
            c_Member.totalData();
        }

        private void btnTambah(object sender, RoutedEventArgs e){
            c_Member.prosesTambah();
        }

        private void dgmember_SelectionChanged(object sender, SelectionChangedEventArgs e){
            if(dgmember.SelectedItem != null){
                object item = dgmember.SelectedItem;
                idMember.Text = (dgmember.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                namaMember.Text = (dgmember.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                emailMember.Text = (dgmember.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                nomorMember.Text = (dgmember.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                alamatMember.Text = (dgmember.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                // enable button update
                buttonUpdate.IsEnabled = true;
                buttonTambah.IsEnabled = false;
                buttonCancel.IsEnabled = true;
                buttonDelete.IsEnabled = true;
            }else{
                cancel();
            }
        }

        private void cancel(){
            idMember.Text = "";
            namaMember.Text = "";
            emailMember.Text = "";
            nomorMember.Text = "";
            alamatMember.Text = "";
            buttonUpdate.IsEnabled = false;
            buttonTambah.IsEnabled = true;
            buttonCancel.IsEnabled = false;
            buttonDelete.IsEnabled = false;
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e){
            cancel();
        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e){
            c_Member.updateMember();
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e){
            c_Member.deleteMember();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e){
            c_Member.searchMember();
        }
    }
}
