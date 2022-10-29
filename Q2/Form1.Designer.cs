namespace Q2
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
			this.btnRoll = new System.Windows.Forms.Button();
			this.txtDigit0 = new System.Windows.Forms.TextBox();
			this.txtDigit1 = new System.Windows.Forms.TextBox();
			this.txtDigit2 = new System.Windows.Forms.TextBox();
			this.txtDigit3 = new System.Windows.Forms.TextBox();
			this.lblValue = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRoll
			// 
			this.btnRoll.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnRoll.Location = new System.Drawing.Point(117, 271);
			this.btnRoll.Name = "btnRoll";
			this.btnRoll.Size = new System.Drawing.Size(113, 60);
			this.btnRoll.TabIndex = 0;
			this.btnRoll.Text = "Roll";
			this.btnRoll.UseVisualStyleBackColor = true;
			this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
			// 
			// txtDigit0
			// 
			this.txtDigit0.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDigit0.Location = new System.Drawing.Point(81, 98);
			this.txtDigit0.Name = "txtDigit0";
			this.txtDigit0.Size = new System.Drawing.Size(34, 34);
			this.txtDigit0.TabIndex = 1;
			// 
			// txtDigit1
			// 
			this.txtDigit1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDigit1.Location = new System.Drawing.Point(133, 98);
			this.txtDigit1.Name = "txtDigit1";
			this.txtDigit1.Size = new System.Drawing.Size(34, 34);
			this.txtDigit1.TabIndex = 1;
			// 
			// txtDigit2
			// 
			this.txtDigit2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDigit2.Location = new System.Drawing.Point(185, 98);
			this.txtDigit2.Name = "txtDigit2";
			this.txtDigit2.Size = new System.Drawing.Size(34, 34);
			this.txtDigit2.TabIndex = 1;
			// 
			// txtDigit3
			// 
			this.txtDigit3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDigit3.Location = new System.Drawing.Point(237, 98);
			this.txtDigit3.Name = "txtDigit3";
			this.txtDigit3.Size = new System.Drawing.Size(34, 34);
			this.txtDigit3.TabIndex = 1;
			// 
			// lblValue
			// 
			this.lblValue.AutoSize = true;
			this.lblValue.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblValue.Location = new System.Drawing.Point(162, 195);
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new System.Drawing.Size(92, 25);
			this.lblValue.TabIndex = 2;
			this.lblValue.Text = "lblValue";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(75, 195);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Value:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblValue);
			this.Controls.Add(this.txtDigit3);
			this.Controls.Add(this.txtDigit2);
			this.Controls.Add(this.txtDigit1);
			this.Controls.Add(this.txtDigit0);
			this.Controls.Add(this.btnRoll);
			this.Name = "Form1";
			this.Text = "RollDice";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRoll;
		private System.Windows.Forms.TextBox txtDigit0;
		private System.Windows.Forms.TextBox txtDigit1;
		private System.Windows.Forms.TextBox txtDigit2;
		private System.Windows.Forms.TextBox txtDigit3;
		private System.Windows.Forms.Label lblValue;
		private System.Windows.Forms.Label label1;
	}
}

