namespace NumberBomb
{
    partial class PreGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreGame));
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.diffBox = new System.Windows.Forms.GroupBox();
            this.newGame = new System.Windows.Forms.Button();
            this.diffBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Checked = true;
            this.rbEasy.Location = new System.Drawing.Point(6, 21);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(138, 21);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "1 (Range: 1-100)";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(150, 21);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(138, 21);
            this.rbNormal.TabIndex = 1;
            this.rbNormal.Text = "2 (Range: 1-250)";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Location = new System.Drawing.Point(294, 21);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(138, 21);
            this.rbHard.TabIndex = 2;
            this.rbHard.Text = "3 (Range: 1-500)";
            this.rbHard.UseVisualStyleBackColor = true;
            this.rbHard.CheckedChanged += new System.EventHandler(this.rbHard_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number Bomb";
            // 
            // diffBox
            // 
            this.diffBox.Controls.Add(this.rbEasy);
            this.diffBox.Controls.Add(this.rbNormal);
            this.diffBox.Controls.Add(this.rbHard);
            this.diffBox.Location = new System.Drawing.Point(12, 68);
            this.diffBox.Name = "diffBox";
            this.diffBox.Size = new System.Drawing.Size(435, 50);
            this.diffBox.TabIndex = 4;
            this.diffBox.TabStop = false;
            this.diffBox.Text = "Difficulties";
            // 
            // newGame
            // 
            this.newGame.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.newGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame.ForeColor = System.Drawing.Color.Red;
            this.newGame.Location = new System.Drawing.Point(12, 124);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(432, 61);
            this.newGame.TabIndex = 5;
            this.newGame.Text = "Start the game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // PreGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 193);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.diffBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PreGame";
            this.Text = "Number Bomb";
            this.Load += new System.EventHandler(this.PreGame_Load);
            this.diffBox.ResumeLayout(false);
            this.diffBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox diffBox;
        private System.Windows.Forms.Button newGame;
    }
}

