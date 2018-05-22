using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace GZdoom_Multiplayer_Launcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String type = null;

        int playerCount = 2;
        String gameType = "";
        int difficulty = 2;
        int episode = 1;
        Boolean mapLoaded = false;
        int map = 1;
        String broadcast = "-private";
        int hPort = 5029;
        String hAC = "";

        String iP = "127.0.0.1";
        int cPort = 5029;
        String cAC = "";

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Host_Checked(object sender, RoutedEventArgs e)
        {
            hGrid.IsEnabled = true;
            cGrid.IsEnabled = false;
            Start.IsEnabled = true;
            type = "H";
        }

        private void Join_Checked(object sender, RoutedEventArgs e)
        {
            hGrid.IsEnabled = false;
            cGrid.IsEnabled = true;
            Start.IsEnabled = true;
            type = "C";
        }

        private void PlayerCount_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            playerCount = Convert.ToInt32(PlayerCount.Value);
        }

        private void Co_op_Selected(object sender, RoutedEventArgs e)
        {
            gameType = "";
        }

        private void Deathmatch_Selected(object sender, RoutedEventArgs e)
        {
            gameType = "-deathmatch";
        }

        private void Alternate_Deathmatch_Selected(object sender, RoutedEventArgs e)
        {
            gameType = "-altdeath";
        }

        private void D1_Selected(object sender, RoutedEventArgs e)
        {
            difficulty = 0;
        }

        private void D2_Selected(object sender, RoutedEventArgs e)
        {
            difficulty = 1;
        }

        private void D3_Selected(object sender, RoutedEventArgs e)
        {
            difficulty = 2;
        }

        private void D4_Selected(object sender, RoutedEventArgs e)
        {
            difficulty = 3;
        }

        private void D5_Selected(object sender, RoutedEventArgs e)
        {
            difficulty = 4;
        }

        private void Map_Loaded(object sender, RoutedEventArgs e)
        {
            mapLoaded = true;
        }

        private void E1_Selected(object sender, RoutedEventArgs e)
        {
            if (mapLoaded)
            {
                M1.Visibility = Visibility.Visible;
                M2.Visibility = Visibility.Visible;
                M3.Visibility = Visibility.Visible;
                M4.Visibility = Visibility.Visible;
                M5.Visibility = Visibility.Visible;
                M6.Visibility = Visibility.Visible;
                M7.Visibility = Visibility.Visible;
                M8.Visibility = Visibility.Visible;
                M9.Visibility = Visibility.Visible;
                M10.Visibility = Visibility.Collapsed;
                M11.Visibility = Visibility.Collapsed;
                M12.Visibility = Visibility.Collapsed;
                M13.Visibility = Visibility.Collapsed;
                M14.Visibility = Visibility.Collapsed;
                M15.Visibility = Visibility.Collapsed;
                M16.Visibility = Visibility.Collapsed;
                M17.Visibility = Visibility.Collapsed;
                M18.Visibility = Visibility.Collapsed;
                M19.Visibility = Visibility.Collapsed;
                M20.Visibility = Visibility.Collapsed;
                M21.Visibility = Visibility.Collapsed;
                M22.Visibility = Visibility.Collapsed;
                M23.Visibility = Visibility.Collapsed;
                M24.Visibility = Visibility.Collapsed;
                M25.Visibility = Visibility.Collapsed;
                M26.Visibility = Visibility.Collapsed;
                M27.Visibility = Visibility.Collapsed;
                M28.Visibility = Visibility.Collapsed;
                M29.Visibility = Visibility.Collapsed;
                M30.Visibility = Visibility.Collapsed;
                M31.Visibility = Visibility.Collapsed;
                M32.Visibility = Visibility.Collapsed;
                M33.Visibility = Visibility.Collapsed;
                M34.Visibility = Visibility.Collapsed;
                M35.Visibility = Visibility.Collapsed;
                M36.Visibility = Visibility.Collapsed;
                episode = 1;
                Map.SelectedIndex = 0;
            }
        }

        private void E2_Selected(object sender, RoutedEventArgs e)
        {
            if (mapLoaded)
            {
                M1.Visibility = Visibility.Collapsed;
                M2.Visibility = Visibility.Collapsed;
                M3.Visibility = Visibility.Collapsed;
                M4.Visibility = Visibility.Collapsed;
                M5.Visibility = Visibility.Collapsed;
                M6.Visibility = Visibility.Collapsed;
                M7.Visibility = Visibility.Collapsed;
                M8.Visibility = Visibility.Collapsed;
                M9.Visibility = Visibility.Collapsed;
                M10.Visibility = Visibility.Visible;
                M11.Visibility = Visibility.Visible;
                M12.Visibility = Visibility.Visible;
                M13.Visibility = Visibility.Visible;
                M14.Visibility = Visibility.Visible;
                M15.Visibility = Visibility.Visible;
                M16.Visibility = Visibility.Visible;
                M17.Visibility = Visibility.Visible;
                M18.Visibility = Visibility.Visible;
                M19.Visibility = Visibility.Collapsed;
                M20.Visibility = Visibility.Collapsed;
                M21.Visibility = Visibility.Collapsed;
                M22.Visibility = Visibility.Collapsed;
                M23.Visibility = Visibility.Collapsed;
                M24.Visibility = Visibility.Collapsed;
                M25.Visibility = Visibility.Collapsed;
                M26.Visibility = Visibility.Collapsed;
                M27.Visibility = Visibility.Collapsed;
                M28.Visibility = Visibility.Collapsed;
                M29.Visibility = Visibility.Collapsed;
                M30.Visibility = Visibility.Collapsed;
                M31.Visibility = Visibility.Collapsed;
                M32.Visibility = Visibility.Collapsed;
                M33.Visibility = Visibility.Collapsed;
                M34.Visibility = Visibility.Collapsed;
                M35.Visibility = Visibility.Collapsed;
                M36.Visibility = Visibility.Collapsed;
                episode = 2;
                Map.SelectedIndex = 9;
            }
        }

        private void E3_Selected(object sender, RoutedEventArgs e)
        {
            if (mapLoaded)
            {
                M1.Visibility = Visibility.Collapsed;
                M2.Visibility = Visibility.Collapsed;
                M3.Visibility = Visibility.Collapsed;
                M4.Visibility = Visibility.Collapsed;
                M5.Visibility = Visibility.Collapsed;
                M6.Visibility = Visibility.Collapsed;
                M7.Visibility = Visibility.Collapsed;
                M8.Visibility = Visibility.Collapsed;
                M9.Visibility = Visibility.Collapsed;
                M10.Visibility = Visibility.Collapsed;
                M11.Visibility = Visibility.Collapsed;
                M12.Visibility = Visibility.Collapsed;
                M13.Visibility = Visibility.Collapsed;
                M14.Visibility = Visibility.Collapsed;
                M15.Visibility = Visibility.Collapsed;
                M16.Visibility = Visibility.Collapsed;
                M17.Visibility = Visibility.Collapsed;
                M18.Visibility = Visibility.Collapsed;
                M19.Visibility = Visibility.Visible;
                M20.Visibility = Visibility.Visible;
                M21.Visibility = Visibility.Visible;
                M22.Visibility = Visibility.Visible;
                M23.Visibility = Visibility.Visible;
                M24.Visibility = Visibility.Visible;
                M25.Visibility = Visibility.Visible;
                M26.Visibility = Visibility.Visible;
                M27.Visibility = Visibility.Visible;
                M28.Visibility = Visibility.Collapsed;
                M29.Visibility = Visibility.Collapsed;
                M30.Visibility = Visibility.Collapsed;
                M31.Visibility = Visibility.Collapsed;
                M32.Visibility = Visibility.Collapsed;
                M33.Visibility = Visibility.Collapsed;
                M34.Visibility = Visibility.Collapsed;
                M35.Visibility = Visibility.Collapsed;
                M36.Visibility = Visibility.Collapsed;
                episode = 3;
                Map.SelectedIndex = 18;
            }
        }

        private void E4_Selected(object sender, RoutedEventArgs e)
        {
            if (mapLoaded)
            {
                M1.Visibility = Visibility.Collapsed;
                M2.Visibility = Visibility.Collapsed;
                M3.Visibility = Visibility.Collapsed;
                M4.Visibility = Visibility.Collapsed;
                M5.Visibility = Visibility.Collapsed;
                M6.Visibility = Visibility.Collapsed;
                M7.Visibility = Visibility.Collapsed;
                M8.Visibility = Visibility.Collapsed;
                M9.Visibility = Visibility.Collapsed;
                M10.Visibility = Visibility.Collapsed;
                M11.Visibility = Visibility.Collapsed;
                M12.Visibility = Visibility.Collapsed;
                M13.Visibility = Visibility.Collapsed;
                M14.Visibility = Visibility.Collapsed;
                M15.Visibility = Visibility.Collapsed;
                M16.Visibility = Visibility.Collapsed;
                M17.Visibility = Visibility.Collapsed;
                M18.Visibility = Visibility.Collapsed;
                M19.Visibility = Visibility.Collapsed;
                M20.Visibility = Visibility.Collapsed;
                M21.Visibility = Visibility.Collapsed;
                M22.Visibility = Visibility.Collapsed;
                M23.Visibility = Visibility.Collapsed;
                M24.Visibility = Visibility.Collapsed;
                M25.Visibility = Visibility.Collapsed;
                M26.Visibility = Visibility.Collapsed;
                M27.Visibility = Visibility.Collapsed;
                M28.Visibility = Visibility.Visible;
                M29.Visibility = Visibility.Visible;
                M30.Visibility = Visibility.Visible;
                M31.Visibility = Visibility.Visible;
                M32.Visibility = Visibility.Visible;
                M33.Visibility = Visibility.Visible;
                M34.Visibility = Visibility.Visible;
                M35.Visibility = Visibility.Visible;
                M36.Visibility = Visibility.Visible;
                episode = 4;
                Map.SelectedIndex = 27;
            }
        }

        private void Map_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine("Map selection changed");
            if (episode == 1)
            {
                map = Map.SelectedIndex + 1;
            }
            else if (episode == 2)
            {
                map = Map.SelectedIndex - 8;
            }
            else if (episode == 3)
            {
                map = Map.SelectedIndex - 17;
            }
            else if (episode == 4)
            {
                map = Map.SelectedIndex - 26;
            }
            else
            {
                map = 1;
            }
        }

        private void pNo_Checked(object sender, RoutedEventArgs e)
        {
            broadcast = "-private";
        }

        private void pYes_Checked(object sender, RoutedEventArgs e)
        {
            broadcast = "";
        }

        private void HPort_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void HPort_TextChanged(object sender, TextChangedEventArgs e)
        {
            hPort = Convert.ToInt32(HPort.Text);
        }

        private void HAC_TextChanged(object sender, TextChangedEventArgs e)
        {
            hAC = HAC.Text;
        }

        private void IP_TextChanged(object sender, TextChangedEventArgs e)
        {
            iP = IP.Text;
        }

        private void CPort_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void CPort_TextChanged(object sender, TextChangedEventArgs e)
        {
            cPort = Convert.ToInt32(CPort.Text);
        }

        private void CAC_TextChanged(object sender, TextChangedEventArgs e)
        {
            cAC = CAC.Text;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (type == "H")
            {
                ProcessStartInfo gzdoom = new ProcessStartInfo();
                gzdoom.FileName = @"gzdoom.exe";
                gzdoom.Arguments = @" zdoom -host " + playerCount + " " + gameType + " -warp " + episode + " " + map + " -skill " + difficulty + " -port " + hPort + " " + broadcast + " " + hAC;
                Process.Start(gzdoom);
                Environment.Exit(0);
            }
            else if (type == "C")
            {
                ProcessStartInfo gzdoom = new ProcessStartInfo();
                gzdoom.FileName = @"gzdoom.exe";
                gzdoom.Arguments = @" zdoom -join " + iP + " -port " + cPort + " " + cAC;
                Process.Start(gzdoom);
                Environment.Exit(0);
            }
        }
    }
}
