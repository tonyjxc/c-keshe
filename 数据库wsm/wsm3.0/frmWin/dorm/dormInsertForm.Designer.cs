namespace frmWin.dorm
{
    partial class dormInsertForm
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
            this.cboBuilding = new System.Windows.Forms.ComboBox();
            this.cboDormType = new System.Windows.Forms.ComboBox();
            this.cboFlag = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDormNum = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboBuilding
            // 
            this.cboBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuilding.FormattingEnabled = true;
            this.cboBuilding.Location = new System.Drawing.Point(69, 108);
            this.cboBuilding.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBuilding.Name = "cboBuilding";
            this.cboBuilding.Size = new System.Drawing.Size(112, 20);
            this.cboBuilding.TabIndex = 29;
            // 
            // cboDormType
            // 
            this.cboDormType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDormType.FormattingEnabled = true;
            this.cboDormType.Location = new System.Drawing.Point(69, 65);
            this.cboDormType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDormType.Name = "cboDormType";
            this.cboDormType.Size = new System.Drawing.Size(112, 20);
            this.cboDormType.TabIndex = 28;
            // 
            // cboFlag
            // 
            this.cboFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFlag.FormattingEnabled = true;
            this.cboFlag.Items.AddRange(new object[] {
            "可以入住",
            "不可入住"});
            this.cboFlag.Location = new System.Drawing.Point(69, 151);
            this.cboFlag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboFlag.Name = "cboFlag";
            this.cboFlag.Size = new System.Drawing.Size(112, 20);
            this.cboFlag.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "宿舍名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "宿舍类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "所在楼";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 33;
            this.label4.Text = "宿舍状态";
            // 
            // txtDormNum
            // 
            this.txtDormNum.Location = new System.Drawing.Point(69, 31);
            this.txtDormNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDormNum.Name = "txtDormNum";
            this.txtDormNum.Size = new System.Drawing.Size(112, 21);
            this.txtDormNum.TabIndex = 34;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(50, 198);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(56, 28);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(123, 198);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 28);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dormInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 265);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDormNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBuilding);
            this.Controls.Add(this.cboDormType);
            this.Controls.Add(this.cboFlag);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "dormInsertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "宿舍添加";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.dormInsertForm_FormClosed);
            this.Load += new System.EventHandler(this.dormInsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBuilding;
        private System.Windows.Forms.ComboBox cboDormType;
        private System.Windows.Forms.ComboBox cboFlag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDormNum;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
    }
}