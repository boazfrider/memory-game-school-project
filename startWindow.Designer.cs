namespace WindowsFormsApplication1
{
    partial class startWindow
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
            this.playbtn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.maneText = new System.Windows.Forms.TextBox();
            this.Namel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playbtn
            // 
            this.playbtn.Enabled = false;
            this.playbtn.Location = new System.Drawing.Point(439, 310);
            this.playbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(149, 60);
            this.playbtn.TabIndex = 0;
            this.playbtn.Text = "Play";
            this.playbtn.UseVisualStyleBackColor = true;
            this.playbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(119, 153);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(9, 9);
            this.treeView1.TabIndex = 1;
            // 
            // maneText
            // 
            this.maneText.Location = new System.Drawing.Point(411, 255);
            this.maneText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maneText.Name = "maneText";
            this.maneText.Size = new System.Drawing.Size(203, 22);
            this.maneText.TabIndex = 2;
            this.maneText.TextChanged += new System.EventHandler(this.maneText_TextChanged);
            this.maneText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // Namel
            // 
            this.Namel.AutoSize = true;
            this.Namel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Namel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Namel.Location = new System.Drawing.Point(326, 255);
            this.Namel.Name = "Namel";
            this.Namel.Size = new System.Drawing.Size(66, 24);
            this.Namel.TabIndex = 3;
            this.Namel.Text = "Name:";
            this.Namel.Click += new System.EventHandler(this.label1_Click);
            // 
            // startWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.dontouch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 628);
            this.Controls.Add(this.Namel);
            this.Controls.Add(this.maneText);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.playbtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "startWindow";
            this.Text = "startWindow";
            this.Load += new System.EventHandler(this.startWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox maneText;
        private System.Windows.Forms.Label Namel;
    }
}