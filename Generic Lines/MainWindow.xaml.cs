﻿using System;
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

namespace Generic_Lines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            Soccer_Lines SoccerLinesWindow;
            SoccerLinesWindow = new Soccer_Lines();
            SoccerLinesWindow.SoccerLinesHandicap.Text = SoccerLinesCalcs.SoccerHandicap(-3, 3);
            SoccerLinesWindow.SoccerLinesTotal.Text = SoccerLinesCalcs.SoccerTotal(9, 14);
            SoccerLinesWindow.ShowDialog();
        }



        private void Soccer_HFav_HTot_Click(object sender, EventArgs e)
        {
            Soccer_Lines SoccerLinesWindow;
            SoccerLinesWindow = new Soccer_Lines();
            SoccerLinesWindow.SoccerLinesHandicap.Text = SoccerLinesCalcs.SoccerHandicap(-8, -3);
            SoccerLinesWindow.SoccerLinesTotal.Text = SoccerLinesCalcs.SoccerTotal(16, 24);
            SoccerLinesWindow.ShowDialog();
        }

        private void Soccer_AFav_HTot_Click(object sender, EventArgs e)
        {
            Soccer_Lines SoccerLinesWindow;
            SoccerLinesWindow = new Soccer_Lines();
            SoccerLinesWindow.SoccerLinesHandicap.Text = SoccerLinesCalcs.SoccerHandicap(3, 8);
            SoccerLinesWindow.SoccerLinesTotal.Text = SoccerLinesCalcs.SoccerTotal(16, 24);
            SoccerLinesWindow.ShowDialog();
        }

        private void Tennis_MGrass_P1_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(630, 700);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(550, 600);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_MGrass_Avg_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(580, 640);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(580, 640);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_MGrass_P2_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(550, 600);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(630, 700);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_MHard_P1_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(650, 720);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(570, 620);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_MHard_Avg_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(600, 660);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(600, 660);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_MHard_P2_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(570, 620);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(650, 720);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_MClay_P1_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(580, 630);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(500, 550);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_MClay_Avg_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(550, 600);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(550, 600);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_MClay_P2_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(500, 550);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(580, 630);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_WGrass_P1_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(550, 600);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(480, 530);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_WGrass_Avg_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(530, 580);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(530, 580);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_WGrass_P2_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(480, 530);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(550, 600);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_WHard_P1_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(580, 630);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(500, 550);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_WHard_Avg_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(550, 600);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(550, 600);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_WHard_P2_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(500, 550);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(580, 630);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_WClay_P1_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(530, 580);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(450, 500);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_WClay_Avg_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(500, 550);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(500, 550);
            TennisLinesWindow.ShowDialog();
        }

        private void Tennis_WClay_P2_Click(object sender, EventArgs e)
        {
            Tennis_Lines TennisLinesWindow;
            TennisLinesWindow = new Tennis_Lines();
            TennisLinesWindow.P1PercentageBox.Text = TennisLinesCalcs.ServePercentageP1(450, 500);
            TennisLinesWindow.P2PercentageBox.Text = TennisLinesCalcs.ServePercentageP2(530, 580);
            TennisLinesWindow.ShowDialog();
        }

        private void Basketball_SmHmFav_LoTot_Click(object sender, EventArgs e)
        {
            Basketball_Lines Basketball_Lines_Window;
            Basketball_Lines_Window = new Basketball_Lines();
            Basketball_Lines_Window.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(0, 20);
            Basketball_Lines_Window.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(220, 280);
            Basketball_Lines_Window.ShowDialog();
        }

        private void Basketball_SmAwFav_LoTot_Click(object sender, EventArgs e)
        {
            Basketball_Lines Basketball_Lines_Window;
            Basketball_Lines_Window = new Basketball_Lines();
            Basketball_Lines_Window.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(-20, 0);
            Basketball_Lines_Window.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(220, 280);
            Basketball_Lines_Window.ShowDialog();
        }

        private void Basketball_LrgHmFav_LoTot_Click(object sender, EventArgs e)
        {
            Basketball_Lines Basketball_Lines_Window;
            Basketball_Lines_Window = new Basketball_Lines();
            Basketball_Lines_Window.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(30, 80);
            Basketball_Lines_Window.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(220, 280);
            Basketball_Lines_Window.ShowDialog();
        }

        private void Basketball_LrgAwFav_LoTot_Click(object sender, EventArgs e)
        {
            Basketball_Lines Basketball_Lines_Window;
            Basketball_Lines_Window = new Basketball_Lines();
            Basketball_Lines_Window.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(-80, -30);
            Basketball_Lines_Window.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(220, 280);
            Basketball_Lines_Window.ShowDialog();
        }

        private void Basketball_SmHmFav_HiTot_Click(object sender, EventArgs e)
        {
            Basketball_Lines Basketball_Lines_Window;
            Basketball_Lines_Window = new Basketball_Lines();
            Basketball_Lines_Window.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(0, 20);
            Basketball_Lines_Window.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(350, 430);
            Basketball_Lines_Window.ShowDialog();
        }

        private void Basketball_SmAwFav_HiTot_Click(object sender, EventArgs e)
        {
            Basketball_Lines Basketball_Lines_Window;
            Basketball_Lines_Window = new Basketball_Lines();
            Basketball_Lines_Window.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(-20, 0);
            Basketball_Lines_Window.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(350, 430);
            Basketball_Lines_Window.ShowDialog();
        }

        private void Basketball_LrgHmFav_HiTot_Click(object sender, EventArgs e)
        {
            Basketball_Lines Basketball_Lines_Window;
            Basketball_Lines_Window = new Basketball_Lines();
            Basketball_Lines_Window.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(30, 100);
            Basketball_Lines_Window.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(350, 430);
            Basketball_Lines_Window.ShowDialog();
        }

        private void Basetball_LrgAwFav_HiTot_Click(object sender, EventArgs e)
        {
            Basketball_Lines Basketball_Lines_Window;
            Basketball_Lines_Window = new Basketball_Lines();
            Basketball_Lines_Window.BasketballHandicapBox.Text = BasketballLinesCalcs.BasketballHandicap(-100, -30);
            Basketball_Lines_Window.BasketballTotalBox.Text = BasketballLinesCalcs.BasketballTotal(350, 430);
            Basketball_Lines_Window.ShowDialog();
        }

        private void Soccer_AFav_NTot_Click(object sender, RoutedEventArgs e)
        {
                Soccer_Lines SoccerLinesWindow;
                SoccerLinesWindow = new Soccer_Lines();
                SoccerLinesWindow.SoccerLinesHandicap.Text = SoccerLinesCalcs.SoccerHandicap(3, 8);
                SoccerLinesWindow.SoccerLinesTotal.Text = SoccerLinesCalcs.SoccerTotal(11, 14);
                SoccerLinesWindow.ShowDialog();
        }
    }
  
}
