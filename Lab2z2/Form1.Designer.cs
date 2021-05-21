
namespace Lab2z2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoVBig = new System.Windows.Forms.RadioButton();
            this.rdoBig = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbUnderline = new System.Windows.Forms.CheckBox();
            this.cbItalic = new System.Windows.Forms.CheckBox();
            this.cbBold = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoOrange = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.lblTekst = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoVBig);
            this.groupBox1.Controls.Add(this.rdoBig);
            this.groupBox1.Controls.Add(this.rdoSmall);
            this.groupBox1.Location = new System.Drawing.Point(45, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wielkość";
            // 
            // rdoVBig
            // 
            this.rdoVBig.AutoSize = true;
            this.rdoVBig.Location = new System.Drawing.Point(6, 75);
            this.rdoVBig.Name = "rdoVBig";
            this.rdoVBig.Size = new System.Drawing.Size(89, 19);
            this.rdoVBig.TabIndex = 2;
            this.rdoVBig.TabStop = true;
            this.rdoVBig.Text = "bardzo duża";
            this.rdoVBig.UseVisualStyleBackColor = true;
            // 
            // rdoBig
            // 
            this.rdoBig.AutoSize = true;
            this.rdoBig.Location = new System.Drawing.Point(7, 50);
            this.rdoBig.Name = "rdoBig";
            this.rdoBig.Size = new System.Drawing.Size(50, 19);
            this.rdoBig.TabIndex = 1;
            this.rdoBig.TabStop = true;
            this.rdoBig.Text = "duża";
            this.rdoBig.UseVisualStyleBackColor = true;
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(6, 25);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(51, 19);
            this.rdoSmall.TabIndex = 0;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "mała";
            this.rdoSmall.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbUnderline);
            this.groupBox2.Controls.Add(this.cbItalic);
            this.groupBox2.Controls.Add(this.cbBold);
            this.groupBox2.Location = new System.Drawing.Point(253, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Styl czcionki";
            // 
            // cbUnderline
            // 
            this.cbUnderline.AutoSize = true;
            this.cbUnderline.Location = new System.Drawing.Point(6, 75);
            this.cbUnderline.Name = "cbUnderline";
            this.cbUnderline.Size = new System.Drawing.Size(93, 19);
            this.cbUnderline.TabIndex = 2;
            this.cbUnderline.Text = "Podkreślenie";
            this.cbUnderline.UseVisualStyleBackColor = true;
            // 
            // cbItalic
            // 
            this.cbItalic.AutoSize = true;
            this.cbItalic.Location = new System.Drawing.Point(6, 51);
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.Size = new System.Drawing.Size(84, 19);
            this.cbItalic.TabIndex = 1;
            this.cbItalic.Text = "Pochylenie";
            this.cbItalic.UseVisualStyleBackColor = true;
            // 
            // cbBold
            // 
            this.cbBold.AutoSize = true;
            this.cbBold.Location = new System.Drawing.Point(6, 25);
            this.cbBold.Name = "cbBold";
            this.cbBold.Size = new System.Drawing.Size(90, 19);
            this.cbBold.TabIndex = 0;
            this.cbBold.Text = "Pogrubienie";
            this.cbBold.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoOrange);
            this.groupBox3.Controls.Add(this.rdoBlue);
            this.groupBox3.Controls.Add(this.rdoRed);
            this.groupBox3.Location = new System.Drawing.Point(462, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 115);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kolor czcionki";
            // 
            // rdoOrange
            // 
            this.rdoOrange.AutoSize = true;
            this.rdoOrange.Location = new System.Drawing.Point(6, 74);
            this.rdoOrange.Name = "rdoOrange";
            this.rdoOrange.Size = new System.Drawing.Size(106, 19);
            this.rdoOrange.TabIndex = 2;
            this.rdoOrange.TabStop = true;
            this.rdoOrange.Text = "pomarańczowy";
            this.rdoOrange.UseVisualStyleBackColor = true;
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(6, 51);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(71, 19);
            this.rdoBlue.TabIndex = 1;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "niebieski";
            this.rdoBlue.UseVisualStyleBackColor = true;
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(6, 25);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(75, 19);
            this.rdoRed.TabIndex = 0;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "czerwony";
            this.rdoRed.UseVisualStyleBackColor = true;
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTekst.Location = new System.Drawing.Point(45, 23);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(117, 28);
            this.lblTekst.TabIndex = 3;
            this.lblTekst.Text = "Podaj tekst";
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbText.Location = new System.Drawing.Point(168, 26);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(474, 29);
            this.tbText.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(232, 204);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(203, 50);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Aktualizuj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 276);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoVBig;
        private System.Windows.Forms.RadioButton rdoBig;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbUnderline;
        private System.Windows.Forms.CheckBox cbItalic;
        private System.Windows.Forms.CheckBox cbBold;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rdoOrange;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoRed;
    }
}

