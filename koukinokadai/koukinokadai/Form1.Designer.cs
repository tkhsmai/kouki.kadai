namespace koukinokadai
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button4 = new System.Windows.Forms.Button();
            this.labelReel1 = new System.Windows.Forms.Label();
            this.labelReel2 = new System.Windows.Forms.Label();
            this.labelReel3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(286, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 54);
            this.button4.TabIndex = 10;
            this.button4.Text = "START";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelReel1
            // 
            this.labelReel1.BackColor = System.Drawing.Color.White;
            this.labelReel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelReel1.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelReel1.Location = new System.Drawing.Point(66, 132);
            this.labelReel1.Name = "labelReel1";
            this.labelReel1.Size = new System.Drawing.Size(150, 150);
            this.labelReel1.TabIndex = 18;
            this.labelReel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReel2
            // 
            this.labelReel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReel2.BackColor = System.Drawing.Color.White;
            this.labelReel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelReel2.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelReel2.Location = new System.Drawing.Point(263, 132);
            this.labelReel2.Name = "labelReel2";
            this.labelReel2.Size = new System.Drawing.Size(150, 150);
            this.labelReel2.TabIndex = 19;
            this.labelReel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReel3
            // 
            this.labelReel3.BackColor = System.Drawing.Color.White;
            this.labelReel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelReel3.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelReel3.Location = new System.Drawing.Point(457, 132);
            this.labelReel3.Name = "labelReel3";
            this.labelReel3.Size = new System.Drawing.Size(150, 150);
            this.labelReel3.TabIndex = 20;
            this.labelReel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(66, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "Stop1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(263, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "Stop2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(457, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 23;
            this.button3.Text = "Stop3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnStop3_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(561, 54);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(115, 38);
            this.labelScore.TabIndex = 24;
            this.labelScore.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelReel3);
            this.Controls.Add(this.labelReel2);
            this.Controls.Add(this.labelReel1);
            this.Controls.Add(this.button4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelReel1;
        private System.Windows.Forms.Label labelReel2;
        private System.Windows.Forms.Label labelReel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelScore;
    }
}

