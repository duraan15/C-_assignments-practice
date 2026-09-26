namespace assignment_using_parse_method
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
            txtname = new TextBox();
            txtsemester = new TextBox();
            txtdepartment = new TextBox();
            txtid = new TextBox();
            lblouput = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lblname = new Label();
            lblsemeter = new Label();
            lbldepartment = new Label();
            lblid = new Label();
            SuspendLayout();
            // 
            // txtname
            // 
            txtname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            txtname.Location = new Point(558, 42);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(406, 52);
            txtname.TabIndex = 0;
            // 
            // txtsemester
            // 
            txtsemester.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            txtsemester.Location = new Point(558, 262);
            txtsemester.Multiline = true;
            txtsemester.Name = "txtsemester";
            txtsemester.Size = new Size(406, 58);
            txtsemester.TabIndex = 1;
            // 
            // txtdepartment
            // 
            txtdepartment.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            txtdepartment.Location = new Point(558, 181);
            txtdepartment.Multiline = true;
            txtdepartment.Name = "txtdepartment";
            txtdepartment.Size = new Size(406, 57);
            txtdepartment.TabIndex = 2;
            // 
            // txtid
            // 
            txtid.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            txtid.Location = new Point(558, 111);
            txtid.Multiline = true;
            txtid.Name = "txtid";
            txtid.Size = new Size(406, 51);
            txtid.TabIndex = 3;
            // 
            // lblouput
            // 
            lblouput.BorderStyle = BorderStyle.FixedSingle;
            lblouput.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblouput.Location = new Point(330, 343);
            lblouput.Name = "lblouput";
            lblouput.Size = new Size(538, 62);
            lblouput.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(136, 517);
            button1.Name = "button1";
            button1.Size = new Size(234, 47);
            button1.TabIndex = 5;
            button1.Text = "show information";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(507, 517);
            button2.Name = "button2";
            button2.Size = new Size(136, 47);
            button2.TabIndex = 6;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(815, 517);
            button3.Name = "button3";
            button3.Size = new Size(112, 47);
            button3.TabIndex = 7;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblname.Location = new Point(225, 62);
            lblname.Name = "lblname";
            lblname.Size = new Size(281, 32);
            lblname.TabIndex = 8;
            lblname.Text = "Enter the student name";
            // 
            // lblsemeter
            // 
            lblsemeter.AutoSize = true;
            lblsemeter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblsemeter.Location = new Point(225, 271);
            lblsemeter.Name = "lblsemeter";
            lblsemeter.Size = new Size(226, 32);
            lblsemeter.TabIndex = 9;
            lblsemeter.Text = "Enter the semester";
            // 
            // lbldepartment
            // 
            lbldepartment.AutoSize = true;
            lbldepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbldepartment.Location = new Point(225, 206);
            lbldepartment.Name = "lbldepartment";
            lbldepartment.Size = new Size(259, 32);
            lbldepartment.TabIndex = 10;
            lbldepartment.Text = "Enter the department";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblid.Location = new Point(225, 130);
            lblid.Name = "lblid";
            lblid.Size = new Size(244, 32);
            lblid.TabIndex = 11;
            lblid.Text = "Enter the student ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 639);
            Controls.Add(lblid);
            Controls.Add(lbldepartment);
            Controls.Add(lblsemeter);
            Controls.Add(lblname);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblouput);
            Controls.Add(txtid);
            Controls.Add(txtdepartment);
            Controls.Add(txtsemester);
            Controls.Add(txtname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtname;
        private TextBox txtsemester;
        private TextBox txtdepartment;
        private TextBox txtid;
        private Label lblouput;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblname;
        private Label lblsemeter;
        private Label lbldepartment;
        private Label lblid;
    }
}
