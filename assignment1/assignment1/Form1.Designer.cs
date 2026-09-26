namespace assignment1
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
            txtdayoftheweek = new TextBox();
            txtnameofthemounth = new TextBox();
            txtnumericofthemounth = new TextBox();
            txtoftheyar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            displayoutput = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // txtdayoftheweek
            // 
            txtdayoftheweek.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            txtdayoftheweek.Location = new Point(492, 38);
            txtdayoftheweek.Name = "txtdayoftheweek";
            txtdayoftheweek.Size = new Size(435, 50);
            txtdayoftheweek.TabIndex = 0;
            // 
            // txtnameofthemounth
            // 
            txtnameofthemounth.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            txtnameofthemounth.Location = new Point(492, 116);
            txtnameofthemounth.Name = "txtnameofthemounth";
            txtnameofthemounth.Size = new Size(435, 50);
            txtnameofthemounth.TabIndex = 1;
            // 
            // txtnumericofthemounth
            // 
            txtnumericofthemounth.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            txtnumericofthemounth.Location = new Point(492, 199);
            txtnumericofthemounth.Name = "txtnumericofthemounth";
            txtnumericofthemounth.Size = new Size(435, 50);
            txtnumericofthemounth.TabIndex = 2;
            // 
            // txtoftheyar
            // 
            txtoftheyar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            txtoftheyar.Location = new Point(492, 286);
            txtoftheyar.Name = "txtoftheyar";
            txtoftheyar.Size = new Size(435, 50);
            txtoftheyar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(100, 40);
            label1.Name = "label1";
            label1.Size = new Size(304, 38);
            label1.TabIndex = 4;
            label1.Text = "Enter day of the week";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(37, 116);
            label2.Name = "label2";
            label2.Size = new Size(367, 38);
            label2.TabIndex = 5;
            label2.Text = "Enter name of the mounth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(3, 201);
            label3.Name = "label3";
            label3.Size = new Size(401, 38);
            label3.TabIndex = 6;
            label3.Text = "Enter numeric of the mounth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(167, 288);
            label4.Name = "label4";
            label4.Size = new Size(237, 38);
            label4.TabIndex = 7;
            label4.Text = "Enter of the year";
            // 
            // displayoutput
            // 
            displayoutput.BorderStyle = BorderStyle.FixedSingle;
            displayoutput.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displayoutput.Location = new Point(91, 363);
            displayoutput.Name = "displayoutput";
            displayoutput.Size = new Size(836, 55);
            displayoutput.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.Location = new Point(132, 518);
            button2.Name = "button2";
            button2.Size = new Size(111, 52);
            button2.TabIndex = 10;
            button2.Text = "show ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.Location = new Point(316, 518);
            button3.Name = "button3";
            button3.Size = new Size(112, 52);
            button3.TabIndex = 11;
            button3.Text = "clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button4.Location = new Point(498, 518);
            button4.Name = "button4";
            button4.Size = new Size(112, 52);
            button4.TabIndex = 12;
            button4.Text = "close";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 708);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(displayoutput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtoftheyar);
            Controls.Add(txtnumericofthemounth);
            Controls.Add(txtnameofthemounth);
            Controls.Add(txtdayoftheweek);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtdayoftheweek;
        private TextBox txtnameofthemounth;
        private TextBox txtnumericofthemounth;
        private TextBox txtoftheyar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label displayoutput;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
