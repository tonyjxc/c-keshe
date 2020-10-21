namespace WindowsFormsApp1
{
    partial class translate_or_memory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(translate_or_memory));
            this.memory_but = new System.Windows.Forms.Button();
            this.translate_but = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.sayhello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // memory_but
            // 
            this.memory_but.Font = new System.Drawing.Font("宋体", 25F);
            this.memory_but.Location = new System.Drawing.Point(160, 179);
            this.memory_but.Name = "memory_but";
            this.memory_but.Size = new System.Drawing.Size(193, 81);
            this.memory_but.TabIndex = 0;
            this.memory_but.Text = "背诵";
            this.memory_but.UseVisualStyleBackColor = true;
            this.memory_but.Click += new System.EventHandler(this.memory_but_Click);
            // 
            // translate_but
            // 
            this.translate_but.Font = new System.Drawing.Font("宋体", 25F);
            this.translate_but.Location = new System.Drawing.Point(467, 179);
            this.translate_but.Name = "translate_but";
            this.translate_but.Size = new System.Drawing.Size(193, 81);
            this.translate_but.TabIndex = 1;
            this.translate_but.Text = "翻译";
            this.translate_but.UseVisualStyleBackColor = true;
            this.translate_but.Click += new System.EventHandler(this.translate_but_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("宋体", 14F);
            this.logout.Location = new System.Drawing.Point(520, 342);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(140, 65);
            this.logout.TabIndex = 3;
            this.logout.Text = "退出";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("宋体", 14F);
            this.back.Location = new System.Drawing.Point(358, 342);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(140, 65);
            this.back.TabIndex = 4;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // sayhello
            // 
            this.sayhello.AutoSize = true;
            this.sayhello.Font = new System.Drawing.Font("宋体", 15F);
            this.sayhello.Location = new System.Drawing.Point(182, 69);
            this.sayhello.Name = "sayhello";
            this.sayhello.Size = new System.Drawing.Size(19, 20);
            this.sayhello.TabIndex = 5;
            this.sayhello.Text = " ";
            // 
            // translate_or_memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sayhello);
            this.Controls.Add(this.back);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.translate_but);
            this.Controls.Add(this.memory_but);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "translate_or_memory";
            this.Text = "translate_or_memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button memory_but;
        private System.Windows.Forms.Button translate_but;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label sayhello;
    }
}