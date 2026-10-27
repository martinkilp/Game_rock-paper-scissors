namespace Martinkilp
{
    partial class Info_Form
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
            this.MK_info_lbl = new System.Windows.Forms.Label();
            this.MK_info_rtb = new System.Windows.Forms.RichTextBox();
            this.MK_info_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MK_info_lbl
            // 
            this.MK_info_lbl.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MK_info_lbl.Location = new System.Drawing.Point(14, 10);
            this.MK_info_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MK_info_lbl.Name = "MK_info_lbl";
            this.MK_info_lbl.Size = new System.Drawing.Size(104, 44);
            this.MK_info_lbl.TabIndex = 0;
            this.MK_info_lbl.Text = "Info";
            this.MK_info_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MK_info_rtb
            // 
            this.MK_info_rtb.BackColor = System.Drawing.Color.White;
            this.MK_info_rtb.Location = new System.Drawing.Point(14, 57);
            this.MK_info_rtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MK_info_rtb.Name = "MK_info_rtb";
            this.MK_info_rtb.Size = new System.Drawing.Size(905, 198);
            this.MK_info_rtb.TabIndex = 1;
            this.MK_info_rtb.Text = "";
            this.MK_info_rtb.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // MK_info_btn
            // 
            this.MK_info_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MK_info_btn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MK_info_btn.Location = new System.Drawing.Point(406, 277);
            this.MK_info_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MK_info_btn.Name = "MK_info_btn";
            this.MK_info_btn.Size = new System.Drawing.Size(112, 35);
            this.MK_info_btn.TabIndex = 2;
            this.MK_info_btn.Text = "sulge";
            this.MK_info_btn.UseVisualStyleBackColor = false;
            this.MK_info_btn.Click += new System.EventHandler(this.MK_info_btn_Click);
            // 
            // Info_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.MK_info_btn);
            this.Controls.Add(this.MK_info_rtb);
            this.Controls.Add(this.MK_info_lbl);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Info_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MK_info_lbl;
        private System.Windows.Forms.RichTextBox MK_info_rtb;
        private System.Windows.Forms.Button MK_info_btn;
    }
}