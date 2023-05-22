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
    public partial class Restaurant : GameSystem
    {
        public Restaurant()
        {
            InitializeComponent();
            mainForm.Controls.Add(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ps.changeGameSystem(this, ps.menu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ps.changeGameSystem(this, ps.home);
            getFood(40, 20);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ps.changeGameSystem(this, ps.home);
            getFood(70, 30);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ps.changeGameSystem(this, ps.home);
            getFood(100, 50);
        }

        private void getFood(int cost, int food)
        {
            if (Character.Gold < cost)
            {

            }
            else
            {
                Character.Gold -= cost;
                c.Eat(food);
            }
        }

        public void setGold()
        {
            label1.Text = Character.Gold.ToString();
        }
    }
}
