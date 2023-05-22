namespace FinalProject
{
    partial class Home
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
            this.picSaying = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picResult = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSaying)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // picSaying
            // 
            this.picSaying.BackColor = System.Drawing.Color.Transparent;
            this.picSaying.BackgroundImage = global::FinalProject.Properties.Resources.fukidashi_bw04;
            this.picSaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSaying.Location = new System.Drawing.Point(294, 173);
            this.picSaying.Name = "picSaying";
            this.picSaying.Padding = new System.Windows.Forms.Padding(10);
            this.picSaying.Size = new System.Drawing.Size(148, 147);
            this.picSaying.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSaying.TabIndex = 0;
            this.picSaying.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picResult
            // 
            this.picResult.BackColor = System.Drawing.Color.White;
            this.picResult.Location = new System.Drawing.Point(341, 202);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(55, 55);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult.TabIndex = 1;
            this.picResult.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.Font = new System.Drawing.Font("VCR OSD Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(331, 260);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(75, 19);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "label1";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picSaying);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.picSaying)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picSaying;
        private System.Windows.Forms.Timer timer1;
        private PictureBox picResult;
        private Label lblResult;
    }
}
