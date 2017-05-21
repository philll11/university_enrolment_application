namespace Assignment_5_212
{
	partial class MainWin
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
			this.paperListBx = new System.Windows.Forms.ListBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.studentListBx = new System.Windows.Forms.ListBox();
			this.paperDplyBtn = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.sdtAddBtn = new System.Windows.Forms.Button();
			this.PapAddBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.EnrolBtn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// paperListBx
			// 
			this.paperListBx.FormattingEnabled = true;
			this.paperListBx.Location = new System.Drawing.Point(398, 113);
			this.paperListBx.Name = "paperListBx";
			this.paperListBx.Size = new System.Drawing.Size(305, 329);
			this.paperListBx.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(722, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
			// 
			// studentListBx
			// 
			this.studentListBx.FormattingEnabled = true;
			this.studentListBx.Location = new System.Drawing.Point(19, 113);
			this.studentListBx.Name = "studentListBx";
			this.studentListBx.Size = new System.Drawing.Size(305, 329);
			this.studentListBx.TabIndex = 4;
			// 
			// paperDplyBtn
			// 
			this.paperDplyBtn.Location = new System.Drawing.Point(19, 448);
			this.paperDplyBtn.Name = "paperDplyBtn";
			this.paperDplyBtn.Size = new System.Drawing.Size(75, 23);
			this.paperDplyBtn.TabIndex = 5;
			this.paperDplyBtn.Text = "Papers";
			this.paperDplyBtn.UseVisualStyleBackColor = true;
			this.paperDplyBtn.Click += new System.EventHandler(this.PaperDplyBtnClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(398, 448);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Enrollments";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.StudentDplyBtnClick);
			// 
			// sdtAddBtn
			// 
			this.sdtAddBtn.Location = new System.Drawing.Point(249, 448);
			this.sdtAddBtn.Name = "sdtAddBtn";
			this.sdtAddBtn.Size = new System.Drawing.Size(75, 23);
			this.sdtAddBtn.TabIndex = 7;
			this.sdtAddBtn.Text = "Add";
			this.sdtAddBtn.UseVisualStyleBackColor = true;
			this.sdtAddBtn.Click += new System.EventHandler(this.SdtAddBtnClick);
			// 
			// PapAddBtn
			// 
			this.PapAddBtn.Location = new System.Drawing.Point(628, 448);
			this.PapAddBtn.Name = "PapAddBtn";
			this.PapAddBtn.Size = new System.Drawing.Size(75, 23);
			this.PapAddBtn.TabIndex = 8;
			this.PapAddBtn.Text = "Add";
			this.PapAddBtn.UseVisualStyleBackColor = true;
			this.PapAddBtn.Click += new System.EventHandler(this.PapAddBtnClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "Students";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(395, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "Papers";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(261, 24);
			this.label3.TabIndex = 11;
			this.label3.Text = "University Managment System";
			// 
			// EnrolBtn
			// 
			this.EnrolBtn.Location = new System.Drawing.Point(168, 448);
			this.EnrolBtn.Name = "EnrolBtn";
			this.EnrolBtn.Size = new System.Drawing.Size(75, 23);
			this.EnrolBtn.TabIndex = 12;
			this.EnrolBtn.Text = "Enrol";
			this.EnrolBtn.UseVisualStyleBackColor = true;
			this.EnrolBtn.Click += new System.EventHandler(this.EnrolBtnClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(455, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "To enrol a student:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(455, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(192, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "1. Select the student you want to enrol.";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(455, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(212, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "2. Select a paper you want to enrol them in.";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(455, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(255, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "3. Press the \'Enrol\' button under the student window.";
			// 
			// MainWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 533);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.EnrolBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PapAddBtn);
			this.Controls.Add(this.sdtAddBtn);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.paperDplyBtn);
			this.Controls.Add(this.studentListBx);
			this.Controls.Add(this.paperListBx);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "University";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox paperListBx;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ListBox studentListBx;
		private System.Windows.Forms.Button paperDplyBtn;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button sdtAddBtn;
		private System.Windows.Forms.Button PapAddBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button EnrolBtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}

