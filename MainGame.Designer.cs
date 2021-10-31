namespace WindowsFormsApplication1
{
    partial class MainGame
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startbtn = new System.Windows.Forms.Button();
            this.PointLabel = new System.Windows.Forms.Label();
            this.levelShow = new System.Windows.Forms.Label();
            this.ScoreShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(212, 724);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(99, 35);
            this.startbtn.TabIndex = 0;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // PointLabel
            // 
            this.PointLabel.BackColor = System.Drawing.Color.Transparent;
            this.PointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.PointLabel.Location = new System.Drawing.Point(467, 718);
            this.PointLabel.Name = "PointLabel";
            this.PointLabel.Size = new System.Drawing.Size(135, 35);
            this.PointLabel.TabIndex = 2;
            this.PointLabel.Text = "0";
            this.PointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PointLabel.Click += new System.EventHandler(this.PointLabel_Click);
            // 
            // levelShow
            // 
            this.levelShow.AutoSize = true;
            this.levelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.levelShow.Location = new System.Drawing.Point(706, 727);
            this.levelShow.Name = "levelShow";
            this.levelShow.Size = new System.Drawing.Size(66, 24);
            this.levelShow.TabIndex = 3;
            this.levelShow.Text = "label1";
            this.levelShow.Click += new System.EventHandler(this.levelShow_Click);
            // 
            // ScoreShow
            // 
            this.ScoreShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ScoreShow.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ScoreShow.Location = new System.Drawing.Point(374, 730);
            this.ScoreShow.Name = "ScoreShow";
            this.ScoreShow.Size = new System.Drawing.Size(87, 42);
            this.ScoreShow.TabIndex = 4;
            this.ScoreShow.Text = "Score:";
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bomb;
            this.ClientSize = new System.Drawing.Size(784, 762);
            this.Controls.Add(this.ScoreShow);
            this.Controls.Add(this.levelShow);
            this.Controls.Add(this.PointLabel);
            this.Controls.Add(this.startbtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Label PointLabel;
        private System.Windows.Forms.Label levelShow;
        private System.Windows.Forms.Label ScoreShow;



    }
}

