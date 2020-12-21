namespace frmWin
{
    partial class FrmDormAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBuild = new System.Windows.Forms.ComboBox();
            this.cmbDormType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.aa1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSingleAdd = new System.Windows.Forms.Button();
            this.txtDormNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aa2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.txtEndNo = new System.Windows.Forms.TextBox();
            this.txtStartNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBatchAdd = new System.Windows.Forms.Button();
            this.dgvDorm = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.aa1.SuspendLayout();
            this.aa2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDorm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "宿舍楼";
            // 
            // cmbBuild
            // 
            this.cmbBuild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuild.FormattingEnabled = true;
            this.cmbBuild.Location = new System.Drawing.Point(100, 37);
            this.cmbBuild.Name = "cmbBuild";
            this.cmbBuild.Size = new System.Drawing.Size(238, 23);
            this.cmbBuild.TabIndex = 1;
            this.cmbBuild.SelectedIndexChanged += new System.EventHandler(this.cmbBuild_SelectedIndexChanged);
            // 
            // cmbDormType
            // 
            this.cmbDormType.FormattingEnabled = true;
            this.cmbDormType.Location = new System.Drawing.Point(100, 78);
            this.cmbDormType.Name = "cmbDormType";
            this.cmbDormType.Size = new System.Drawing.Size(238, 23);
            this.cmbDormType.TabIndex = 3;
            this.cmbDormType.SelectedIndexChanged += new System.EventHandler(this.cmbDormType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "宿舍类型";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.aa1);
            this.tabControl1.Controls.Add(this.aa2);
            this.tabControl1.Location = new System.Drawing.Point(33, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(305, 243);
            this.tabControl1.TabIndex = 4;
            // 
            // aa1
            // 
            this.aa1.Controls.Add(this.button2);
            this.aa1.Controls.Add(this.btnSingleAdd);
            this.aa1.Controls.Add(this.txtDormNo);
            this.aa1.Controls.Add(this.label3);
            this.aa1.Location = new System.Drawing.Point(4, 25);
            this.aa1.Name = "aa1";
            this.aa1.Padding = new System.Windows.Forms.Padding(3);
            this.aa1.Size = new System.Drawing.Size(297, 214);
            this.aa1.TabIndex = 0;
            this.aa1.Text = "单个宿舍添加";
            this.aa1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSingleAdd
            // 
            this.btnSingleAdd.Location = new System.Drawing.Point(37, 132);
            this.btnSingleAdd.Name = "btnSingleAdd";
            this.btnSingleAdd.Size = new System.Drawing.Size(92, 35);
            this.btnSingleAdd.TabIndex = 7;
            this.btnSingleAdd.Text = "单个添加";
            this.btnSingleAdd.UseVisualStyleBackColor = true;
            this.btnSingleAdd.Click += new System.EventHandler(this.btnSingleAdd_Click);
            // 
            // txtDormNo
            // 
            this.txtDormNo.Location = new System.Drawing.Point(109, 65);
            this.txtDormNo.Name = "txtDormNo";
            this.txtDormNo.Size = new System.Drawing.Size(134, 25);
            this.txtDormNo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "宿舍号";
            // 
            // aa2
            // 
            this.aa2.Controls.Add(this.button4);
            this.aa2.Controls.Add(this.txtEndNo);
            this.aa2.Controls.Add(this.txtStartNo);
            this.aa2.Controls.Add(this.label5);
            this.aa2.Controls.Add(this.label4);
            this.aa2.Controls.Add(this.btnBatchAdd);
            this.aa2.Location = new System.Drawing.Point(4, 25);
            this.aa2.Name = "aa2";
            this.aa2.Padding = new System.Windows.Forms.Padding(3);
            this.aa2.Size = new System.Drawing.Size(297, 214);
            this.aa2.TabIndex = 1;
            this.aa2.Text = "批量宿舍添加";
            this.aa2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(145, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 38);
            this.button4.TabIndex = 13;
            this.button4.Text = "取消";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtEndNo
            // 
            this.txtEndNo.Location = new System.Drawing.Point(92, 65);
            this.txtEndNo.Name = "txtEndNo";
            this.txtEndNo.Size = new System.Drawing.Size(142, 25);
            this.txtEndNo.TabIndex = 12;
            // 
            // txtStartNo
            // 
            this.txtStartNo.Location = new System.Drawing.Point(92, 17);
            this.txtStartNo.Name = "txtStartNo";
            this.txtStartNo.Size = new System.Drawing.Size(142, 25);
            this.txtStartNo.TabIndex = 11;
            this.txtStartNo.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "结束编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "开始编号";
            // 
            // btnBatchAdd
            // 
            this.btnBatchAdd.Location = new System.Drawing.Point(21, 114);
            this.btnBatchAdd.Name = "btnBatchAdd";
            this.btnBatchAdd.Size = new System.Drawing.Size(89, 38);
            this.btnBatchAdd.TabIndex = 8;
            this.btnBatchAdd.Text = "批量添加";
            this.btnBatchAdd.UseVisualStyleBackColor = true;
            this.btnBatchAdd.Click += new System.EventHandler(this.btnBatchAdd_Click);
            // 
            // dgvDorm
            // 
            this.dgvDorm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDorm.Location = new System.Drawing.Point(376, 37);
            this.dgvDorm.Name = "dgvDorm";
            this.dgvDorm.RowHeadersWidth = 51;
            this.dgvDorm.RowTemplate.Height = 27;
            this.dgvDorm.Size = new System.Drawing.Size(554, 337);
            this.dgvDorm.TabIndex = 5;
            // 
            // FrmDormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.dgvDorm);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cmbDormType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBuild);
            this.Controls.Add(this.label1);
            this.Name = "FrmDormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "宿舍添加";
            this.Load += new System.EventHandler(this.FrmDormAdd_Load);
            this.tabControl1.ResumeLayout(false);
            this.aa1.ResumeLayout(false);
            this.aa1.PerformLayout();
            this.aa2.ResumeLayout(false);
            this.aa2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDorm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBuild;
        private System.Windows.Forms.ComboBox cmbDormType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage aa1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSingleAdd;
        private System.Windows.Forms.TextBox txtDormNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage aa2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtEndNo;
        private System.Windows.Forms.TextBox txtStartNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBatchAdd;
        private System.Windows.Forms.DataGridView dgvDorm;
    }
}