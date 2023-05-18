namespace ROTP.App
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
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button5 = new Button();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Location = new Point(25, 64);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 16;
            label2.Text = "OTP";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Location = new Point(25, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 14;
            label1.Text = "SecretKey";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(157, 137);
            button1.Name = "button1";
            button1.Size = new Size(80, 27);
            button1.TabIndex = 18;
            button1.Text = "Validation";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(86, 137);
            button5.Name = "button5";
            button5.Size = new Size(65, 27);
            button5.TabIndex = 17;
            button5.Text = "Generate ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Location = new Point(98, 94);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 20;
            label4.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Location = new Point(25, 94);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 19;
            label3.Text = "Time";
            // 
            // button2
            // 
            button2.Location = new Point(259, 137);
            button2.Name = "button2";
            button2.Size = new Size(136, 27);
            button2.TabIndex = 21;
            button2.Text = "Validation by time";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(418, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(237, 394);
            listBox1.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button5;
        private Label label4;
        private Label label3;
        private Button button2;
        private ListBox listBox1;
    }
}