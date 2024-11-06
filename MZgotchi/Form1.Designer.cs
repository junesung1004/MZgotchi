namespace MZgotchi
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblHungry = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHappiness = new System.Windows.Forms.Label();
            this.lable223 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnHealth = new System.Windows.Forms.Label();
            this.btnEat = new System.Windows.Forms.Label();
            this.btnPlaying = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(47, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "건강 :";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHealth.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHealth.Location = new System.Drawing.Point(151, 14);
            this.lblHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(75, 40);
            this.lblHealth.TabIndex = 1;
            this.lblHealth.Text = "좋음";
            // 
            // lblHungry
            // 
            this.lblHungry.AutoSize = true;
            this.lblHungry.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHungry.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHungry.Location = new System.Drawing.Point(151, 116);
            this.lblHungry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHungry.Name = "lblHungry";
            this.lblHungry.Size = new System.Drawing.Size(104, 40);
            this.lblHungry.TabIndex = 3;
            this.lblHungry.Text = "배부름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(26, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "배고픔 :";
            // 
            // lblHappiness
            // 
            this.lblHappiness.AutoSize = true;
            this.lblHappiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHappiness.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHappiness.Location = new System.Drawing.Point(151, 69);
            this.lblHappiness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHappiness.Name = "lblHappiness";
            this.lblHappiness.Size = new System.Drawing.Size(75, 40);
            this.lblHappiness.TabIndex = 5;
            this.lblHappiness.Text = "좋음";
            // 
            // lable223
            // 
            this.lable223.AutoSize = true;
            this.lable223.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lable223.Location = new System.Drawing.Point(47, 69);
            this.lable223.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable223.Name = "lable223";
            this.lable223.Size = new System.Drawing.Size(97, 40);
            this.lable223.TabIndex = 4;
            this.lable223.Text = "기분 :";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("맑은 고딕", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(49, 200);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(232, 41);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "이거거덩요~🎈";
            // 
            // btnHealth
            // 
            this.btnHealth.AutoSize = true;
            this.btnHealth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHealth.Font = new System.Drawing.Font("맑은 고딕", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHealth.Location = new System.Drawing.Point(26, 681);
            this.btnHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.Size = new System.Drawing.Size(78, 41);
            this.btnHealth.TabIndex = 7;
            this.btnHealth.Text = "운동";
            this.btnHealth.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // btnEat
            // 
            this.btnEat.AutoSize = true;
            this.btnEat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEat.Font = new System.Drawing.Font("맑은 고딕", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEat.Location = new System.Drawing.Point(238, 681);
            this.btnEat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(78, 41);
            this.btnEat.TabIndex = 8;
            this.btnEat.Text = "먹기";
            this.btnEat.Click += new System.EventHandler(this.btnEat_Click);
            // 
            // btnPlaying
            // 
            this.btnPlaying.AutoSize = true;
            this.btnPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaying.Font = new System.Drawing.Font("맑은 고딕", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlaying.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPlaying.Location = new System.Drawing.Point(127, 681);
            this.btnPlaying.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnPlaying.Name = "btnPlaying";
            this.btnPlaying.Size = new System.Drawing.Size(78, 41);
            this.btnPlaying.TabIndex = 9;
            this.btnPlaying.Text = "놀기";
            this.btnPlaying.Click += new System.EventHandler(this.btnPlaying_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("궁서체", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(481, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "MZ고치 오늘의 할 일";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtInput.Location = new System.Drawing.Point(477, 552);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(373, 53);
            this.txtInput.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("나눔고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(477, 623);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 96);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "할일 추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("나눔고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(679, 623);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 96);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "할일 삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 32;
            this.listBox.Location = new System.Drawing.Point(477, 80);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(373, 452);
            this.listBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(904, 746);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPlaying);
            this.Controls.Add(this.btnEat);
            this.Controls.Add(this.btnHealth);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblHappiness);
            this.Controls.Add(this.lable223);
            this.Controls.Add(this.lblHungry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblHungry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHappiness;
        private System.Windows.Forms.Label lable223;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label btnHealth;
        private System.Windows.Forms.Label btnEat;
        private System.Windows.Forms.Label btnPlaying;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox listBox;
    }
}

