namespace Assignment_5_212
{
	partial class PaperAddWin
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
			this.papCnlBtn = new System.Windows.Forms.Button();
			this.papCfmBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.papCoordTxBx = new System.Windows.Forms.TextBox();
			this.papCodeTxBx = new System.Windows.Forms.TextBox();
			this.papNmeTxBx = new System.Windows.Forms.TextBox();
			this.coordEro = new System.Windows.Forms.Label();
			this.nameEro = new System.Windows.Forms.Label();
			this.codeEro = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// papCnlBtn
			// 
			this.papCnlBtn.Location = new System.Drawing.Point(145, 241);
			this.papCnlBtn.Name = "papCnlBtn";
			this.papCnlBtn.Size = new System.Drawing.Size(75, 23);
			this.papCnlBtn.TabIndex = 21;
			this.papCnlBtn.Text = "Cancel";
			this.papCnlBtn.UseVisualStyleBackColor = true;
			this.papCnlBtn.Click += new System.EventHandler(this.PapCnlBtnClick);
			// 
			// papCfmBtn
			// 
			this.papCfmBtn.Location = new System.Drawing.Point(64, 241);
			this.papCfmBtn.Name = "papCfmBtn";
			this.papCfmBtn.Size = new System.Drawing.Size(75, 23);
			this.papCfmBtn.TabIndex = 20;
			this.papCfmBtn.Text = "Confirm";
			this.papCfmBtn.UseVisualStyleBackColor = true;
			this.papCfmBtn.Click += new System.EventHandler(this.PapCfmBtnClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(92, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 20);
			this.label5.TabIndex = 19;
			this.label5.Text = "Add a paper.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(89, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 15);
			this.label3.TabIndex = 17;
			this.label3.Text = "Code:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(89, 181);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 15);
			this.label2.TabIndex = 16;
			this.label2.Text = "Coordinator:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(89, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 15);
			this.label1.TabIndex = 15;
			this.label1.Text = "Name:";
			// 
			// papCoordTxBx
			// 
			this.papCoordTxBx.ForeColor = System.Drawing.Color.LightGray;
			this.papCoordTxBx.Location = new System.Drawing.Point(92, 199);
			this.papCoordTxBx.Name = "papCoordTxBx";
			this.papCoordTxBx.Size = new System.Drawing.Size(100, 20);
			this.papCoordTxBx.TabIndex = 13;
			this.papCoordTxBx.Text = "Jone Jones";
			// 
			// papCodeTxBx
			// 
			this.papCodeTxBx.ForeColor = System.Drawing.Color.LightGray;
			this.papCodeTxBx.Location = new System.Drawing.Point(92, 133);
			this.papCodeTxBx.Name = "papCodeTxBx";
			this.papCodeTxBx.Size = new System.Drawing.Size(100, 20);
			this.papCodeTxBx.TabIndex = 12;
			this.papCodeTxBx.Text = "1234";
			// 
			// papNmeTxBx
			// 
			this.papNmeTxBx.ForeColor = System.Drawing.Color.LightGray;
			this.papNmeTxBx.Location = new System.Drawing.Point(92, 67);
			this.papNmeTxBx.Name = "papNmeTxBx";
			this.papNmeTxBx.Size = new System.Drawing.Size(100, 20);
			this.papNmeTxBx.TabIndex = 11;
			this.papNmeTxBx.Text = "Joe Dow";
			// 
			// coordEro
			// 
			this.coordEro.AutoSize = true;
			this.coordEro.ForeColor = System.Drawing.Color.Red;
			this.coordEro.Location = new System.Drawing.Point(92, 222);
			this.coordEro.Name = "coordEro";
			this.coordEro.Size = new System.Drawing.Size(45, 13);
			this.coordEro.TabIndex = 24;
			this.coordEro.Text = "* Invalid";
			this.coordEro.Visible = false;
			// 
			// nameEro
			// 
			this.nameEro.AutoSize = true;
			this.nameEro.ForeColor = System.Drawing.Color.Red;
			this.nameEro.Location = new System.Drawing.Point(93, 90);
			this.nameEro.Name = "nameEro";
			this.nameEro.Size = new System.Drawing.Size(45, 13);
			this.nameEro.TabIndex = 23;
			this.nameEro.Text = "* Invalid";
			this.nameEro.Visible = false;
			// 
			// codeEro
			// 
			this.codeEro.AutoSize = true;
			this.codeEro.ForeColor = System.Drawing.Color.Red;
			this.codeEro.Location = new System.Drawing.Point(93, 156);
			this.codeEro.Name = "codeEro";
			this.codeEro.Size = new System.Drawing.Size(45, 13);
			this.codeEro.TabIndex = 22;
			this.codeEro.Text = "* Invalid";
			this.codeEro.Visible = false;
			// 
			// PaperAddWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 299);
			this.Controls.Add(this.coordEro);
			this.Controls.Add(this.nameEro);
			this.Controls.Add(this.codeEro);
			this.Controls.Add(this.papCnlBtn);
			this.Controls.Add(this.papCfmBtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.papCoordTxBx);
			this.Controls.Add(this.papCodeTxBx);
			this.Controls.Add(this.papNmeTxBx);
			this.Name = "PaperAddWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button papCnlBtn;
		private System.Windows.Forms.Button papCfmBtn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox papCoordTxBx;
		private System.Windows.Forms.TextBox papCodeTxBx;
		private System.Windows.Forms.TextBox papNmeTxBx;
		private System.Windows.Forms.Label coordEro;
		private System.Windows.Forms.Label nameEro;
		private System.Windows.Forms.Label codeEro;
	}
}