namespace CollageManagementSystem
{
    partial class Add_Teacher
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.RichTextBox();
            this.txtduration = new System.Windows.Forms.ComboBox();
            this.txtProgram = new System.Windows.Forms.ComboBox();
            this.txtsemester = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_1DOB = new System.Windows.Forms.DateTimePicker();
            this.radioButtonFemale1 = new System.Windows.Forms.RadioButton();
            this.radioButtonMale1 = new System.Windows.Forms.RadioButton();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CollageManagementSystem.Properties.Resources.basic_Info;
            this.pictureBox1.Location = new System.Drawing.Point(419, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(560, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Basic Information";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(546, 519);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 51);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Submit";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(805, 363);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(279, 154);
            this.txtAdd.TabIndex = 48;
            this.txtAdd.Text = "";
            // 
            // txtduration
            // 
            this.txtduration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtduration.FormattingEnabled = true;
            this.txtduration.Items.AddRange(new object[] {
            "2020 - 2023",
            "2023 - 2026"});
            this.txtduration.Location = new System.Drawing.Point(835, 303);
            this.txtduration.Margin = new System.Windows.Forms.Padding(4);
            this.txtduration.Name = "txtduration";
            this.txtduration.Size = new System.Drawing.Size(215, 32);
            this.txtduration.TabIndex = 47;
            this.txtduration.Text = "-- Select --";
            // 
            // txtProgram
            // 
            this.txtProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgram.FormattingEnabled = true;
            this.txtProgram.Items.AddRange(new object[] {
            "C Programming ",
            "C++",
            "Java",
            "C# (C sharp)",
            "Python",
            "PHP"});
            this.txtProgram.Location = new System.Drawing.Point(837, 214);
            this.txtProgram.Margin = new System.Windows.Forms.Padding(4);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(215, 32);
            this.txtProgram.TabIndex = 46;
            this.txtProgram.Text = "-- Select --";
            this.txtProgram.SelectedIndexChanged += new System.EventHandler(this.txtProgramming_SelectedIndexChanged);
            // 
            // txtsemester
            // 
            this.txtsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsemester.FormattingEnabled = true;
            this.txtsemester.Items.AddRange(new object[] {
            "1st Sem",
            "2nd Sem",
            "3rd Sem",
            "4th Sem",
            "5th Sem",
            "6th Sem"});
            this.txtsemester.Location = new System.Drawing.Point(837, 150);
            this.txtsemester.Margin = new System.Windows.Forms.Padding(4);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(215, 32);
            this.txtsemester.TabIndex = 45;
            this.txtsemester.Text = "-- Select --";
            // 
            // dateTimePicker_1DOB
            // 
            this.dateTimePicker_1DOB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_1DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_1DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_1DOB.Location = new System.Drawing.Point(283, 292);
            this.dateTimePicker_1DOB.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_1DOB.Name = "dateTimePicker_1DOB";
            this.dateTimePicker_1DOB.Size = new System.Drawing.Size(225, 29);
            this.dateTimePicker_1DOB.TabIndex = 26;
            this.dateTimePicker_1DOB.ValueChanged += new System.EventHandler(this.dateTimePicker_1DOB_ValueChanged);
            // 
            // radioButtonFemale1
            // 
            this.radioButtonFemale1.AutoSize = true;
            this.radioButtonFemale1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonFemale1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale1.Location = new System.Drawing.Point(370, 231);
            this.radioButtonFemale1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFemale1.Name = "radioButtonFemale1";
            this.radioButtonFemale1.Size = new System.Drawing.Size(95, 28);
            this.radioButtonFemale1.TabIndex = 44;
            this.radioButtonFemale1.TabStop = true;
            this.radioButtonFemale1.Text = "Female";
            this.radioButtonFemale1.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale1
            // 
            this.radioButtonMale1.AutoSize = true;
            this.radioButtonMale1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMale1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale1.Location = new System.Drawing.Point(271, 229);
            this.radioButtonMale1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMale1.Name = "radioButtonMale1";
            this.radioButtonMale1.Size = new System.Drawing.Size(72, 28);
            this.radioButtonMale1.TabIndex = 43;
            this.radioButtonMale1.TabStop = true;
            this.radioButtonMale1.Text = "Male";
            this.radioButtonMale1.UseVisualStyleBackColor = true;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(283, 426);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(225, 29);
            this.txtemail.TabIndex = 41;
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(283, 355);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(225, 29);
            this.txtMobile.TabIndex = 40;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(283, 155);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(225, 29);
            this.txtFName.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(85, 292);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 29);
            this.label12.TabIndex = 37;
            this.label12.Text = "Date Of Birth";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(85, 154);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 29);
            this.label11.TabIndex = 36;
            this.label11.Text = "Full Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(663, 306);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 29);
            this.label9.TabIndex = 34;
            this.label9.Text = "Duration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(663, 374);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 29);
            this.label8.TabIndex = 33;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(663, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "Programming";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(663, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 421);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Email ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 355);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mobile No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Gender";
            // 
            // Add_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 609);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtduration);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.dateTimePicker_1DOB);
            this.Controls.Add(this.radioButtonFemale1);
            this.Controls.Add(this.radioButtonMale1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Add_Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Teacher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox txtAdd;
        private System.Windows.Forms.ComboBox txtduration;
        private System.Windows.Forms.ComboBox txtProgram;
        private System.Windows.Forms.ComboBox txtsemester;
        private System.Windows.Forms.DateTimePicker dateTimePicker_1DOB;
        private System.Windows.Forms.RadioButton radioButtonFemale1;
        private System.Windows.Forms.RadioButton radioButtonMale1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}