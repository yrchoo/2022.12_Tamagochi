using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class PlaySystem : UserControl
    {
        public static Form1 mainForm;

        public Home home;
        public Menu menu;
        public Restaurant rest;
        public Minigame mini;


        public PlaySystem()
        {
            InitializeComponent();
            GameSystem.ps = this;
            StartScreen sc = new StartScreen();

            
            

            this.Top = 520;
            this.Left = 5;
            mainForm.Controls.Add(this);
        }

        public void setGameSystem()
        {
            menu.Visible = false;
            menu.Enabled = false;
            rest.Visible = false;
            rest.Enabled = false;
            
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            if (home.Visible)
            {
                changeGameSystem(home, menu);
                return;
            }

        }

        public void changeGameSystem(GameSystem currentGS, GameSystem newGS)
        {
            currentGS.Enabled = false;
            currentGS.Visible = false;
            newGS.Enabled = true;
            newGS.Visible = true;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (mini != null)
            {
                if (mini.Visible)
                {
                    mini.isLeft = true;
                }
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (mini != null)
            {
                if (mini.Visible)
                {
                    mini.isRight = true;
                }
            }
        }
    }
}
