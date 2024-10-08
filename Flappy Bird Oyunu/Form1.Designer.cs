namespace Flappy_Bird_Oyunu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Zemin = new System.Windows.Forms.PictureBox();
            this.BoruAlt = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.BoruUst = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).BeginInit();
            this.SuspendLayout();
            // 
            // Zemin
            // 
            this.Zemin.Image = global::Flappy_Bird_Oyunu.Properties.Resources.clouds2;
            this.Zemin.Location = new System.Drawing.Point(12, 521);
            this.Zemin.Name = "Zemin";
            this.Zemin.Size = new System.Drawing.Size(611, 63);
            this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Zemin.TabIndex = 4;
            this.Zemin.TabStop = false;
            // 
            // BoruAlt
            // 
            this.BoruAlt.Image = global::Flappy_Bird_Oyunu.Properties.Resources.pipeBottom;
            this.BoruAlt.Location = new System.Drawing.Point(415, 374);
            this.BoruAlt.Name = "BoruAlt";
            this.BoruAlt.Size = new System.Drawing.Size(100, 163);
            this.BoruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt.TabIndex = 3;
            this.BoruAlt.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.Image = global::Flappy_Bird_Oyunu.Properties.Resources.flappyBird;
            this.FlappyBird.Location = new System.Drawing.Point(31, 247);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(101, 78);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBird.TabIndex = 2;
            this.FlappyBird.TabStop = false;
            // 
            // BoruUst
            // 
            this.BoruUst.Image = global::Flappy_Bird_Oyunu.Properties.Resources.pipeTop;
            this.BoruUst.Location = new System.Drawing.Point(466, 12);
            this.BoruUst.Name = "BoruUst";
            this.BoruUst.Size = new System.Drawing.Size(100, 149);
            this.BoruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst.TabIndex = 0;
            this.BoruUst.TabStop = false;
            this.BoruUst.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ScoreText.Location = new System.Drawing.Point(12, 12);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(137, 38);
            this.ScoreText.TabIndex = 5;
            this.ScoreText.Text = "Score:0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(635, 594);
            this.Controls.Add(this.FlappyBird);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Zemin);
            this.Controls.Add(this.BoruAlt);
            this.Controls.Add(this.BoruUst);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BoruUst;
        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox BoruAlt;
        private System.Windows.Forms.PictureBox Zemin;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
    }
}

