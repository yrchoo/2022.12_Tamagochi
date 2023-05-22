namespace FinalProject
{
    partial class Minigame
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.myBottle = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picAns = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myBottle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAns)).BeginInit();
            this.SuspendLayout();
            // 
            // myBottle
            // 
            this.myBottle.BackColor = System.Drawing.Color.Transparent;
            this.myBottle.Location = new System.Drawing.Point(125, 272);
            this.myBottle.Name = "myBottle";
            this.myBottle.Size = new System.Drawing.Size(120, 180);
            this.myBottle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myBottle.TabIndex = 0;
            this.myBottle.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picAns
            // 
            this.picAns.BackColor = System.Drawing.Color.Transparent;
            this.picAns.Location = new System.Drawing.Point(150, 50);
            this.picAns.Name = "picAns";
            this.picAns.Size = new System.Drawing.Size(200, 200);
            this.picAns.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAns.TabIndex = 1;
            this.picAns.TabStop = false;
            // 
            // Minigame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.part_time1;
            this.Controls.Add(this.picAns);
            this.Controls.Add(this.myBottle);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Minigame";
            ((System.ComponentModel.ISupportInitialize)(this.myBottle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox myBottle;
        private System.Windows.Forms.Timer timer1;
        private PictureBox picAns;
    }
}
