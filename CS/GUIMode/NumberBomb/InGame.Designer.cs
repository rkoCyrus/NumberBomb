namespace NumberBomb
{
    partial class InGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InGame));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.guider = new System.Windows.Forms.Label();
            this.smallNum = new System.Windows.Forms.Label();
            this.bigNum = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.waitResult = new System.Windows.Forms.Timer(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(446, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(284, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(365, 279);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 75);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(446, 279);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 75);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(284, 360);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 75);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(365, 360);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 75);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(446, 360);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 75);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // guider
            // 
            this.guider.BackColor = System.Drawing.SystemColors.Info;
            this.guider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guider.Location = new System.Drawing.Point(12, 158);
            this.guider.Name = "guider";
            this.guider.Size = new System.Drawing.Size(776, 37);
            this.guider.TabIndex = 9;
            this.guider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smallNum
            // 
            this.smallNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.smallNum.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallNum.Location = new System.Drawing.Point(12, 9);
            this.smallNum.Name = "smallNum";
            this.smallNum.Size = new System.Drawing.Size(270, 137);
            this.smallNum.TabIndex = 10;
            this.smallNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bigNum
            // 
            this.bigNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bigNum.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bigNum.Location = new System.Drawing.Point(518, 9);
            this.bigNum.Name = "bigNum";
            this.bigNum.Size = new System.Drawing.Size(270, 137);
            this.bigNum.TabIndex = 11;
            this.bigNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(612, 360);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(176, 75);
            this.buttonEnter.TabIndex = 12;
            this.buttonEnter.Text = "Submit";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(527, 360);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 75);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(612, 279);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(176, 75);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // waitResult
            // 
            this.waitResult.Interval = 3000;
            this.waitResult.Tick += new System.EventHandler(this.waitResult_Tick);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(612, 198);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(176, 75);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "Backspace";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.bigNum);
            this.Controls.Add(this.smallNum);
            this.Controls.Add(this.guider);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InGame";
            this.Text = "Number Bomb";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InGame_FormClosing);
            this.Load += new System.EventHandler(this.InGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label guider;
        private System.Windows.Forms.Label smallNum;
        private System.Windows.Forms.Label bigNum;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Timer waitResult;
        private System.Windows.Forms.Button buttonBack;
    }
}