using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace FinalProject
{
    public class Character
        //think about to use inheritance
    {
        public static Form1 mainForm;

        public static List<Image> currentImgData = new List<Image>();

        public static PictureBox image = new PictureBox();

        public static PictureBox emotion = new PictureBox();

        public static Timer timer = new Timer();

        public enum State { Normal, Happy, Sad }
        public static State state = State.Normal;


        private static void MyTimer_Tick(object? sender, EventArgs e)
        {
            image.Left = x;
            image.Top = y;


            if (ani == 0)
                image.Image = currentImgData[0];
            if (ani == 4)
                image.Image = currentImgData[1];

            hunger -= 0.01;
            happiness -= 0.005;

            ani++;
            ani %= 8;

            ChangeEmotion();
            Emotion();
            checkExp();
        }

        public static int ani = 0;


        public static int Gold = 100;
        
        public static string Name;
        public static int Exp = 0;
        public static int maxExp = 100;
        public static int Level = 0;
        public static double hunger = 50;
        public static double happiness = 80;
        public static int clean = 100;

        public static int x = 250;
        public static int y = 350;

        public static bool showEmo = false;
        public static int emoTime = 0;


        static Character()
        {
            timer.Interval = 100;
            timer.Tick += MyTimer_Tick;
        }

        public static void resetState()
        {
            Exp = 0;
            Level = 0;
            hunger = 100;
            happiness = 50;
            clean = 100;
        }

        public static void setData(CharacterData cd)
        {
            Name = cd.Name;
            Exp = cd.Exp;
            Level = cd.Level;
            hunger = cd.Hunger;
            happiness = cd.Happiness;
            Gold = cd.Gold;
        }


        public static void ImageDataSet()
        {
            currentImgData.Clear();

            int j = 0;
            switch (state)
            {
                case State.Normal: j = 0; break;
                case State.Sad: j = 1; break;
                case State.Happy: j = 2; break;
            }

            for (int i = 0; i < 2; i++)
            {
                currentImgData.Add(new Bitmap($"{Level}_{j}_{i}.png"));
            }
        }

        public static void ChangeEmotion()
        {
            State newState = state;
            if (hunger < 30 || happiness < 30) newState = State.Sad;
            else if (hunger > 70 && happiness > 70) newState = State.Happy;
            else newState = State.Normal;
            if (state != newState)
            {
                state = newState;
                ImageDataSet();
            }
        }


        public Character(int level)
        {
            Level = level;
            ImageDataSet();
            image.Image = currentImgData[0];

            image.Height = 100;
            image.Width = 100;
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.BackColor = Color.Transparent;
            image.ForeColor = Color.Transparent;
            image.Left = x;
            image.Top = y;
            mainForm.Controls.Add(image);
            image.BringToFront();
            image.MouseClick += image_MouseClicked;

            emotion.Left= x + 25;
            emotion.Top= y - 50;
            emotion.Height = 50;
            emotion.Width = 50;
            emotion.SizeMode = PictureBoxSizeMode.StretchImage;
            emotion.BackColor = Color.Transparent;
            emotion.ForeColor = Color.Transparent;
            mainForm.Controls.Add(emotion);
            emotion.BringToFront();

            timer.Start();

        }

        private void image_MouseClicked(object? sender, MouseEventArgs e)
        {
            showEmo = true;
        }

        public void Eat(int food)
        {
            if (hunger + food > 100)
            {
                happiness -= 10;
            }
            else 
            { 
                hunger += food;
                happiness += 10;
                Exp += 15;
            }
        }

        private static void Emotion()
        {
            if(emoTime == 10)
            {
                showEmo = false;
            }
            if (showEmo)
            {
                if (hunger <= happiness && hunger <= 50)
                {
                    emotion.Image = new Bitmap("food_hamburger.png");
                }
                else if (happiness <= 50)
                {
                    emotion.Image = new Bitmap("mark_face_jito.png");
                }
                else
                    emotion.Image = new Bitmap("mark_face_laugh.png");

                emoTime++;
                emotion.Visible = true;
            }
            else
            {
                emoTime = 0;
                happiness++;
                emotion.Visible = false;
            }
        }

        private static void checkExp()
        {
            if(Exp >= maxExp)
            {
                Exp = 0;
                Level++;
            }
        }
    }
}
