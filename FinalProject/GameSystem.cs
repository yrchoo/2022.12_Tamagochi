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
    public partial class GameSystem : UserControl
    {
        public static Form1 mainForm;
        public static PlaySystem ps;

        public static Character c;
        public static int level = 0;

        public enum State { Restaurant, Minigame }


        public GameSystem()
        {
            InitializeComponent();
            level = Character.Level;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Top = 5;
            this.Left = 5;
        }

        
    }
}
