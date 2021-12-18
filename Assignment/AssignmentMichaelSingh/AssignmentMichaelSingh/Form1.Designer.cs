namespace AssignmentMichaelSingh
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
            this.RDFListbox = new System.Windows.Forms.ListBox();
            this.ComputerScienceListbox = new System.Windows.Forms.ListBox();
            this.NetworkingListbox = new System.Windows.Forms.ListBox();
            this.MathematicsListbox = new System.Windows.Forms.ListBox();
            this.SoftwareDevelopmentListbox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "ReadDataFile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RDFListbox
            // 
            this.RDFListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDFListbox.FormattingEnabled = true;
            this.RDFListbox.ItemHeight = 25;
            this.RDFListbox.Location = new System.Drawing.Point(13, 61);
            this.RDFListbox.Name = "RDFListbox";
            this.RDFListbox.Size = new System.Drawing.Size(534, 404);
            this.RDFListbox.TabIndex = 1;
            this.RDFListbox.SelectedIndexChanged += new System.EventHandler(this.RDFListbox_SelectedIndexChanged);
            // 
            // ComputerScienceListbox
            // 
            this.ComputerScienceListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerScienceListbox.FormattingEnabled = true;
            this.ComputerScienceListbox.ItemHeight = 20;
            this.ComputerScienceListbox.Location = new System.Drawing.Point(553, 61);
            this.ComputerScienceListbox.Name = "ComputerScienceListbox";
            this.ComputerScienceListbox.Size = new System.Drawing.Size(282, 144);
            this.ComputerScienceListbox.TabIndex = 2;
            this.ComputerScienceListbox.SelectedIndexChanged += new System.EventHandler(this.ComputerScienceListbox_SelectedIndexChanged);
            // 
            // NetworkingListbox
            // 
            this.NetworkingListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkingListbox.FormattingEnabled = true;
            this.NetworkingListbox.ItemHeight = 20;
            this.NetworkingListbox.Location = new System.Drawing.Point(841, 61);
            this.NetworkingListbox.Name = "NetworkingListbox";
            this.NetworkingListbox.Size = new System.Drawing.Size(282, 144);
            this.NetworkingListbox.TabIndex = 3;
            this.NetworkingListbox.SelectedIndexChanged += new System.EventHandler(this.NetworkingListbox_SelectedIndexChanged);
            // 
            // MathematicsListbox
            // 
            this.MathematicsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathematicsListbox.FormattingEnabled = true;
            this.MathematicsListbox.ItemHeight = 20;
            this.MathematicsListbox.Location = new System.Drawing.Point(553, 221);
            this.MathematicsListbox.Name = "MathematicsListbox";
            this.MathematicsListbox.Size = new System.Drawing.Size(282, 144);
            this.MathematicsListbox.TabIndex = 4;
            this.MathematicsListbox.SelectedIndexChanged += new System.EventHandler(this.MathematicsListbox_SelectedIndexChanged);
            // 
            // SoftwareDevelopmentListbox
            // 
            this.SoftwareDevelopmentListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareDevelopmentListbox.FormattingEnabled = true;
            this.SoftwareDevelopmentListbox.ItemHeight = 20;
            this.SoftwareDevelopmentListbox.Location = new System.Drawing.Point(841, 221);
            this.SoftwareDevelopmentListbox.Name = "SoftwareDevelopmentListbox";
            this.SoftwareDevelopmentListbox.Size = new System.Drawing.Size(282, 144);
            this.SoftwareDevelopmentListbox.TabIndex = 5;
            this.SoftwareDevelopmentListbox.SelectedIndexChanged += new System.EventHandler(this.SoftwareDevelopmentListbox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(772, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "ShowCategories";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(772, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "SaveToDatabase";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 528);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SoftwareDevelopmentListbox);
            this.Controls.Add(this.MathematicsListbox);
            this.Controls.Add(this.NetworkingListbox);
            this.Controls.Add(this.ComputerScienceListbox);
            this.Controls.Add(this.RDFListbox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox RDFListbox;
        private System.Windows.Forms.ListBox ComputerScienceListbox;
        private System.Windows.Forms.ListBox NetworkingListbox;
        private System.Windows.Forms.ListBox MathematicsListbox;
        private System.Windows.Forms.ListBox SoftwareDevelopmentListbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

