namespace WindowsFormsApp1
{
    partial class mem_word
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mem_word));
            this.back = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("宋体", 14F);
            this.back.Location = new System.Drawing.Point(432, 355);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(140, 65);
            this.back.TabIndex = 6;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("宋体", 14F);
            this.logout.Location = new System.Drawing.Point(594, 355);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(140, 65);
            this.logout.TabIndex = 5;
            this.logout.Text = "退出";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(67, 63);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowTemplate.Height = 50;
            this.table.Size = new System.Drawing.Size(667, 255);
            this.table.TabIndex = 7;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(75, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "单击方格，即可开启默写功能";
            // 
            // mem_word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.back);
            this.Controls.Add(this.logout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mem_word";
            this.Text = "背单词";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label label1;
    }
}