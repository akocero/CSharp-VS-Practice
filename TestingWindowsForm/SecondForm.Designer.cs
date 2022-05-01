namespace TestingWindowsForm
{
    partial class SecondForm
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
            this.text_first_name = new System.Windows.Forms.TextBox();
            this.text_last_name = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_first_name
            // 
            this.text_first_name.Location = new System.Drawing.Point(37, 33);
            this.text_first_name.Name = "text_first_name";
            this.text_first_name.Size = new System.Drawing.Size(221, 20);
            this.text_first_name.TabIndex = 0;
            // 
            // text_last_name
            // 
            this.text_last_name.Location = new System.Drawing.Point(37, 59);
            this.text_last_name.Name = "text_last_name";
            this.text_last_name.Size = new System.Drawing.Size(221, 20);
            this.text_last_name.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(37, 136);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(221, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 288);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.text_last_name);
            this.Controls.Add(this.text_first_name);
            this.Name = "SecondForm";
            this.Text = "Add New Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_first_name;
        private System.Windows.Forms.TextBox text_last_name;
        private System.Windows.Forms.Button btn_save;
    }
}