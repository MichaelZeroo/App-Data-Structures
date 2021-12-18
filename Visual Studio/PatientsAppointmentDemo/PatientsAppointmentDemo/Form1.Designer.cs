namespace PatientsAppointmentDemo
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.WaitingList = new System.Windows.Forms.ListBox();
            this.transferButton = new System.Windows.Forms.Button();
            this.SeenDoctor = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SeenDoctor);
            this.groupBox1.Controls.Add(this.transferButton);
            this.groupBox1.Controls.Add(this.WaitingList);
            this.groupBox1.Controls.Add(this.addPatientButton);
            this.groupBox1.Controls.Add(this.genderComboBox);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Patient to Waiting List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(136, 42);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(159, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(136, 63);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(159, 22);
            this.addressTextBox.TabIndex = 4;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(136, 84);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(159, 24);
            this.genderComboBox.TabIndex = 5;
            // 
            // addPatientButton
            // 
            this.addPatientButton.Location = new System.Drawing.Point(136, 114);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(75, 23);
            this.addPatientButton.TabIndex = 6;
            this.addPatientButton.Text = "Add";
            this.addPatientButton.UseVisualStyleBackColor = true;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // WaitingList
            // 
            this.WaitingList.FormattingEnabled = true;
            this.WaitingList.ItemHeight = 16;
            this.WaitingList.Location = new System.Drawing.Point(45, 160);
            this.WaitingList.Name = "WaitingList";
            this.WaitingList.Size = new System.Drawing.Size(250, 212);
            this.WaitingList.TabIndex = 7;
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(316, 258);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(75, 23);
            this.transferButton.TabIndex = 8;
            this.transferButton.Text = "<>";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // SeenDoctor
            // 
            this.SeenDoctor.FormattingEnabled = true;
            this.SeenDoctor.ItemHeight = 16;
            this.SeenDoctor.Location = new System.Drawing.Point(416, 160);
            this.SeenDoctor.Name = "SeenDoctor";
            this.SeenDoctor.Size = new System.Drawing.Size(242, 212);
            this.SeenDoctor.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox SeenDoctor;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.ListBox WaitingList;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

