using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace C_Sharp_WPF_Lesson2_15ki_HW_20160325
{
    //class move button
    public class MoveBt
    {
        public bool IsMove(int f_curr_row, int f_curr_colomn, int f_empty_row, int f_empty_colomn )
        {
            if (
                ((f_curr_row == f_empty_row & Math.Abs(f_curr_colomn - f_empty_colomn) < 2)
                |(f_curr_colomn == f_empty_colomn & Math.Abs(f_curr_row - f_empty_row) < 2 ))
                ) //top right position
            {
                return true;
            }
            return false;
        }
        public void SwapButons(UIElement f_elem_curr, UIElement f_elem_empty)
        {

            int curr_row = Grid.GetRow(f_elem_curr);
            int curr_colomn = Grid.GetColumn(f_elem_curr);
            int empty_row = Grid.GetRow(f_elem_empty);
            int empty_colomn = Grid.GetColumn(f_elem_empty);
            int temp_row = 0, temp_colomn=0;
            // if can you move do it
            if(IsMove(curr_row, curr_colomn, empty_row, empty_colomn) )
            {
                //temp
                temp_row = empty_row;
                temp_colomn = empty_colomn;
                //empty <- curr
                Grid.SetRow(f_elem_empty, curr_row);
                Grid.SetColumn(f_elem_empty, curr_colomn);
                //curr <- temp
                Grid.SetRow(f_elem_curr, temp_row);
                Grid.SetColumn(f_elem_curr, temp_colomn);
            }
            
        }

    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string pathh = "";
        private void bt_one_Click(object sender, RoutedEventArgs e)
        {
            MoveBt my_is = new MoveBt();
            my_is.SwapButons(bt_one, bt_empty);
        }
        private void bt_two_Click(object sender, RoutedEventArgs e)
        {
            MoveBt my_is = new MoveBt();
            my_is.SwapButons(bt_two, bt_empty);
        }
        private void bt_three_Click(object sender, RoutedEventArgs e)
        {
            MoveBt my_is = new MoveBt();
            my_is.SwapButons(bt_three, bt_empty);

        }
        private void bt_four_Click(object sender, RoutedEventArgs e)
        {
            MoveBt my_is = new MoveBt();
            my_is.SwapButons(bt_four, bt_empty);
        }
        private void bt_five_Click(object sender, RoutedEventArgs e)
        {
            MoveBt my_is = new MoveBt();
            my_is.SwapButons(bt_five, bt_empty);
        }
        private void bt_six_Click(object sender, RoutedEventArgs e)
        {
            MoveBt my_is = new MoveBt();
            my_is.SwapButons(bt_six, bt_empty);
        }
        private void bt_seven_Click(object sender, RoutedEventArgs e)
        {
            MoveBt my_is = new MoveBt();
            my_is.SwapButons(bt_seven, bt_empty);
        }
        private void bt_eight_Click(object sender, RoutedEventArgs e)
        {
            MoveBt my_is = new MoveBt();
            my_is.SwapButons(bt_eight, bt_empty);
        }
        private void bt_nine_Click(object sender, RoutedEventArgs e)
        {
            MoveBt my_is = new MoveBt();
            my_is.SwapButons(bt_nine, bt_empty);
        }
        private void bt_ten_Click(object sender, RoutedEventArgs e)
        {
            MoveBt my_is = new MoveBt();
            my_is.SwapButons(bt_ten, bt_empty);
        }
        private void bt_eleven_Click(object sender, RoutedEventArgs e)
        {
            MoveBt my_is = new MoveBt();
            my_is.SwapButons(bt_eleven, bt_empty);
        }
        private void bt_twelve_Click(object sender, RoutedEventArgs e)
        {
            MoveBt my_is = new MoveBt();
            my_is.SwapButons(bt_twelve, bt_empty);
        }
        private void bt_thirteen_Click(object sender, RoutedEventArgs e)
        {
            MoveBt my_is = new MoveBt();
            my_is.SwapButons(bt_thirteen, bt_empty);
        }
        private void bt_fourteen_Click(object sender, RoutedEventArgs e)
        {
            MoveBt my_is = new MoveBt();
            my_is.SwapButons(bt_fourteen, bt_empty);
        }
        private void bt_fifteen_Click(object sender, RoutedEventArgs e)
        {
            MoveBt my_is = new MoveBt();
            my_is.SwapButons(bt_fifteen, bt_empty);
        }
        public MainWindow()
        {
            InitializeComponent();
            
        }
    }
}
