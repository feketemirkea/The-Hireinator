namespace Fereastra
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(100, 118);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Da";
            button1.UseVisualStyleBackColor = true;
            button1.KeyDown += Form1_KeyDown_KeyPress;
            button1.MouseMove += button1_Click_Move;
            // 
            // button2
            // 
            button2.Location = new Point(362, 118);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Nu";
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += button4_MouseClick_Close;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 45);
            label1.Name = "label1";
            label1.Size = new Size(399, 32);
            label1.TabIndex = 2;
            label1.Text = ">>Vrei sa te angajezi? CLICK AICI<<";
            label1.Click += button1_Click_OpenForm2;
            // 
            // button3
            // 
            button3.Location = new Point(100, 118);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 0;
            button3.Text = "Da";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button3.KeyDown += Form1_KeyDown_KeyPress;
            button3.MouseMove += button1_Click_Move;
            // 
            // button4
            // 
            button4.Location = new Point(362, 118);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 1;
            button4.Text = "Nu";
            button4.UseVisualStyleBackColor = true;
            button4.MouseClick += button4_MouseClick_Close;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(218, 118);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 3;
            label2.Text = "De ce se\nmisca butonu?";
            label2.Visible = false;
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 244);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(label2);
            Name = "Form1";
            Text = "The Hireinator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Label label2;
    }
}