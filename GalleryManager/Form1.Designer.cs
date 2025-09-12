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
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            bt_addPicture = new Button();
            tabPage3 = new TabPage();
            maxFileSize1 = new TextBox();
            label2 = new Label();
            maxFileSize = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
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
            tabControl1.Margin = new Padding(4, 2, 4, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1515, 779);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Margin = new Padding(4, 2, 4, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 2, 4, 2);
            tabPage1.Size = new Size(1499, 725);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Gallery";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 0);
            dataGridView1.Margin = new Padding(6, 6, 6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1504, 401);
            dataGridView1.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(bt_addPicture);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Margin = new Padding(4, 2, 4, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 2, 4, 2);
            tabPage2.Size = new Size(1499, 725);
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
            bt_addPicture.Location = new Point(4, 2);
            bt_addPicture.Margin = new Padding(6, 6, 6, 6);
            bt_addPicture.Name = "bt_addPicture";
            bt_addPicture.Size = new Size(1491, 721);
            bt_addPicture.TabIndex = 0;
            bt_addPicture.Text = "Add Picture";
            bt_addPicture.UseVisualStyleBackColor = false;
            bt_addPicture.Click += bt_addPicture_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(maxFileSize1);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(maxFileSize);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Margin = new Padding(4, 2, 4, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1499, 725);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // maxFileSize1
            // 
            maxFileSize1.Location = new Point(50, 226);
            maxFileSize1.Margin = new Padding(6, 6, 6, 6);
            maxFileSize1.Name = "maxFileSize1";
            maxFileSize1.Size = new Size(873, 39);
            maxFileSize1.TabIndex = 3;
            maxFileSize1.Text = "Ми можемо працювати лише з файлами з такими розширеннями: .png , .jpg , .gift";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 188);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 32);
            label2.TabIndex = 2;
            label2.Text = "Text2";
            // 
            // maxFileSize
            // 
            maxFileSize.Location = new Point(45, 85);
            maxFileSize.Margin = new Padding(6, 6, 6, 6);
            maxFileSize.Name = "maxFileSize";
            maxFileSize.Size = new Size(329, 39);
            maxFileSize.TabIndex = 1;
            maxFileSize.Text = "5000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 47);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 32);
            label1.TabIndex = 0;
            label1.Text = "Текст";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1515, 779);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private Label label2;


        private DataGridView dataGridView1;

        private Button bt_addPicture;
        public TextBox maxFileSize;
        public TextBox maxFileSize1;
    }
}
