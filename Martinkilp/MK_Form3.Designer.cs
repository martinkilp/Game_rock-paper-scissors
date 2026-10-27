namespace Martinkilp
{
    partial class MK_Form3
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
            this.MK_form3_btnsulge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MK_form3_btnsulge
            // 
            this.MK_form3_btnsulge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MK_form3_btnsulge.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MK_form3_btnsulge.Location = new System.Drawing.Point(504, 614);
            this.MK_form3_btnsulge.Name = "MK_form3_btnsulge";
            this.MK_form3_btnsulge.Size = new System.Drawing.Size(172, 35);
            this.MK_form3_btnsulge.TabIndex = 4;
            this.MK_form3_btnsulge.Text = "Lõpeta mäng";
            this.MK_form3_btnsulge.UseVisualStyleBackColor = false;
            this.MK_form3_btnsulge.Click += new System.EventHandler(this.MK_form3_btnsulge_Click);
            // 
            // MK_Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.MK_form3_btnsulge);
            this.Name = "MK_Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memoriin-värvid";
            this.Load += new System.EventHandler(this.MK_Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MK_form3_btnsulge;
    }
}