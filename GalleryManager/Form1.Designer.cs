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
            bt_addPicture = new Button();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            tabPage2.Controls.Add(bt_addPicture);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 1, 2, 1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 1, 2, 1);
            tabPage2.Size = new Size(808, 337);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add Image";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.DragDrop += DD;
            tabPage2.DragEnter += DE;
            // 
            // bt_addPicture
            // 
            bt_addPicture.BackColor = Color.Black;
            bt_addPicture.Dock = DockStyle.Fill;
            bt_addPicture.Font = new Font("Segoe UI Historic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_addPicture.ForeColor = Color.Honeydew;
            bt_addPicture.Location = new Point(2, 1);
            bt_addPicture.Name = "bt_addPicture";
            bt_addPicture.Size = new Size(804, 335);
            bt_addPicture.TabIndex = 0;
            bt_addPicture.Text = "Add Picture";
            bt_addPicture.UseVisualStyleBackColor = false;
            bt_addPicture.Click += bt_addPicture_Click;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2, 1, 2, 1);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(808, 337);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
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
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button bt_addPicture;
    }
}
