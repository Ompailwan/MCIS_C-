namespace ProjectOne
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            button4 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuText;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(431, 109);
            label1.Name = "label1";
            label1.Size = new Size(0, 46);
            label1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(60, 232);
            button1.Name = "button1";
            button1.Size = new Size(197, 56);
            button1.TabIndex = 1;
            button1.Text = "Favourite Song";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(380, 232);
            button2.Name = "button2";
            button2.Size = new Size(219, 56);
            button2.TabIndex = 2;
            button2.Text = "Favourite Movie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.ForeColor = SystemColors.InfoText;
            button3.Location = new Point(757, 232);
            button3.Name = "button3";
            button3.Size = new Size(197, 56);
            button3.TabIndex = 3;
            button3.Text = "Favorite Food";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(431, 21);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 4;
            label2.Text = "Om's Favourites";
            // 
            // button4
            // 
            button4.Location = new Point(380, 377);
            button4.Name = "button4";
            button4.Size = new Size(225, 48);
            button4.TabIndex = 5;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(879, 502);
            label3.Name = "label3";
            label3.Size = new Size(225, 20);
            label3.TabIndex = 6;
            label3.Text = "Developer - Om Avinash Pailwan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 736);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Button button4;
        private Label label3;
    }
}
