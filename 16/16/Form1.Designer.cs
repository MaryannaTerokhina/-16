namespace _16
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
            btnSelectFile = new Button();
            label1 = new Label();
            txtServerAddress = new TextBox();
            txtFilePath = new TextBox();
            label2 = new Label();
            btnSend = new Button();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(105, 54);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(75, 23);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Browse...";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Server Address:";
            // 
            // txtServerAddress
            // 
            txtServerAddress.Location = new Point(105, 12);
            txtServerAddress.Name = "txtServerAddress";
            txtServerAddress.Size = new Size(167, 23);
            txtServerAddress.TabIndex = 2;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(105, 93);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(740, 23);
            txtFilePath.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 101);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Select File:";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(105, 135);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send File";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 164);
            Controls.Add(txtFilePath);
            Controls.Add(label2);
            Controls.Add(btnSend);
            Controls.Add(txtServerAddress);
            Controls.Add(label1);
            Controls.Add(btnSelectFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private Label label1;
        private TextBox txtServerAddress;
        private TextBox txtFilePath;
        private Label label2;
        private Button btnSend;
    }
}
