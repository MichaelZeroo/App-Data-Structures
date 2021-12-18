namespace StudentCourseDataStructureDemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.ReadStudents = new System.Windows.Forms.ListBox();
            this.ADSListbox = new System.Windows.Forms.ListBox();
            this.STListbox = new System.Windows.Forms.ListBox();
            this.IDListbox = new System.Windows.Forms.ListBox();
            this.DADListbox = new System.Windows.Forms.ListBox();
            this.PPListbox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Read FIle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReadStudents
            // 
            this.ReadStudents.FormattingEnabled = true;
            this.ReadStudents.ItemHeight = 16;
            this.ReadStudents.Location = new System.Drawing.Point(47, 109);
            this.ReadStudents.Name = "ReadStudents";
            this.ReadStudents.Size = new System.Drawing.Size(212, 148);
            this.ReadStudents.TabIndex = 1;
            // 
            // ADSListbox
            // 
            this.ADSListbox.FormattingEnabled = true;
            this.ADSListbox.ItemHeight = 16;
            this.ADSListbox.Location = new System.Drawing.Point(374, 109);
            this.ADSListbox.Name = "ADSListbox";
            this.ADSListbox.Size = new System.Drawing.Size(193, 148);
            this.ADSListbox.TabIndex = 2;
            // 
            // STListbox
            // 
            this.STListbox.FormattingEnabled = true;
            this.STListbox.ItemHeight = 16;
            this.STListbox.Location = new System.Drawing.Point(693, 109);
            this.STListbox.Name = "STListbox";
            this.STListbox.Size = new System.Drawing.Size(217, 148);
            this.STListbox.TabIndex = 3;
            // 
            // IDListbox
            // 
            this.IDListbox.FormattingEnabled = true;
            this.IDListbox.ItemHeight = 16;
            this.IDListbox.Location = new System.Drawing.Point(374, 292);
            this.IDListbox.Name = "IDListbox";
            this.IDListbox.Size = new System.Drawing.Size(193, 148);
            this.IDListbox.TabIndex = 4;
            // 
            // DADListbox
            // 
            this.DADListbox.FormattingEnabled = true;
            this.DADListbox.ItemHeight = 16;
            this.DADListbox.Location = new System.Drawing.Point(693, 292);
            this.DADListbox.Name = "DADListbox";
            this.DADListbox.Size = new System.Drawing.Size(217, 148);
            this.DADListbox.TabIndex = 5;
            // 
            // PPListbox
            // 
            this.PPListbox.FormattingEnabled = true;
            this.PPListbox.ItemHeight = 16;
            this.PPListbox.Location = new System.Drawing.Point(47, 292);
            this.PPListbox.Name = "PPListbox";
            this.PPListbox.Size = new System.Drawing.Size(212, 148);
            this.PPListbox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(563, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "GroupStudent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(778, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "SaveToDatabase";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 548);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PPListbox);
            this.Controls.Add(this.DADListbox);
            this.Controls.Add(this.IDListbox);
            this.Controls.Add(this.STListbox);
            this.Controls.Add(this.ADSListbox);
            this.Controls.Add(this.ReadStudents);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ReadStudents;
        private System.Windows.Forms.ListBox ADSListbox;
        private System.Windows.Forms.ListBox STListbox;
        private System.Windows.Forms.ListBox IDListbox;
        private System.Windows.Forms.ListBox DADListbox;
        private System.Windows.Forms.ListBox PPListbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

