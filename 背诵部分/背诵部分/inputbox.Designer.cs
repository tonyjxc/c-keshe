namespace 背诵部分
{
    partial class inputbox
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
            this.input_txt = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(251, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // input_txt
            // 
            this.input_txt.Font = new System.Drawing.Font("宋体", 20F);
            this.input_txt.Location = new System.Drawing.Point(244, 175);
            this.input_txt.Multiline = true;
            this.input_txt.Name = "input_txt";
            this.input_txt.Size = new System.Drawing.Size(306, 110);
            this.input_txt.TabIndex = 1;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("宋体", 15F);
            this.back.Location = new System.Drawing.Point(330, 316);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(127, 59);
            this.back.TabIndex = 2;
            this.back.Text = "OK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // inputbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.input_txt);
            this.Controls.Add(this.label1);
            this.Name = "inputbox";
            this.Text = "inputbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_txt;
        private System.Windows.Forms.Button back;
    }
}