namespace Assignment_5_212
{
	partial class StudentInfoWin
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
			this.nameLbl = new System.Windows.Forms.Label();
			this.idLbl = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.birthLbl = new System.Windows.Forms.Label();
			this.adyLbl = new System.Windows.Forms.Label();
			this.sdtInforCnlBtn = new System.Windows.Forms.Button();
			this.papersListBx = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// nameLbl
			// 
			this.nameLbl.AutoSize = true;
			this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameLbl.Location = new System.Drawing.Point(32, 24);
			this.nameLbl.Name = "nameLbl";
			this.nameLbl.Size = new System.Drawing.Size(107, 25);
			this.nameLbl.TabIndex = 20;
			this.nameLbl.Text = "Joe Blogs";
			// 
			// idLbl
			// 
			this.idLbl.AutoSize = true;
			this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idLbl.Location = new System.Drawing.Point(62, 55);
			this.idLbl.Name = "idLbl";
			this.idLbl.Size = new System.Drawing.Size(90, 20);
			this.idLbl.TabIndex = 21;
			this.idLbl.Text = "123456789";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(33, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 20);
			this.label2.TabIndex = 22;
			this.label2.Text = "ID:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(33, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 20);
			this.label3.TabIndex = 23;
			this.label3.Text = "Birthday:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(33, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 20);
			this.label4.TabIndex = 25;
			this.label4.Text = "Papers:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(33, 121);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 20);
			this.label6.TabIndex = 24;
			this.label6.Text = "Address:";
			// 
			// birthLbl
			// 
			this.birthLbl.AutoSize = true;
			this.birthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.birthLbl.Location = new System.Drawing.Point(110, 88);
			this.birthLbl.Name = "birthLbl";
			this.birthLbl.Size = new System.Drawing.Size(89, 20);
			this.birthLbl.TabIndex = 27;
			this.birthLbl.Text = "11/12/1990";
			// 
			// adyLbl
			// 
			this.adyLbl.AutoSize = true;
			this.adyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adyLbl.Location = new System.Drawing.Point(111, 121);
			this.adyLbl.Name = "adyLbl";
			this.adyLbl.Size = new System.Drawing.Size(123, 20);
			this.adyLbl.TabIndex = 28;
			this.adyLbl.Text = "123 Upto Street";
			// 
			// sdtInforCnlBtn
			// 
			this.sdtInforCnlBtn.Location = new System.Drawing.Point(119, 291);
			this.sdtInforCnlBtn.Name = "sdtInforCnlBtn";
			this.sdtInforCnlBtn.Size = new System.Drawing.Size(75, 23);
			this.sdtInforCnlBtn.TabIndex = 29;
			this.sdtInforCnlBtn.Text = "Cancel";
			this.sdtInforCnlBtn.UseVisualStyleBackColor = true;
			this.sdtInforCnlBtn.Click += new System.EventHandler(this.SdtInforCnlBtnClick);
			// 
			// papersListBx
			// 
			this.papersListBx.Enabled = false;
			this.papersListBx.FormattingEnabled = true;
			this.papersListBx.Location = new System.Drawing.Point(26, 180);
			this.papersListBx.Name = "papersListBx";
			this.papersListBx.Size = new System.Drawing.Size(258, 95);
			this.papersListBx.TabIndex = 30;
			// 
			// StudentInfoWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(313, 331);
			this.Controls.Add(this.papersListBx);
			this.Controls.Add(this.sdtInforCnlBtn);
			this.Controls.Add(this.adyLbl);
			this.Controls.Add(this.birthLbl);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.idLbl);
			this.Controls.Add(this.nameLbl);
			this.Name = "StudentInfoWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "StudentInfoWin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLbl;
		private System.Windows.Forms.Label idLbl;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label birthLbl;
		private System.Windows.Forms.Label adyLbl;
		private System.Windows.Forms.Button sdtInforCnlBtn;
		private System.Windows.Forms.ListBox papersListBx;
	}
}