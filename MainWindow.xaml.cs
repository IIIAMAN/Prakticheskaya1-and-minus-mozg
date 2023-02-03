using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using System.Xml.Linq;

namespace Praktannumber1
{
    public partial class MainWindow : Window
    {
        int igra = 1;
        int robot = 0;
        int pomoh = 0;

        List<int> list = new List<int> {1,2,3,4,5,6,7,8,9};

        public MainWindow()
        {
            InitializeComponent();
            Text.Content = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void start_Click(object sender, RoutedEventArgs e)
        {

            

            Text.Content = null;
            knopka1.Content = null;
            knopka2.Content = null;
            knopka3.Content = null;
            knopka4.Content = null;
            knopka5.Content = null;
            knopka6.Content = null;
            knopka7.Content = null;
            knopka8.Content = null;
            knopka9.Content = null;

            knopka1.IsEnabled = true;
            knopka2.IsEnabled = true;
            knopka3.IsEnabled = true;
            knopka4.IsEnabled = true;
            knopka5.IsEnabled = true;
            knopka6.IsEnabled = true;
            knopka7.IsEnabled = true;
            knopka8.IsEnabled = true;
            knopka9.IsEnabled = true;
            start.IsEnabled = false;
            nachalo();
        }
        private void nachalo()
        {
            if (igra == 1)
            {
                pomoh = 1;
                robot = 2;
            }
            if (igra == 2)
            {
                pomoh = 1;
                robot = 1;
            }
        }

        private void pobedakrest()
        {
            knopka1.IsEnabled = false;
            knopka2.IsEnabled = false;
            knopka3.IsEnabled = false;
            knopka4.IsEnabled = false;
            knopka5.IsEnabled = false;
            knopka6.IsEnabled = false;
            knopka7.IsEnabled = false;
            knopka8.IsEnabled = false;
            knopka9.IsEnabled = false;
            Text.Content = "Кресты WIN";
            Restart.IsEnabled = true;
        }

        private void nolikiwin()
        {
            knopka1.IsEnabled = false;
            knopka2.IsEnabled = false;
            knopka3.IsEnabled = false;
            knopka4.IsEnabled = false;
            knopka5.IsEnabled = false;
            knopka6.IsEnabled = false;
            knopka7.IsEnabled = false;
            knopka8.IsEnabled = false;
            knopka9.IsEnabled = false;
            Text.Content = "Нули WIN";
            Restart.IsEnabled = true;
        }
        private void nichiya()
        {
            knopka1.IsEnabled = false;
            knopka2.IsEnabled = false;
            knopka3.IsEnabled = false;
            knopka4.IsEnabled = false;
            knopka5.IsEnabled = false;
            knopka6.IsEnabled = false;
            knopka7.IsEnabled = false;
            knopka8.IsEnabled = false;
            knopka9.IsEnabled = false;
            Text.Content = "Ничья";
            Restart.IsEnabled = true;
        }
        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            list.Clear();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            if (igra == 1)
            {
                igra = 2;
                start_Click(sender, e);
            }
            else if (igra == 2)
            {

                igra = 1;
                start_Click(sender, e);
            }
        }
        private void robotbot(object sender, RoutedEventArgs e)
        {
            try
            {
                if (knopka1.Content == "Х" && knopka2.Content == "Х" && knopka3.Content == "Х")
                {
                    pobedakrest();
                }
                else if (knopka1.Content == "О" && knopka2.Content == "О" && knopka3.Content == "О")
                {
                    nolikiwin();
                }

                else if (knopka4.Content == "Х" && knopka5.Content == "Х" && knopka6.Content == "Х")
                {
                    pobedakrest();
                }
                else if (knopka4.Content == "О" && knopka5.Content == "О" && knopka6.Content == "О")
                {
                    nolikiwin();
                }

                else if (knopka7.Content == "Х" && knopka8.Content == "Х" && knopka9.Content == "Х")
                {
                    pobedakrest();
                }
                else if (knopka7.Content == "О" && knopka8.Content == "О" && knopka9.Content == "О")
                {
                    nolikiwin();
                }


                else if (knopka1.Content == "Х" && knopka4.Content == "Х" && knopka7.Content == "Х")
                {
                    pobedakrest();
                }
                else if (knopka1.Content == "О" && knopka4.Content == "О" && knopka7.Content == "О")
                {
                    nolikiwin();
                }


                else if (knopka2.Content == "Х" && knopka5.Content == "Х" && knopka8.Content == "Х")
                {
                    pobedakrest();
                }
                else if (knopka2.Content == "О" && knopka5.Content == "О" && knopka8.Content == "О")
                {
                    nolikiwin();
                }


                else if (knopka3.Content == "Х" && knopka6.Content == "Х" && knopka9.Content == "Х")
                {
                    pobedakrest();
                }
                else if (knopka3.Content == "О" && knopka6.Content == "О" && knopka9.Content == "О")
                {
                    nolikiwin();
                }


                else if (knopka1.Content == "Х" && knopka5.Content == "Х" && knopka9.Content == "Х")
                {
                    pobedakrest();
                }
                else if (knopka1.Content == "О" && knopka5.Content == "О" && knopka9.Content == "О")
                {
                    nolikiwin();
                }


                else if (knopka3.Content == "Х" && knopka5.Content == "Х" && knopka7.Content == "Х")
                {
                    pobedakrest();
                }
                else if (knopka3.Content == "О" && knopka5.Content == "О" && knopka7.Content == "О")
                {
                    nolikiwin();
                }
                else if (knopka1.IsEnabled == false && knopka2.IsEnabled == false && knopka3.IsEnabled == false && knopka4.IsEnabled == false && knopka5.IsEnabled == false && knopka6.IsEnabled == false && knopka7.IsEnabled == false && knopka8.IsEnabled == false && knopka9.IsEnabled == false)
                {
                    nichiya();
                }

                Random rnd = new Random();
                int value = rnd.Next(1, list.Count);

                if (list[value] == 0 && knopka1.IsEnabled == true)
                {
                    knopka1_Click(sender, e);
                }
                else if (list[value] == 1 && knopka2.IsEnabled == true)
                {
                    knopka2_Click(sender, e);
                }
                else if (list[value] == 2 && knopka3.IsEnabled == true)
                {
                    knopka3_Click(sender, e);
                }
                else if (list[value] == 3 && knopka4.IsEnabled == true)
                {
                    knopka4_Click(sender, e);
                }
                else if (list[value] == 4 && knopka5.IsEnabled == true)
                {
                    knopka5_Click(sender, e);
                }
                else if (list[value] == 5 && knopka6.IsEnabled == true)
                {
                    knopka6_Click(sender, e);
                }
                else if (list[value] == 6 && knopka7.IsEnabled == true)
                {
                    knopka7_Click(sender, e);
                }
                else if (list[value] == 7 && knopka8.IsEnabled == true)
                {
                    knopka8_Click(sender, e);
                }
                else if (list[value] == 8 && knopka9.IsEnabled == true)
                {
                    knopka9_Click(sender, e);
                }
            }
            catch
            {

            }
        }

        private void knopka1_Click(object sender, RoutedEventArgs e)
        {
            if (pomoh == 1)
            {
                if (igra == 1)
                {

                    knopka1.Content = "Х";
                    knopka1.IsEnabled = false;
                    list.Remove(0);
                    pomoh = 2;
                    robotbot(sender, e);
                }
                else if (igra == 2)
                {
                    knopka1.Content = "О";
                    knopka1.IsEnabled = false;
                    list.Remove(0);
                    pomoh = 2;
                    robotbot(sender, e);
                }
            }
            else if (pomoh == 2)
            {
                if (robot == 1)
                {
                    knopka1.Content = "Х";
                    knopka1.IsEnabled = false;
                    list.Remove(0);
                    pomoh = 1;
                }
                else if (robot == 2)
                {
                    knopka1.Content = "О";
                    knopka1.IsEnabled = false;
                    list.Remove(0);
                    pomoh = 1;
                }
            }
        }

        private void knopka2_Click(object sender, RoutedEventArgs e)
        {
            if (pomoh == 1)
            {
                if (igra == 1)
                {
                    knopka2.Content = "Х";
                    knopka2.IsEnabled = false;
                    list.Remove(1);
                    pomoh = 2;
                    robotbot(sender, e);
                }
                else if (igra == 2)
                {
                    knopka2.Content = "О";
                    knopka2.IsEnabled = false;
                    list.Remove(1);
                    pomoh = 2;
                    robotbot(sender, e);
                }
            }
            else if (pomoh == 2)
            {
                if (robot == 1)
                {
                    knopka2.Content = "Х";
                    knopka2.IsEnabled = false;
                    list.Remove(1);
                    pomoh = 1;

                }
                else if (robot == 2)
                {
                    knopka2.Content = "О";
                    knopka2.IsEnabled = false;
                    list.Remove(1);
                    pomoh = 1;

                }
            }

        }

        private void knopka3_Click(object sender, RoutedEventArgs e)
        {
            if (pomoh == 1)
            {
                if (igra == 1)
                {
                    knopka3.Content = "Х";
                    knopka3.IsEnabled = false;
                    list.Remove(2);
                    pomoh = 2;
                    robotbot(sender, e);
                }
                else if (igra == 2)
                {
                    knopka3.Content = "О";
                    knopka3.IsEnabled = false;
                    list.Remove(2);
                    pomoh = 2;
                    robotbot(sender, e);
                }
            }
            else if (pomoh == 2)
            {
                if (robot == 1)
                {
                    knopka3.Content = "Х";
                    knopka3.IsEnabled = false;
                    list.Remove(2);
                    pomoh = 1;

                }
                else if (robot == 2)
                {
                    knopka3.Content = "О";
                    knopka3.IsEnabled = false;
                    list.Remove(2);
                    pomoh = 1;

                }
            }
        }

        private void knopka4_Click(object sender, RoutedEventArgs e)
        {
            if (pomoh == 1)
            {
                if (igra == 1)
                {
                    knopka4.Content = "Х";
                    knopka4.IsEnabled = false;
                    list.Remove(3);
                    pomoh = 2;
                    robotbot(sender, e);
                }
                else if (igra == 2)
                {
                    knopka4.Content = "О";
                    knopka4.IsEnabled = false;
                    list.Remove(3);
                    pomoh = 2;
                    robotbot(sender, e);
                }
            }
            else if (pomoh == 2)
            {
                if (robot == 1)
                {
                    knopka4.Content = "Х";
                    knopka4.IsEnabled = false;
                    list.Remove(3);
                    pomoh = 1;

                }
                else if (robot == 2)
                {
                    knopka4.Content = "О";
                    knopka4.IsEnabled = false;
                    list.Remove(3);
                    pomoh = 1;

                }
            }
        }

        private void knopka5_Click(object sender, RoutedEventArgs e)
        {
            if (pomoh == 1)
            {
                if (igra == 1)
                {
                    knopka5.Content = "Х";
                    knopka5.IsEnabled = false;
                    pomoh = 2;
                    list.Remove(4);
                    robotbot(sender, e);
                }
                else if (igra == 2)
                {
                    knopka5.Content = "О";
                    knopka5.IsEnabled = false;
                    pomoh = 2;
                    list.Remove(4);
                    robotbot(sender, e);
                }
            }
            else if (pomoh == 2)
            {
                if (robot == 1)
                {
                    knopka5.Content = "Х";
                    knopka5.IsEnabled = false;
                    pomoh = 1;
                    list.Remove(4);
                }
                else if (robot == 2)
                {
                    knopka5.Content = "О";
                    knopka5.IsEnabled = false;
                    pomoh = 1;
                    list.Remove(4);
                }
            }
        }

        private void knopka6_Click(object sender, RoutedEventArgs e)
        {
            if (pomoh == 1)
            {
                if (igra == 1)
                {
                    knopka6.Content = "Х";
                    knopka6.IsEnabled = false;
                    pomoh = 2;
                    list.Remove(5);
                    robotbot(sender, e);
                }
                else if (igra == 2)
                {
                    knopka6.Content = "О";
                    knopka6.IsEnabled = false;
                    pomoh = 2;
                    list.Remove(5);
                    robotbot(sender, e);
                }
            }
            else if (pomoh == 2)
            {
                if (robot == 1)
                {
                    knopka6.Content = "Х";
                    knopka6.IsEnabled = false;
                    pomoh = 1;
                    list.Remove(5);

                }
                else if (robot == 2)
                {
                    knopka6.Content = "О";
                    knopka6.IsEnabled = false;
                    pomoh = 1;
                    list.Remove(5);
                }
            }
        }

        private void knopka7_Click(object sender, RoutedEventArgs e)
        {
            if (pomoh == 1)
            {
                if (igra == 1)
                {
                    knopka7.Content = "Х";
                    knopka7.IsEnabled = false;
                    pomoh = 2;
                    list.Remove(6);
                    robotbot(sender, e);
                }
                else if (igra == 2)
                {
                    knopka7.Content = "О";
                    knopka7.IsEnabled = false;
                    pomoh = 2;
                    list.Remove(6);
                    robotbot(sender, e);
                }
            }
            else if (pomoh == 2)
            {
                if (robot == 1)
                {
                    knopka7.Content = "Х";
                    knopka7.IsEnabled = false;
                    pomoh = 1;
                    list.Remove(6);

                }
                else if (robot == 2)
                {
                    knopka7.Content = "О";
                    knopka7.IsEnabled = false;
                    pomoh = 1;
                    list.Remove(6);
                }
            }
        }

        private void knopka8_Click(object sender, RoutedEventArgs e)
        {
            if (pomoh == 1)
            {
                if (igra == 1)
                {
                    knopka8.Content = "Х";
                    knopka8.IsEnabled = false;
                    pomoh = 2;
                    list.Remove(7);
                    robotbot(sender, e);
                }
                else if (igra == 2)
                {
                    knopka8.Content = "О";
                    knopka8.IsEnabled = false;
                    pomoh = 2;
                    list.Remove(7);
                    robotbot(sender, e);
                }
            }
            else if (pomoh == 2)
            {
                if (robot == 1)
                {
                    knopka8.Content = "Х";
                    knopka8.IsEnabled = false;
                    pomoh = 1;
                    list.Remove(7);
                }
                else if (robot == 2)
                {
                    knopka8.Content = "О";
                    knopka8.IsEnabled = false;
                    pomoh = 1;
                    list.Remove(7);
                }
            }
        }

        private void knopka9_Click(object sender, RoutedEventArgs e)
        {
            if (pomoh == 1)
            {
                if (igra == 1)
                {
                    knopka9.Content = "Х";
                    knopka9.IsEnabled = false;
                    pomoh = 2;
                    list.Remove(8);
                    robotbot(sender, e);
                }
                else if (igra == 2)
                {
                    knopka9.Content = "О";
                    knopka9.IsEnabled = false;
                    pomoh = 2;
                    list.Remove(8);
                    robotbot(sender, e);
                }
            }
            else if (pomoh == 2)
            {
                if (robot == 1)
                {
                    knopka9.Content = "Х";
                    knopka9.IsEnabled = false;
                    pomoh = 1;
                    list.Remove(8);
                }
                else if (robot == 2)
                {
                    knopka9.Content = "О";
                    knopka9.IsEnabled = false;
                    pomoh = 1;
                    list.Remove(8);
                }
            }
        }



    }
}
