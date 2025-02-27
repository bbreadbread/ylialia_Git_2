namespace ylialia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblResult = new Label();
            txtEnd = new TextBox();
            txtStart = new TextBox();
            btnFindPath = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Century Gothic", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblResult.Location = new Point(355, 338);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 16);
            lblResult.TabIndex = 9;
            // 
            // txtEnd
            // 
            txtEnd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtEnd.Location = new Point(100, 322);
            txtEnd.Margin = new Padding(3, 4, 3, 4);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(70, 39);
            txtEnd.TabIndex = 8;
            // 
            // txtStart
            // 
            txtStart.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtStart.Location = new Point(12, 322);
            txtStart.Margin = new Padding(3, 4, 3, 4);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(70, 39);
            txtStart.TabIndex = 7;
            // 
            // btnFindPath
            // 
            btnFindPath.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnFindPath.Location = new Point(200, 324);
            btnFindPath.Margin = new Padding(3, 4, 3, 4);
            btnFindPath.Name = "btnFindPath";
            btnFindPath.Size = new Size(110, 42);
            btnFindPath.TabIndex = 6;
            btnFindPath.Text = "ВЫЯСНИТЬ";
            btnFindPath.UseVisualStyleBackColor = true;
            btnFindPath.Click += btnFindPath_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(914, 314);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 434);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(373, 154);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 395);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 11;
            label1.Text = "Это я дичь добавила";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(402, 425);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(154, 163);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(581, 385);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(312, 203);
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(lblResult);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(btnFindPath);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblResult;
        private TextBox txtEnd;
        private TextBox txtStart;
        private Button btnFindPath;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
