
namespace ElectronicJournal
{
    partial class JournalManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalManagement));
            this.QuitButton = new System.Windows.Forms.Button();
            this.PerformanceManagementButton = new System.Windows.Forms.Button();
            this.CollegeManagementButon = new System.Windows.Forms.Button();
            this.StudentsManagementButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // QuitButton
            // 
            this.QuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.QuitButton.Location = new System.Drawing.Point(351, 164);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 0;
            this.QuitButton.Text = "Выход";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // PerformanceManagementButton
            // 
            this.PerformanceManagementButton.Location = new System.Drawing.Point(49, 22);
            this.PerformanceManagementButton.Name = "PerformanceManagementButton";
            this.PerformanceManagementButton.Size = new System.Drawing.Size(174, 35);
            this.PerformanceManagementButton.TabIndex = 1;
            this.PerformanceManagementButton.Text = "Управление успеваемостью";
            this.PerformanceManagementButton.UseVisualStyleBackColor = true;
            this.PerformanceManagementButton.Click += new System.EventHandler(this.PerformanceManagementButton_Click);
            // 
            // CollegeManagementButon
            // 
            this.CollegeManagementButon.Location = new System.Drawing.Point(49, 71);
            this.CollegeManagementButon.Name = "CollegeManagementButon";
            this.CollegeManagementButon.Size = new System.Drawing.Size(174, 35);
            this.CollegeManagementButon.TabIndex = 4;
            this.CollegeManagementButon.Text = "Управление колледжом";
            this.CollegeManagementButon.UseVisualStyleBackColor = true;
            this.CollegeManagementButon.Click += new System.EventHandler(this.CollegeManagementButon_Click);
            // 
            // StudentsManagementButton
            // 
            this.StudentsManagementButton.Location = new System.Drawing.Point(49, 124);
            this.StudentsManagementButton.Name = "StudentsManagementButton";
            this.StudentsManagementButton.Size = new System.Drawing.Size(174, 35);
            this.StudentsManagementButton.TabIndex = 5;
            this.StudentsManagementButton.Text = "Управление студентами";
            this.StudentsManagementButton.UseVisualStyleBackColor = true;
            this.StudentsManagementButton.Click += new System.EventHandler(this.StudentsManagementButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 34);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 34);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 34);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // JournalManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 199);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StudentsManagementButton);
            this.Controls.Add(this.CollegeManagementButon);
            this.Controls.Add(this.PerformanceManagementButton);
            this.Controls.Add(this.QuitButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "JournalManagement";
            this.Text = "Управление студентами";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button PerformanceManagementButton;
        private System.Windows.Forms.Button CollegeManagementButon;
        private System.Windows.Forms.Button StudentsManagementButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}