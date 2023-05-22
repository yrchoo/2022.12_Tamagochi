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
    public partial class Minigame : GameSystem
    {
        private List<Image> bottles = new List<Image>();

        private bool isBottle = false;
        public bool isLeft = false;
        public bool isRight = false;
        public bool correcting = false;
        public bool isCorrect = false;
        private int botIndex = 0;
        private int frame = 0;
        private int count = 12;
        public int score = 0;

        public Minigame()
        {
            InitializeComponent();
            setImage();

            timer1.Interval = 200;
            timer1.Enabled= true;

            mainForm.Controls.Add(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                timer1.Stop();
                Character.Gold += score;
                Character.Exp += score / 100;
                ps.home.showResult(State.Minigame, score);
                ps.changeGameSystem(this, ps.home);
            }
            if (!isBottle)
            {
                getNewBottle(frame); return;
            }
            if (isLeft)
            {
                goLeft(frame); return;
            }
            if (isRight)
            {
                goRight(frame); return;
            }
            if(correcting)
            {
                checkAns(isCorrect, frame);
                return;
            }
        }

        public void setImage()
        {
            bottles.Add(new Bitmap("drink_bin_bottle_clear.png"));
            bottles.Add(new Bitmap("drink_bin_bottle_red.png"));
            bottles.Add(new Bitmap("drink_bin_bottle_green.png"));
            bottles.Add(new Bitmap("drink_bin_bottle_yellow.png"));

            myBottle.Parent = this;
            picAns.Parent = this;
            picAns.Visible = false;
        }

        public void getNewBottle(int f)
        {
            switch (f)
            {
                case 0:
                    botIndex = new Random().Next(0, 4);
                    myBottle.Image = bottles[botIndex];
                    myBottle.Top = 250;
                    myBottle.Left = 215;
                    myBottle.Height = 105;
                    myBottle.Width = 70;
                    myBottle.Visible = true;
                    frame++;
                    break;
                case 1:
                    myBottle.Top = 270;
                    myBottle.Left = 202;
                    myBottle.Height = 144;
                    myBottle.Width = 96;
                    frame++;
                    break;
                case 2:
                    myBottle.Top = 290;
                    myBottle.Left = 190;
                    myBottle.Height = 180;
                    myBottle.Width = 120;
                    
                    isBottle = true;
                    frame = 0;
                    break;
            }
            isRight = false;
            isLeft = false;
        }

        public void goLeft(int f)
        {
            switch (f)
            {
                case 0:
                    myBottle.Top = 290;
                    myBottle.Left = 190;
                    frame++;
                    break;
                case 1:
                    myBottle.Top = 290;
                    myBottle.Left = 135;
                    frame++;
                    break;
                case 2:
                    myBottle.Top = 290;
                    myBottle.Left = 70;
                    frame = 0;
                    correcting = true;
                    isCorrect = (botIndex % 2 == 0);
                    isLeft = false;
                    break;
            }
        }

        public void goRight(int f)
        {
            switch (f)
            {
                case 0:
                    myBottle.Top = 290;
                    myBottle.Left = 190;
                    frame++;
                    break;
                case 1:
                    myBottle.Top = 290;
                    myBottle.Left = 265;
                    frame++;
                    break;
                case 2:
                    myBottle.Top = 290;
                    myBottle.Left = 330;
                    frame = 0;
                    correcting = true;
                    isCorrect = (botIndex % 2 == 1);
                    isRight = false;
                    break;
            }
        }

        public void checkAns(bool correct, int f)
        {
            switch (f)
            {
                case 0:
                    if (correct)
                    {
                        picAns.Image = new Bitmap("mark_circle_ok.png");
                        score += 100; count--;
                    }
                    else
                        picAns.Image = new Bitmap("mark_batsu.png");
                    picAns.Visible = true;
                    frame++;
                    break;
                case 1:
                    frame++;
                    break;
                case 2:
                    picAns.Visible = false;
                    isBottle = false;
                    isLeft = false;
                    isRight = false;
                    myBottle.Visible = false;
                    correcting = false;
                    frame = 0;
                    break;
            }
        }

    }
}
