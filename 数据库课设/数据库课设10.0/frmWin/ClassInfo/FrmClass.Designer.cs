namespace frmWin
{
    partial class FrmClass
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
            this.ClassInfo = new System.Windows.Forms.DataGridView();
            this.ClassType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClassInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassInfo
            // 
            this.ClassInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassInfo.Location = new System.Drawing.Point(324, 90);
            this.ClassInfo.Margin = new System.Windows.Forms.Padding(2);
            this.ClassInfo.Name = "ClassInfo";
            this.ClassInfo.RowHeadersWidth = 51;
            this.ClassInfo.RowTemplate.Height = 27;
            this.ClassInfo.Size = new System.Drawing.Size(416, 270);
            this.ClassInfo.TabIndex = 11;
            this.ClassInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassInfo_CellContentClick);
            // 
            // ClassType
            // 
            this.ClassType.Font = new System.Drawing.Font("宋体", 15F);
            this.ClassType.FormattingEnabled = true;
            this.ClassType.Location = new System.Drawing.Point(129, 205);
            this.ClassType.Margin = new System.Windows.Forms.Padding(2);
            this.ClassType.Name = "ClassType";
            this.ClassType.Size = new System.Drawing.Size(180, 28);
            this.ClassType.TabIndex = 9;
            this.ClassType.SelectedIndexChanged += new System.EventHandler(this.ClassType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(36, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "管理班级";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 12F);
            this.btnExit.Location = new System.Drawing.Point(682, 391);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 26);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.deleteBtn.Location = new System.Drawing.Point(577, 391);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(59, 26);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "删除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // FrmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.ClassInfo);
            this.Controls.Add(this.ClassType);
            this.Controls.Add(this.label2);
            this.Name = "FrmClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "班级管理";
            this.Load += new System.EventHandler(this.FrmTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClassInfo;
        private System.Windows.Forms.ComboBox ClassType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button deleteBtn;
    }
}