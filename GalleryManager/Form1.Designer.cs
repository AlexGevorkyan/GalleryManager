namespace GalleryManager
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            maxFileSize1 = new TextBox();
            label2 = new Label();
            maxFileSize = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2, 1, 2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(816, 365);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 1, 2, 1);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 1, 2, 1);
            tabPage1.Size = new Size(808, 337);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Gallery";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 1, 2, 1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 1, 2, 1);
            tabPage2.Size = new Size(808, 337);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add Image";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(maxFileSize1);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(maxFileSize);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2, 1, 2, 1);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(808, 337);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // maxFileSize1
            // 
            maxFileSize1.Location = new Point(27, 106);
            maxFileSize1.Name = "maxFileSize1";
            maxFileSize1.Size = new Size(472, 23);
            maxFileSize1.TabIndex = 3;
            maxFileSize1.Text = "Ми можемо працювати лише з файлами з такими розширеннями: .png , .jpg , .gift";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 88);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Text2";
            // 
            // maxFileSize
            // 
            maxFileSize.Location = new Point(24, 40);
            maxFileSize.Name = "maxFileSize";
            maxFileSize.Size = new Size(179, 23);
            maxFileSize.TabIndex = 1;
            maxFileSize.Text = "5000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Текст";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 365);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox maxFileSize;
        private Label label1;
        private TextBox maxFileSize1;
        private Label label2;
    }
}
