namespace FinalProject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            Character.mainForm = this;
            GameSystem.mainForm = this;
            PlaySystem.mainForm = this;
            PlaySystem playSystem = new PlaySystem();
        }
    }
}