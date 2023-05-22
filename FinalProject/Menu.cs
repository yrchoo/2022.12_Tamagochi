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
    public partial class Menu : GameSystem
    {
        
        public Menu()
        {
            InitializeComponent();
            mainForm.Controls.Add(this);
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            ps.changeGameSystem(this, ps.home);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ps.rest.setGold();
            ps.changeGameSystem(this, ps.rest);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ps.mini = new Minigame();
            ps.changeGameSystem(this, ps.mini);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ps.changeGameSystem(this, new Info());
        }
    }
}
