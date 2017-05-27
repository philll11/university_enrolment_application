namespace Assignment_5_212
{
	partial class PaperInfoWin
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
			this.studentListBx = new System.Windows.Forms.ListBox();
			this.sdtInforCnlBtn = new System.Windows.Forms.Button();
			this.coordLbl = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.idLbl = new System.Windows.Forms.Label();
			this.nameLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// studentListBx
			// 
			this.studentListBx.Enabled = false;
			this.studentListBx.FormattingEnabled = true;
			this.studentListBx.Location = new System.Drawing.Point(27, 148);
			this.studentListBx.Name = "studentListBx";
			this.studentListBx.Size = new System.Drawing.Size(258, 95);
			this.studentListBx.TabIndex = 40;
			// 
			// sdtInforCnlBtn
			// 
			this.sdtInforCnlBtn.Location = new System.Drawing.Point(120, 259);
			this.sdtInforCnlBtn.Name = "sdtInforCnlBtn";
			this.sdtInforCnlBtn.Size = new System.Drawing.Size(75, 23);
			this.sdtInforCnlBtn.TabIndex = 39;
			this.sdtInforCnlBtn.Text = "Cancel";
			this.sdtInforCnlBtn.UseVisualStyleBackColor = true;
			this.sdtInforCnlBtn.Click += new System.EventHandler(this.SdtInforCnlBtnClick);
			// 
			// coordLbl
			// 
			this.coordLbl.AutoSize = true;
			this.coordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coordLbl.Location = new System.Drawing.Point(182, 84);
			this.coordLbl.Name = "coordLbl";
			this.coordLbl.Size = new System.Drawing.Size(79, 20);
			this.coordLbl.TabIndex = 37;
			this.coordLbl.Text = "Joe Blogs";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(34, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 20);
			this.label4.TabIndex = 36;
			this.label4.Text = "Students:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(34, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 20);
			this.label3.TabIndex = 34;
			this.label3.Text = "Course Coordinatr:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 33;
			this.label2.Text = "Code:";
			// 
			// idLbl
			// 
			this.idLbl.AutoSize = true;
			this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idLbl.Location = new System.Drawing.Point(91, 51);
			this.idLbl.Name = "idLbl";
			this.idLbl.Size = new System.Drawing.Size(45, 20);
			this.idLbl.TabIndex = 32;
			this.idLbl.Text = "1234";
			// 
			// nameLbl
			// 
			this.nameLbl.AutoSize = true;
			this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameLbl.Location = new System.Drawing.Point(33, 20);
			this.nameLbl.Name = "nameLbl";
			this.nameLbl.Size = new System.Drawing.Size(217, 25);
			this.nameLbl.TabIndex = 31;
			this.nameLbl.Text = "Software Engineering";
			// 
			// PaperInfoWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(313, 299);
			this.Controls.Add(this.studentListBx);
			this.Controls.Add(this.sdtInforCnlBtn);
			this.Controls.Add(this.coordLbl);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.idLbl);
			this.Controls.Add(this.nameLbl);
			this.Name = "PaperInfoWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PaperInfoWin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox studentListBx;
		private System.Windows.Forms.Button sdtInforCnlBtn;
		private System.Windows.Forms.Label coordLbl;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label idLbl;
		private System.Windows.Forms.Label nameLbl;
	}
}