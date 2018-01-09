namespace SpaceInvaders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEnemyHealth = new System.Windows.Forms.Label();
            this.LabelHealth = new System.Windows.Forms.Label();
            this.TopWall = new System.Windows.Forms.PictureBox();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DownWall = new System.Windows.Forms.PictureBox();
            this.LeftWall = new System.Windows.Forms.PictureBox();
            this.RightWall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightWall)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayer.Image")));
            this.pictureBoxPlayer.Location = new System.Drawing.Point(570, 652);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(196, 104);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer.TabIndex = 0;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemy.Image")));
            this.pictureBoxEnemy.Location = new System.Drawing.Point(520, 51);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(105, 88);
            this.pictureBoxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnemy.TabIndex = 1;
            this.pictureBoxEnemy.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelEnemyHealth);
            this.panel1.Controls.Add(this.LabelHealth);
            this.panel1.Controls.Add(this.TopWall);
            this.panel1.Controls.Add(this.labelGameOver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DownWall);
            this.panel1.Controls.Add(this.LeftWall);
            this.panel1.Controls.Add(this.RightWall);
            this.panel1.Controls.Add(this.pictureBoxPlayer);
            this.panel1.Controls.Add(this.pictureBoxEnemy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 765);
            this.panel1.TabIndex = 2;
            // 
            // labelEnemyHealth
            // 
            this.labelEnemyHealth.AutoSize = true;
            this.labelEnemyHealth.ForeColor = System.Drawing.Color.White;
            this.labelEnemyHealth.Location = new System.Drawing.Point(182, 0);
            this.labelEnemyHealth.Name = "labelEnemyHealth";
            this.labelEnemyHealth.Size = new System.Drawing.Size(136, 17);
            this.labelEnemyHealth.TabIndex = 9;
            this.labelEnemyHealth.Text = "Enemy Health 100%";
            // 
            // LabelHealth
            // 
            this.LabelHealth.AutoSize = true;
            this.LabelHealth.ForeColor = System.Drawing.Color.White;
            this.LabelHealth.Location = new System.Drawing.Point(16, 0);
            this.LabelHealth.Name = "LabelHealth";
            this.LabelHealth.Size = new System.Drawing.Size(133, 17);
            this.LabelHealth.TabIndex = 8;
            this.LabelHealth.Text = "Player Health 100%";
            // 
            // TopWall
            // 
            this.TopWall.BackColor = System.Drawing.Color.Black;
            this.TopWall.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopWall.Location = new System.Drawing.Point(10, 0);
            this.TopWall.Name = "TopWall";
            this.TopWall.Size = new System.Drawing.Size(1090, 25);
            this.TopWall.TabIndex = 7;
            this.TopWall.TabStop = false;
            // 
            // labelGameOver
            // 
            this.labelGameOver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.Color.Black;
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = System.Drawing.Color.White;
            this.labelGameOver.Location = new System.Drawing.Point(650, 261);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(685, 135);
            this.labelGameOver.TabIndex = 6;
            this.labelGameOver.Text = "Game Over";
            this.labelGameOver.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // DownWall
            // 
            this.DownWall.BackColor = System.Drawing.Color.Black;
            this.DownWall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownWall.Location = new System.Drawing.Point(10, 755);
            this.DownWall.Name = "DownWall";
            this.DownWall.Size = new System.Drawing.Size(1090, 10);
            this.DownWall.TabIndex = 4;
            this.DownWall.TabStop = false;
            // 
            // LeftWall
            // 
            this.LeftWall.BackColor = System.Drawing.Color.Black;
            this.LeftWall.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftWall.Location = new System.Drawing.Point(0, 0);
            this.LeftWall.Name = "LeftWall";
            this.LeftWall.Size = new System.Drawing.Size(10, 765);
            this.LeftWall.TabIndex = 3;
            this.LeftWall.TabStop = false;
            // 
            // RightWall
            // 
            this.RightWall.BackColor = System.Drawing.Color.Black;
            this.RightWall.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightWall.Location = new System.Drawing.Point(1100, 0);
            this.RightWall.Name = "RightWall";
            this.RightWall.Size = new System.Drawing.Size(10, 765);
            this.RightWall.TabIndex = 2;
            this.RightWall.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1110, 765);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Space Invaders";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightWall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxEnemy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox LeftWall;
        private System.Windows.Forms.PictureBox RightWall;
        private System.Windows.Forms.PictureBox DownWall;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox TopWall;
        private System.Windows.Forms.Label LabelHealth;
        private System.Windows.Forms.Label labelEnemyHealth;
    }
}

