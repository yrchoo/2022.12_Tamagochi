using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class StartScreen : GameSystem
    {

        public StartScreen()
        {
            InitializeComponent();
            findSaveFile();
        }

        private void findSaveFile()
        {
            if (File.Exists("characterData.JSON"))
            {
                string json = File.ReadAllText("characterData.JSON");
                var cd = JsonSerializer.Deserialize<CharacterData>(json);
                Character.setData(cd);
                StartGame();
            }
            else mainForm.Controls.Add(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Character.Name= txtName.Text;
            StartGame();
        }

        private void StartGame()
        {
            ps.home = new Home();
            ps.menu = new Menu();
            ps.rest = new Restaurant();
            ps.setGameSystem();
            ps.changeGameSystem(this, ps.home);
        }
    }
}
