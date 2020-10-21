namespace WindowsFormsApp1
{
    partial class memory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memory));
            this.exit_but = new System.Windows.Forms.Button();
            this.back_but = new System.Windows.Forms.Button();
            this.sayhello = new System.Windows.Forms.Label();
            this.sentenc_but = new System.Windows.Forms.Button();
            this.word_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit_but
            // 
            this.exit_but.Font = new System.Drawing.Font("宋体", 15F);
            this.exit_but.Location = new System.Drawing.Point(626, 349);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(130, 51);
            this.exit_but.TabIndex = 8;
            this.exit_but.Text = "退出";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // back_but
            // 
            this.back_but.Font = new System.Drawing.Font("宋体", 15F);
            this.back_but.Location = new System.Drawing.Point(440, 349);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(130, 51);
            this.back_but.TabIndex = 7;
            this.back_but.Text = "返回";
            this.back_but.UseVisualStyleBackColor = true;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // sayhello
            // 
            this.sayhello.AutoSize = true;
            this.sayhello.Font = new System.Drawing.Font("宋体", 15F);
            this.sayhello.Location = new System.Drawing.Point(192, 49);
            this.sayhello.Name = "sayhello";
            this.sayhello.Size = new System.Drawing.Size(19, 20);
            this.sayhello.TabIndex = 9;
            this.sayhello.Text = " ";
            // 
            // sentenc_but
            // 
            this.sentenc_but.Font = new System.Drawing.Font("宋体", 25F);
            this.sentenc_but.Location = new System.Drawing.Point(467, 168);
            this.sentenc_but.Name = "sentenc_but";
            this.sentenc_but.Size = new System.Drawing.Size(193, 81);
            this.sentenc_but.TabIndex = 11;
            this.sentenc_but.Text = "句子";
            this.sentenc_but.UseVisualStyleBackColor = true;
            this.sentenc_but.Click += new System.EventHandler(this.sentenc_but_Click);
            // 
            // word_but
            // 
            this.word_but.Font = new System.Drawing.Font("宋体", 25F);
            this.word_but.Location = new System.Drawing.Point(160, 168);
            this.word_but.Name = "word_but";
            this.word_but.Size = new System.Drawing.Size(193, 81);
            this.word_but.TabIndex = 10;
            this.word_but.Text = "单词";
            this.word_but.UseVisualStyleBackColor = true;
            this.word_but.Click += new System.EventHandler(this.word_but_Click);
            // 
            // memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sentenc_but);
            this.Controls.Add(this.word_but);
            this.Controls.Add(this.sayhello);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.back_but);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "memory";
            this.Text = "memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_but;
        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.Label sayhello;
        private System.Windows.Forms.Button sentenc_but;
        private System.Windows.Forms.Button word_but;
    }
}