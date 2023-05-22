using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace FinalProject
{
    public partial class Info : GameSystem
    {
        CharacterData cd;

        public Info()
        {
            InitializeComponent();
            getCData();
            lbName.Text = cd.Name;
            lbLevel.Text = cd.Level.ToString();
            lbGold.Text = cd.Gold.ToString() + "G";
            mainForm.Controls.Add(this);
        }

        public void getCData()
        {
            cd = new CharacterData(Character.Name, Character.Exp, Character.Level, Character.hunger, Character.happiness, Character.Gold);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            var options = new JsonSerializerOptions { WriteIndented = true };

            string json = JsonSerializer.Serialize(cd, options);

            

            File.Delete("characterData.JSON");
            File.WriteAllText("characterData.JSON", json);
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ps.changeGameSystem(this, ps.menu);
        }
    }
}
