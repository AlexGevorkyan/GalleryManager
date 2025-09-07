namespace GalleryManager
{
    partial class ImageForm
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
            pictureBox1 = new PictureBox();
            btPrevious = new Button();
            btNext = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 383);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btPrevious
            // 
            btPrevious.Location = new Point(0, 115);
            btPrevious.Name = "btPrevious";
            btPrevious.Size = new Size(46, 146);
            btPrevious.TabIndex = 1;
            btPrevious.Text = "<";
            btPrevious.UseVisualStyleBackColor = true;
            btPrevious.Click += button1_Click;
            // 
            // btNext
            // 
            btNext.Location = new Point(366, 115);
            btNext.Name = "btNext";
            btNext.Size = new Size(46, 146);
            btNext.TabIndex = 2;
            btNext.Text = ">";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // ImageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 437);
            Controls.Add(btNext);
            Controls.Add(btPrevious);
            Controls.Add(pictureBox1);
            Name = "ImageForm";
            Text = "ImageForm";
            Load += ImageForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox pictureBox1;
        private Button btPrevious;
        private Button btNext;
    }
}