namespace PoE_Stash_Pricer
{
    partial class Form1
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
            this.txt_AccountName = new System.Windows.Forms.TextBox();
            this.lbl_CharacterName = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CharacterName = new System.Windows.Forms.TextBox();
            this.txt_Information = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_AccountName
            // 
            this.txt_AccountName.Location = new System.Drawing.Point(132, 12);
            this.txt_AccountName.Name = "txt_AccountName";
            this.txt_AccountName.Size = new System.Drawing.Size(227, 22);
            this.txt_AccountName.TabIndex = 0;
            // 
            // lbl_CharacterName
            // 
            this.lbl_CharacterName.AutoSize = true;
            this.lbl_CharacterName.Location = new System.Drawing.Point(15, 15);
            this.lbl_CharacterName.Name = "lbl_CharacterName";
            this.lbl_CharacterName.Size = new System.Drawing.Size(100, 17);
            this.lbl_CharacterName.TabIndex = 1;
            this.lbl_CharacterName.Text = "Account Name";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(365, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(106, 50);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Character Name";
            // 
            // txt_CharacterName
            // 
            this.txt_CharacterName.Location = new System.Drawing.Point(132, 40);
            this.txt_CharacterName.Name = "txt_CharacterName";
            this.txt_CharacterName.Size = new System.Drawing.Size(227, 22);
            this.txt_CharacterName.TabIndex = 1;
            // 
            // txt_Information
            // 
            this.txt_Information.Location = new System.Drawing.Point(13, 123);
            this.txt_Information.Multiline = true;
            this.txt_Information.Name = "txt_Information";
            this.txt_Information.Size = new System.Drawing.Size(900, 376);
            this.txt_Information.TabIndex = 5;
            this.txt_Information.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 511);
            this.Controls.Add(this.txt_Information);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CharacterName);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_CharacterName);
            this.Controls.Add(this.txt_AccountName);
            this.Name = "Form1";
            this.Text = "PoE Stash Quick Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AccountName;
        private System.Windows.Forms.Label lbl_CharacterName;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CharacterName;
        private System.Windows.Forms.TextBox txt_Information;
    }
}

