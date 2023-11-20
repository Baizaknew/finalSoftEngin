namespace rock_paper_scissors_game
{
    partial class Game_Form
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
            this.label_PlayerWins = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ComputerWins = new System.Windows.Forms.Label();
            this.pictureBoxScissors = new System.Windows.Forms.PictureBox();
            this.pictureBoxPaper = new System.Windows.Forms.PictureBox();
            this.pictureBoxRock = new System.Windows.Forms.PictureBox();
            this.pictureBox_computer = new System.Windows.Forms.PictureBox();
            this.pictureBox_player = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_computer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).BeginInit();
            this.SuspendLayout();
            // 
            // label_PlayerWins
            // 
            this.label_PlayerWins.AutoSize = true;
            this.label_PlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PlayerWins.Location = new System.Drawing.Point(294, 156);
            this.label_PlayerWins.Name = "label_PlayerWins";
            this.label_PlayerWins.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_PlayerWins.Size = new System.Drawing.Size(49, 54);
            this.label_PlayerWins.TabIndex = 5;
            this.label_PlayerWins.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(382, 156);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(39, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "-";
            // 
            // label_ComputerWins
            // 
            this.label_ComputerWins.AutoSize = true;
            this.label_ComputerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ComputerWins.Location = new System.Drawing.Point(456, 156);
            this.label_ComputerWins.Name = "label_ComputerWins";
            this.label_ComputerWins.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_ComputerWins.Size = new System.Drawing.Size(49, 54);
            this.label_ComputerWins.TabIndex = 7;
            this.label_ComputerWins.Text = "0";
            // 
            // pictureBoxScissors
            // 
            this.pictureBoxScissors.Location = new System.Drawing.Point(526, 373);
            this.pictureBoxScissors.Name = "pictureBoxScissors";
            this.pictureBoxScissors.Size = new System.Drawing.Size(135, 122);
            this.pictureBoxScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxScissors.TabIndex = 4;
            this.pictureBoxScissors.TabStop = false;
            this.pictureBoxScissors.Click += new System.EventHandler(this.pictureBoxScissors_Click);
            // 
            // pictureBoxPaper
            // 
            this.pictureBoxPaper.Location = new System.Drawing.Point(335, 373);
            this.pictureBoxPaper.Name = "pictureBoxPaper";
            this.pictureBoxPaper.Size = new System.Drawing.Size(135, 122);
            this.pictureBoxPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPaper.TabIndex = 3;
            this.pictureBoxPaper.TabStop = false;
            this.pictureBoxPaper.Click += new System.EventHandler(this.pictureBoxPaper_Click);
            // 
            // pictureBoxRock
            // 
            this.pictureBoxRock.Location = new System.Drawing.Point(129, 373);
            this.pictureBoxRock.Name = "pictureBoxRock";
            this.pictureBoxRock.Size = new System.Drawing.Size(135, 122);
            this.pictureBoxRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRock.TabIndex = 2;
            this.pictureBoxRock.TabStop = false;
            this.pictureBoxRock.Click += new System.EventHandler(this.pictureBoxRock_Click);
            // 
            // pictureBox_computer
            // 
            this.pictureBox_computer.BackColor = System.Drawing.Color.White;
            this.pictureBox_computer.Location = new System.Drawing.Point(526, 43);
            this.pictureBox_computer.Name = "pictureBox_computer";
            this.pictureBox_computer.Size = new System.Drawing.Size(239, 230);
            this.pictureBox_computer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_computer.TabIndex = 1;
            this.pictureBox_computer.TabStop = false;
            // 
            // pictureBox_player
            // 
            this.pictureBox_player.BackColor = System.Drawing.Color.White;
            this.pictureBox_player.Location = new System.Drawing.Point(25, 43);
            this.pictureBox_player.Name = "pictureBox_player";
            this.pictureBox_player.Size = new System.Drawing.Size(239, 230);
            this.pictureBox_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_player.TabIndex = 0;
            this.pictureBox_player.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(202, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Baizak Zhumaev COM 21";
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ComputerWins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_PlayerWins);
            this.Controls.Add(this.pictureBoxScissors);
            this.Controls.Add(this.pictureBoxPaper);
            this.Controls.Add(this.pictureBoxRock);
            this.Controls.Add(this.pictureBox_computer);
            this.Controls.Add(this.pictureBox_player);
            this.Name = "Game_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game_Form";
            this.Load += new System.EventHandler(this.Game_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_computer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_player;
        private System.Windows.Forms.PictureBox pictureBox_computer;
        private System.Windows.Forms.PictureBox pictureBoxRock;
        private System.Windows.Forms.PictureBox pictureBoxPaper;
        private System.Windows.Forms.PictureBox pictureBoxScissors;
        private System.Windows.Forms.Label label_PlayerWins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ComputerWins;
        private System.Windows.Forms.Label label1;
    }
}