namespace Q1
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
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnGuess = new System.Windows.Forms.Button();
			this.txtShow = new System.Windows.Forms.TextBox();
			this.btnNewGame = new System.Windows.Forms.Button();
			this.lblAnswer = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtInput
			// 
			this.txtInput.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtInput.Location = new System.Drawing.Point(118, 136);
			this.txtInput.MaxLength = 4;
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(130, 34);
			this.txtInput.TabIndex = 1;
			// 
			// btnGuess
			// 
			this.btnGuess.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnGuess.Location = new System.Drawing.Point(302, 136);
			this.btnGuess.Name = "btnGuess";
			this.btnGuess.Size = new System.Drawing.Size(117, 34);
			this.btnGuess.TabIndex = 2;
			this.btnGuess.Text = "Guess";
			this.btnGuess.UseVisualStyleBackColor = true;
			this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
			// 
			// txtShow
			// 
			this.txtShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtShow.Location = new System.Drawing.Point(118, 207);
			this.txtShow.Multiline = true;
			this.txtShow.Name = "txtShow";
			this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtShow.Size = new System.Drawing.Size(301, 221);
			this.txtShow.TabIndex = 3;
			// 
			// btnNewGame
			// 
			this.btnNewGame.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnNewGame.Location = new System.Drawing.Point(118, 56);
			this.btnNewGame.Name = "btnNewGame";
			this.btnNewGame.Size = new System.Drawing.Size(301, 43);
			this.btnNewGame.TabIndex = 0;
			this.btnNewGame.Text = "NewGame";
			this.btnNewGame.UseVisualStyleBackColor = true;
			this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
			// 
			// lblAnswer
			// 
			this.lblAnswer.AutoSize = true;
			this.lblAnswer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblAnswer.Location = new System.Drawing.Point(403, 467);
			this.lblAnswer.Name = "lblAnswer";
			this.lblAnswer.Size = new System.Drawing.Size(108, 25);
			this.lblAnswer.TabIndex = 5;
			this.lblAnswer.Text = "lblAnswer";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(309, 467);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Answer:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 534);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblAnswer);
			this.Controls.Add(this.btnNewGame);
			this.Controls.Add(this.btnGuess);
			this.Controls.Add(this.txtShow);
			this.Controls.Add(this.txtInput);
			this.Name = "Form1";
			this.Text = "GuessGame";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox txtShow;
		private System.Windows.Forms.Button btnNewGame;
		private System.Windows.Forms.Label lblAnswer;
		private System.Windows.Forms.Label label1;
	}
}

