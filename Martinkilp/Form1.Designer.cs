namespace Martinkilp
{
    partial class MK_form1
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
            this.MK_form1_mängi = new System.Windows.Forms.Button();
            this.MK_lbl_info = new System.Windows.Forms.Label();
            this.MK_lbl_mäng = new System.Windows.Forms.Label();
            this.MK_lbl_valimäng = new System.Windows.Forms.Label();
            this.MK_CB = new System.Windows.Forms.ComboBox();
            this.MK_lbl_valitudmäng = new System.Windows.Forms.Label();
            this.MK_form1_välju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MK_form1_mängi
            // 
            this.MK_form1_mängi.BackColor = System.Drawing.Color.Silver;
            this.MK_form1_mängi.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MK_form1_mängi.ForeColor = System.Drawing.Color.Black;
            this.MK_form1_mängi.Location = new System.Drawing.Point(266, 335);
            this.MK_form1_mängi.Name = "MK_form1_mängi";
            this.MK_form1_mängi.Size = new System.Drawing.Size(461, 112);
            this.MK_form1_mängi.TabIndex = 1;
            this.MK_form1_mängi.Text = "Mängi:";
            this.MK_form1_mängi.UseVisualStyleBackColor = false;
            this.MK_form1_mängi.Click += new System.EventHandler(this.MK_form1_button1_Click);
            // 
            // MK_lbl_info
            // 
            this.MK_lbl_info.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MK_lbl_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MK_lbl_info.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MK_lbl_info.Location = new System.Drawing.Point(831, 34);
            this.MK_lbl_info.Name = "MK_lbl_info";
            this.MK_lbl_info.Size = new System.Drawing.Size(125, 36);
            this.MK_lbl_info.TabIndex = 3;
            this.MK_lbl_info.Text = "Info";
            this.MK_lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MK_lbl_info.Click += new System.EventHandler(this.MK_lbl_info_Click);
            // 
            // MK_lbl_mäng
            // 
            this.MK_lbl_mäng.BackColor = System.Drawing.Color.White;
            this.MK_lbl_mäng.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MK_lbl_mäng.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MK_lbl_mäng.Location = new System.Drawing.Point(28, 182);
            this.MK_lbl_mäng.Name = "MK_lbl_mäng";
            this.MK_lbl_mäng.Size = new System.Drawing.Size(387, 30);
            this.MK_lbl_mäng.TabIndex = 4;
            this.MK_lbl_mäng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MK_lbl_mäng.Click += new System.EventHandler(this.label1_Click);
            // 
            // MK_lbl_valimäng
            // 
            this.MK_lbl_valimäng.BackColor = System.Drawing.Color.Transparent;
            this.MK_lbl_valimäng.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MK_lbl_valimäng.Location = new System.Drawing.Point(474, 165);
            this.MK_lbl_valimäng.Name = "MK_lbl_valimäng";
            this.MK_lbl_valimäng.Size = new System.Drawing.Size(188, 47);
            this.MK_lbl_valimäng.TabIndex = 5;
            this.MK_lbl_valimäng.Text = "vali mäng:";
            this.MK_lbl_valimäng.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MK_CB
            // 
            this.MK_CB.AllowDrop = true;
            this.MK_CB.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MK_CB.FormattingEnabled = true;
            this.MK_CB.Items.AddRange(new object[] {
            "Kivi-Paber-Käärid"});
            this.MK_CB.Location = new System.Drawing.Point(668, 175);
            this.MK_CB.MaxDropDownItems = 12;
            this.MK_CB.Name = "MK_CB";
            this.MK_CB.Size = new System.Drawing.Size(288, 29);
            this.MK_CB.TabIndex = 7;
            this.MK_CB.SelectedIndexChanged += new System.EventHandler(this.MK_CB_SelectedIndexChanged);
            // 
            // MK_lbl_valitudmäng
            // 
            this.MK_lbl_valitudmäng.BackColor = System.Drawing.Color.Transparent;
            this.MK_lbl_valitudmäng.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MK_lbl_valitudmäng.Location = new System.Drawing.Point(116, 146);
            this.MK_lbl_valitudmäng.Name = "MK_lbl_valitudmäng";
            this.MK_lbl_valitudmäng.Size = new System.Drawing.Size(232, 36);
            this.MK_lbl_valitudmäng.TabIndex = 8;
            this.MK_lbl_valitudmäng.Text = "Valitud mäng:";
            this.MK_lbl_valitudmäng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MK_form1_välju
            // 
            this.MK_form1_välju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MK_form1_välju.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MK_form1_välju.Location = new System.Drawing.Point(795, 513);
            this.MK_form1_välju.Name = "MK_form1_välju";
            this.MK_form1_välju.Size = new System.Drawing.Size(161, 35);
            this.MK_form1_välju.TabIndex = 9;
            this.MK_form1_välju.Text = "Välju";
            this.MK_form1_välju.UseVisualStyleBackColor = false;
            this.MK_form1_välju.Click += new System.EventHandler(this.MK_form1_välju_Click);
            // 
            // MK_form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.MK_form1_välju);
            this.Controls.Add(this.MK_lbl_valitudmäng);
            this.Controls.Add(this.MK_CB);
            this.Controls.Add(this.MK_lbl_valimäng);
            this.Controls.Add(this.MK_lbl_mäng);
            this.Controls.Add(this.MK_lbl_info);
            this.Controls.Add(this.MK_form1_mängi);
            this.Name = "MK_form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mängime";
            this.Load += new System.EventHandler(this.MartinKilp_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button MK_form1_mängi;
        private System.Windows.Forms.Label MK_lbl_info;
        private System.Windows.Forms.Label MK_lbl_mäng;
        private System.Windows.Forms.Label MK_lbl_valimäng;
        private System.Windows.Forms.ComboBox MK_CB;
        private System.Windows.Forms.Label MK_lbl_valitudmäng;
        private System.Windows.Forms.Button MK_form1_välju;
    }
}

