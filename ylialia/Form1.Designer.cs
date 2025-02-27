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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblResult.Location = new Point(520, 416);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(146, 25);
            lblResult.TabIndex = 9;
            lblResult.Text = "В ОЖИДАНИИ";
            // 
            // txtEnd
            // 
            txtEnd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtEnd.Location = new Point(250, 412);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(129, 33);
            txtEnd.TabIndex = 8;
            // 
            // txtStart
            // 
            txtStart.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtStart.Location = new Point(115, 412);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(129, 33);
            txtStart.TabIndex = 7;
            // 
            // btnFindPath
            // 
            btnFindPath.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnFindPath.Location = new Point(385, 411);
            btnFindPath.Name = "btnFindPath";
            btnFindPath.Size = new Size(129, 34);
            btnFindPath.TabIndex = 6;
            btnFindPath.Text = "ВЫЯСНИТЬ";
            btnFindPath.UseVisualStyleBackColor = true;
            btnFindPath.Click += btnFindPath_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 405);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(btnFindPath);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblResult;
        private TextBox txtEnd;
        private TextBox txtStart;
        private Button btnFindPath;
        private PictureBox pictureBox1;
    }
}
