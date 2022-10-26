namespace 計算車資
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rdBtnMale = new System.Windows.Forms.RadioButton();
			this.rdBtnFemale = new System.Windows.Forms.RadioButton();
			this.btnCaculate = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblFee = new System.Windows.Forms.Label();
			this.lblReason = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCaculate);
			this.groupBox1.Controls.Add(this.rdBtnFemale);
			this.groupBox1.Controls.Add(this.rdBtnMale);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtAge);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(23, 22);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(299, 137);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "客戶資訊";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblReason);
			this.groupBox2.Controls.Add(this.lblFee);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(24, 193);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(298, 150);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "計算結果";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "年齡:";
			// 
			// txtAge
			// 
			this.txtAge.Location = new System.Drawing.Point(57, 33);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(100, 22);
			this.txtAge.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(163, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "性別:";
			// 
			// rdBtnMale
			// 
			this.rdBtnMale.AutoSize = true;
			this.rdBtnMale.Location = new System.Drawing.Point(201, 34);
			this.rdBtnMale.Name = "rdBtnMale";
			this.rdBtnMale.Size = new System.Drawing.Size(35, 16);
			this.rdBtnMale.TabIndex = 3;
			this.rdBtnMale.TabStop = true;
			this.rdBtnMale.Text = "男";
			this.rdBtnMale.UseVisualStyleBackColor = true;
			// 
			// rdBtnFemale
			// 
			this.rdBtnFemale.AutoSize = true;
			this.rdBtnFemale.Location = new System.Drawing.Point(242, 34);
			this.rdBtnFemale.Name = "rdBtnFemale";
			this.rdBtnFemale.Size = new System.Drawing.Size(35, 16);
			this.rdBtnFemale.TabIndex = 4;
			this.rdBtnFemale.TabStop = true;
			this.rdBtnFemale.Text = "女";
			this.rdBtnFemale.UseVisualStyleBackColor = true;
			// 
			// btnCaculate
			// 
			this.btnCaculate.Location = new System.Drawing.Point(57, 61);
			this.btnCaculate.Name = "btnCaculate";
			this.btnCaculate.Size = new System.Drawing.Size(75, 23);
			this.btnCaculate.TabIndex = 5;
			this.btnCaculate.Text = "計算";
			this.btnCaculate.UseVisualStyleBackColor = true;
			this.btnCaculate.Click += new System.EventHandler(this.btnCaculate_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "車資:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 7;
			this.label4.Text = "原因:";
			// 
			// lblFee
			// 
			this.lblFee.AutoSize = true;
			this.lblFee.Location = new System.Drawing.Point(55, 48);
			this.lblFee.Name = "lblFee";
			this.lblFee.Size = new System.Drawing.Size(33, 12);
			this.lblFee.TabIndex = 8;
			this.lblFee.Text = "label5";
			// 
			// lblReason
			// 
			this.lblReason.AutoSize = true;
			this.lblReason.Location = new System.Drawing.Point(54, 88);
			this.lblReason.Name = "lblReason";
			this.lblReason.Size = new System.Drawing.Size(33, 12);
			this.lblReason.TabIndex = 9;
			this.lblReason.Text = "label6";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(341, 357);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(361, 400);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(361, 400);
			this.Name = "Form1";
			this.Text = "車資";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdBtnFemale;
		private System.Windows.Forms.RadioButton rdBtnMale;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnCaculate;
		private System.Windows.Forms.Label lblReason;
		private System.Windows.Forms.Label lblFee;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
	}
}

