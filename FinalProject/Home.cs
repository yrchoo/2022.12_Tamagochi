using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Home : GameSystem
    {


        private int time = 0;

        public Home()
        {
            InitializeComponent();
            this.BackgroundImage = new Bitmap("room.png");
            mainForm.Controls.Add(this);

            c = SetCharacter();
            Character.image.Parent = this;
            Character.emotion.Parent = this;
            picSaying.Visible = false;
            picResult.Visible = false;
            lblResult.Visible = false;
            picResult.BringToFront();
        }

        private Character SetCharacter()
        {
            if (Character.Level == 0)
                return new LV1();
            else if (Character.Level == 1)
                return new LV2();
            else return new LV1();
        }

        public void showResult(State activity, int result)
        {
            switch (activity)
            {
                case State.Restaurant:
                    picResult.Image = new Bitmap("money_dollar_coin2.png");
                    break;
                case State.Minigame:
                    picResult.Image = new Bitmap("money_dollar_coin2.png");
                    lblResult.Text = "+" + result.ToString() + "G";
                    lblResult.Visible = true;
                    break;
            }
            picResult.Visible = true;
            picSaying.Visible = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if(time == 3)
            {
                picResult.Visible = false;
                picSaying.Visible = false;
                lblResult.Visible = false;
                timer1.Enabled = false;
            }
        }
    }
}
