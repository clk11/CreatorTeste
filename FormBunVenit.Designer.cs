namespace CreatorTeste
{
    partial class FormBunVenit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBunVenit));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButonInainte = new LollipopButton();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(33, 142);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1037, 366);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 47);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mesaj introductiv !!!";
            // 
            // ButonInainte
            // 
            this.ButonInainte.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButonInainte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonInainte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButonInainte.Location = new System.Drawing.Point(810, 512);
            this.ButonInainte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButonInainte.Name = "ButonInainte";
            this.ButonInainte.RobitaAniamtionColor = System.Drawing.Color.Empty;
            this.ButonInainte.RobitaBackColor = System.Drawing.Color.Empty;
            this.ButonInainte.Size = new System.Drawing.Size(271, 62);
            this.ButonInainte.TabIndex = 9;
            this.ButonInainte.Text = "INAINTE";
            this.ButonInainte.UseVisualStyleBackColor = false;
            // 
            // FormBunVenit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1092, 592);
            this.Controls.Add(this.ButonInainte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBunVenit";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bine ati venit la creatorul de intrebari !!!";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;      
        private System.Windows.Forms.Label label1;
        private LollipopButton ButonInainte;

    }
}