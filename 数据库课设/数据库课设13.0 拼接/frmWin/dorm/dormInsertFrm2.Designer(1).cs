﻿namespace frmWin.dorm
{
    partial class dormInsertFrm2
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtDormNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBuilding = new System.Windows.Forms.ComboBox();
            this.cboDormType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(134, 189);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 30);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(51, 189);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(69, 30);
            this.btnSubmit.TabIndex = 45;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtDormNum
            // 
            this.txtDormNum.Location = new System.Drawing.Point(86, 37);
            this.txtDormNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDormNum.Name = "txtDormNum";
            this.txtDormNum.Size = new System.Drawing.Size(112, 21);
            this.txtDormNum.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 42;
            this.label3.Text = "所在楼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 41;
            this.label2.Text = "宿舍类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 40;
            this.label1.Text = "宿舍编号";
            // 
            // cboBuilding
            // 
            this.cboBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuilding.FormattingEnabled = true;
            this.cboBuilding.Location = new System.Drawing.Point(86, 114);
            this.cboBuilding.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBuilding.Name = "cboBuilding";
            this.cboBuilding.Size = new System.Drawing.Size(112, 20);
            this.cboBuilding.TabIndex = 39;
            // 
            // cboDormType
            // 
            this.cboDormType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDormType.FormattingEnabled = true;
            this.cboDormType.Location = new System.Drawing.Point(86, 70);
            this.cboDormType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDormType.Name = "cboDormType";
            this.cboDormType.Size = new System.Drawing.Size(112, 20);
            this.cboDormType.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 48;
            this.label5.Text = "备注";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(86, 155);
            this.txtMemo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(112, 21);
            this.txtMemo.TabIndex = 49;
            // 
            // dormInsertFrm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 286);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDormNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBuilding);
            this.Controls.Add(this.cboDormType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "dormInsertFrm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dormInsertFrm2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dormInsertFrm2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDormNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBuilding;
        private System.Windows.Forms.ComboBox cboDormType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMemo;
    }
}