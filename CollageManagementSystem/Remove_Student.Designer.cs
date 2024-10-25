namespace CollageManagementSystem
{
    partial class Remove_Student
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
            this.dataGridViewDelStudent = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelStudent = new System.Windows.Forms.Button();
            this.txtRegID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDelStudent
            // 
            this.dataGridViewDelStudent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDelStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelStudent.Location = new System.Drawing.Point(12, 318);
            this.dataGridViewDelStudent.Name = "dataGridViewDelStudent";
            this.dataGridViewDelStudent.RowTemplate.Height = 24;
            this.dataGridViewDelStudent.Size = new System.Drawing.Size(741, 282);
            this.dataGridViewDelStudent.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(250, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Delete Students Record";
            // 
            // btnDelStudent
            // 
            this.btnDelStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelStudent.Location = new System.Drawing.Point(488, 218);
            this.btnDelStudent.Name = "btnDelStudent";
            this.btnDelStudent.Size = new System.Drawing.Size(99, 36);
            this.btnDelStudent.TabIndex = 9;
            this.btnDelStudent.Text = "Delete";
            this.btnDelStudent.UseVisualStyleBackColor = false;
            this.btnDelStudent.Click += new System.EventHandler(this.btnDelStudent_Click);
            // 
            // txtRegID
            // 
            this.txtRegID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegID.Location = new System.Drawing.Point(343, 167);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.Size = new System.Drawing.Size(244, 30);
            this.txtRegID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registration ID :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CollageManagementSystem.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(106, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Remove_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 612);
            this.Controls.Add(this.dataGridViewDelStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelStudent);
            this.Controls.Add(this.txtRegID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Remove_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove_Student";
            this.Load += new System.EventHandler(this.Remove_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDelStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelStudent;
        private System.Windows.Forms.TextBox txtRegID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}