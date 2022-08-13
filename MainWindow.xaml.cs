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

namespace WpfAppProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("other buttons" );
        }


        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Clear();
            reservationSystem res;
            res = reservationSystem.GetInstance();
            for (int i = 0; i < res.reserved.Count; i++)
            {
                res.reserved[i] = false;
            }
            res.people.Clear();

        }

        private void Link1_Click(object sender, RoutedEventArgs e)
        {

            listbox1.Items.Clear();
            reservationSystem res;
            res = reservationSystem.GetInstance();
            res.SortNames();
            for (int i = 0; i < res.people.Count; i++)
            {
                String name = res.people[i].name + " ";
                for (int j = 0; j < res.people[i].seats.Count; j++)
                {
                    int index = res.people[i].seats[j];
                    name += res.seats[index];
                    name += " ";

                }
                listbox1.Items.Add(name);

            }
        }

        private void Link2_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Clear();
            
            reservationSystem res;
            res = reservationSystem.GetInstance();
            res.LongSort();
            for (int i = 0; i < res.people.Count; i++)
            {
                String name = res.people[i].name + " ";
                for (int j = 0; j < res.people[i].seats.Count; j++)
                {
                    int index = res.people[i].seats[j];
                    name += res.seats[index];
                    name += " ";

                }
                listbox1.Items.Add(name);

            }

        }

        private void Link3_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Clear();
            reservationSystem res;
            res = reservationSystem.GetInstance();
            List<char> newp = res.SeatsNotReserved();
            for (int i = 0; i < newp.Count; i++)
            {
                
                listbox1.Items.Add(newp[i]);

            }

        }

    }
}
