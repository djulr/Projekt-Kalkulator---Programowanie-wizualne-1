namespace Projekt_Kalkulator___wizualne_1
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
            button2 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button21 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(276, 619);
            button2.Name = "button2";
            button2.Size = new Size(123, 105);
            button2.TabIndex = 1;
            button2.Text = "AC";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button13
            // 
            button13.Location = new Point(111, 469);
            button13.Name = "button13";
            button13.Size = new Size(123, 105);
            button13.TabIndex = 12;
            button13.Text = "/";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(276, 469);
            button14.Name = "button14";
            button14.Size = new Size(123, 105);
            button14.TabIndex = 13;
            button14.Text = "*";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(440, 469);
            button15.Name = "button15";
            button15.Size = new Size(123, 105);
            button15.TabIndex = 14;
            button15.Text = "-";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Location = new Point(609, 469);
            button16.Name = "button16";
            button16.Size = new Size(123, 105);
            button16.TabIndex = 19;
            button16.Text = "+";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button21
            // 
            button21.AutoEllipsis = true;
            button21.Location = new Point(440, 619);
            button21.Name = "button21";
            button21.Size = new Size(123, 105);
            button21.TabIndex = 24;
            button21.Text = "=";
            button21.UseVisualStyleBackColor = true;
            button21.Click += button21_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(111, 267);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(123, 114);
            richTextBox1.TabIndex = 25;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(361, 267);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(123, 114);
            richTextBox2.TabIndex = 26;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(609, 267);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(123, 114);
            richTextBox3.TabIndex = 27;
            richTextBox3.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 206);
            label1.Name = "label1";
            label1.Size = new Size(171, 32);
            label1.TabIndex = 28;
            label1.Text = "Pierwsza liczba";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 206);
            label2.Name = "label2";
            label2.Size = new Size(146, 32);
            label2.TabIndex = 29;
            label2.Text = "Druga liczba";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(628, 206);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 30;
            label3.Text = "Wynik";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(844, 96);
            label4.TabIndex = 31;
            label4.Text = "Na początku podaj liczby a następnie wybierz działanie które chcesz wykonać.\r\nWciśnij symbol znaku równości aby otrzymać wynik.\r\n\r\n";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 1190);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button21);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Kalkulator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button21;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
