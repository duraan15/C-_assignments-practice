namespace electircity_bill_costomer
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
            txtcustomername = new TextBox();
            txtpreviousreading = new TextBox();
            txtpriceunit = new TextBox();
            txtcurrentreading = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            lbloutputelectriciyusage = new Label();
            lbloutputtaxamount = new Label();
            lbloutputamountbill = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // txtcustomername
            // 
            txtcustomername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtcustomername.Location = new Point(846, 24);
            txtcustomername.Name = "txtcustomername";
            txtcustomername.Size = new Size(400, 39);
            txtcustomername.TabIndex = 0;
            // 
            // txtpreviousreading
            // 
            txtpreviousreading.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtpreviousreading.Location = new Point(846, 92);
            txtpreviousreading.Name = "txtpreviousreading";
            txtpreviousreading.Size = new Size(400, 39);
            txtpreviousreading.TabIndex = 1;
            txtpreviousreading.TextChanged += textBox2_TextChanged;
            // 
            // txtpriceunit
            // 
            txtpriceunit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtpriceunit.Location = new Point(846, 247);
            txtpriceunit.Name = "txtpriceunit";
            txtpriceunit.Size = new Size(400, 39);
            txtpriceunit.TabIndex = 2;
            // 
            // txtcurrentreading
            // 
            txtcurrentreading.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtcurrentreading.Location = new Point(846, 159);
            txtcurrentreading.Name = "txtcurrentreading";
            txtcurrentreading.Size = new Size(400, 39);
            txtcurrentreading.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(455, 30);
            label1.Name = "label1";
            label1.Size = new Size(258, 32);
            label1.TabIndex = 4;
            label1.Text = "Enter customer name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(455, 95);
            label2.Name = "label2";
            label2.Size = new Size(296, 32);
            label2.TabIndex = 5;
            label2.Text = " Enter Previous reading :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(455, 169);
            label3.Name = "label3";
            label3.Size = new Size(270, 32);
            label3.TabIndex = 6;
            label3.Text = " Enter Current reading";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(455, 253);
            label4.Name = "label4";
            label4.Size = new Size(275, 32);
            label4.TabIndex = 7;
            label4.Text = "Enter price per unit($):";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(505, 343);
            button1.Name = "button1";
            button1.Size = new Size(190, 53);
            button1.TabIndex = 8;
            button1.Text = "Calculate bill";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbloutputelectriciyusage
            // 
            lbloutputelectriciyusage.BorderStyle = BorderStyle.FixedSingle;
            lbloutputelectriciyusage.Location = new Point(716, 422);
            lbloutputelectriciyusage.Name = "lbloutputelectriciyusage";
            lbloutputelectriciyusage.Size = new Size(549, 45);
            lbloutputelectriciyusage.TabIndex = 9;
            // 
            // lbloutputtaxamount
            // 
            lbloutputtaxamount.BorderStyle = BorderStyle.FixedSingle;
            lbloutputtaxamount.Location = new Point(716, 483);
            lbloutputtaxamount.Name = "lbloutputtaxamount";
            lbloutputtaxamount.Size = new Size(549, 47);
            lbloutputtaxamount.TabIndex = 10;
            // 
            // lbloutputamountbill
            // 
            lbloutputamountbill.BorderStyle = BorderStyle.FixedSingle;
            lbloutputamountbill.Location = new Point(716, 552);
            lbloutputamountbill.Name = "lbloutputamountbill";
            lbloutputamountbill.Size = new Size(549, 55);
            lbloutputamountbill.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(190, 435);
            label8.Name = "label8";
            label8.Size = new Size(264, 32);
            label8.TabIndex = 12;
            label8.Text = "Electricity usage(unit)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(201, 498);
            label9.Name = "label9";
            label9.Size = new Size(201, 32);
            label9.TabIndex = 13;
            label9.Text = "Tax amount(7%)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(190, 568);
            label10.Name = "label10";
            label10.Size = new Size(459, 32);
            label10.TabIndex = 14;
            label10.Text = "Amount bill(in cluding $5fixed charge)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 706);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lbloutputamountbill);
            Controls.Add(lbloutputtaxamount);
            Controls.Add(lbloutputelectriciyusage);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtcurrentreading);
            Controls.Add(txtpriceunit);
            Controls.Add(txtpreviousreading);
            Controls.Add(txtcustomername);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcustomername;
        private TextBox txtpreviousreading;
        private TextBox txtpriceunit;
        private TextBox txtcurrentreading;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label lbloutputelectriciyusage;
        private Label lbloutputtaxamount;
        private Label lbloutputamountbill;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
