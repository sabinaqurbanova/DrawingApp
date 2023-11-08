namespace DrawingApp.Forms
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPink = new System.Windows.Forms.PictureBox();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.pbYellow = new System.Windows.Forms.PictureBox();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.pbOrange = new System.Windows.Forms.PictureBox();
            this.pbCyan = new System.Windows.Forms.PictureBox();
            this.pbRed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPink)).BeginInit();
            this.pnlCanvas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCyan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPink
            // 
            this.pbPink.BackColor = System.Drawing.Color.Fuchsia;
            this.pbPink.Location = new System.Drawing.Point(86, 40);
            this.pbPink.Name = "pbPink";
            this.pbPink.Size = new System.Drawing.Size(35, 35);
            this.pbPink.TabIndex = 0;
            this.pbPink.TabStop = false;
            this.pbPink.Click += new System.EventHandler(this.pbBlack_Click);
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.Controls.Add(this.panel1);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(800, 450);
            this.pnlCanvas.TabIndex = 1;
            this.pnlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown);
            this.pnlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseMove);
            this.pnlCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pbBlack);
            this.panel1.Controls.Add(this.pbGreen);
            this.panel1.Controls.Add(this.pbPink);
            this.panel1.Controls.Add(this.pbYellow);
            this.panel1.Controls.Add(this.pbBlue);
            this.panel1.Controls.Add(this.pbOrange);
            this.panel1.Controls.Add(this.pbCyan);
            this.panel1.Controls.Add(this.pbRed);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 77);
            this.panel1.TabIndex = 0;
            // 
            // pbBlack
            // 
            this.pbBlack.Location = new System.Drawing.Point(127, 40);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(35, 34);
            this.pbBlack.TabIndex = 0;
            this.pbBlack.TabStop = false;
            this.pbBlack.Click += new System.EventHandler(this.pbBlack_Click);
            // 
            // pbGreen
            // 
            this.pbGreen.BackColor = System.Drawing.Color.Lime;
            this.pbGreen.Location = new System.Drawing.Point(127, 3);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(35, 35);
            this.pbGreen.TabIndex = 0;
            this.pbGreen.TabStop = false;
            this.pbGreen.Click += new System.EventHandler(this.pbBlack_Click);
            // 
            // pbYellow
            // 
            this.pbYellow.BackColor = System.Drawing.Color.Yellow;
            this.pbYellow.Location = new System.Drawing.Point(86, 3);
            this.pbYellow.Name = "pbYellow";
            this.pbYellow.Size = new System.Drawing.Size(35, 35);
            this.pbYellow.TabIndex = 0;
            this.pbYellow.TabStop = false;
            this.pbYellow.Click += new System.EventHandler(this.pbBlack_Click);
            // 
            // pbBlue
            // 
            this.pbBlue.BackColor = System.Drawing.Color.Blue;
            this.pbBlue.Location = new System.Drawing.Point(45, 40);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(35, 35);
            this.pbBlue.TabIndex = 0;
            this.pbBlue.TabStop = false;
            this.pbBlue.Click += new System.EventHandler(this.pbBlack_Click);
            // 
            // pbOrange
            // 
            this.pbOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pbOrange.Location = new System.Drawing.Point(45, 3);
            this.pbOrange.Name = "pbOrange";
            this.pbOrange.Size = new System.Drawing.Size(35, 35);
            this.pbOrange.TabIndex = 0;
            this.pbOrange.TabStop = false;
            this.pbOrange.Click += new System.EventHandler(this.pbBlack_Click);
            // 
            // pbCyan
            // 
            this.pbCyan.BackColor = System.Drawing.Color.Cyan;
            this.pbCyan.Location = new System.Drawing.Point(4, 40);
            this.pbCyan.Name = "pbCyan";
            this.pbCyan.Size = new System.Drawing.Size(35, 35);
            this.pbCyan.TabIndex = 0;
            this.pbCyan.TabStop = false;
            this.pbCyan.Click += new System.EventHandler(this.pbBlack_Click);
            // 
            // pbRed
            // 
            this.pbRed.BackColor = System.Drawing.Color.Red;
            this.pbRed.Location = new System.Drawing.Point(4, 4);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(35, 35);
            this.pbRed.TabIndex = 0;
            this.pbRed.TabStop = false;
            this.pbRed.Click += new System.EventHandler(this.pbBlack_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCanvas);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pbPink)).EndInit();
            this.pnlCanvas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCyan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPink;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.PictureBox pbYellow;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.PictureBox pbOrange;
        private System.Windows.Forms.PictureBox pbCyan;
        private System.Windows.Forms.PictureBox pbRed;
    }
}