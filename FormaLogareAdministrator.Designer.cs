namespace CreatorTeste
{
    partial class FormaLogareAdministrator
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
            this.label2 = new System.Windows.Forms.Label();
            this.NumeTB = new System.Windows.Forms.TextBox();
            this.ParolaTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.InregistrareLB = new System.Windows.Forms.Label();
            this.ButonLogare = new LollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(59, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(54, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola : ";
            // 
            // NumeTB
            // 
            this.NumeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeTB.Location = new System.Drawing.Point(197, 418);
            this.NumeTB.Name = "NumeTB";
            this.NumeTB.Size = new System.Drawing.Size(336, 30);
            this.NumeTB.TabIndex = 0;
            // 
            // ParolaTB
            // 
            this.ParolaTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParolaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParolaTB.Location = new System.Drawing.Point(197, 484);
            this.ParolaTB.Name = "ParolaTB";
            this.ParolaTB.PasswordChar = '*';
            this.ParolaTB.Size = new System.Drawing.Size(336, 30);
            this.ParolaTB.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Location = new System.Drawing.Point(197, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 3);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Fuchsia;
            this.panel2.Location = new System.Drawing.Point(197, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 3);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::CreatorTeste.Properties.Resources.login;
            this.pictureBox.Location = new System.Drawing.Point(145, 94);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(344, 246);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // InregistrareLB
            // 
            this.InregistrareLB.AutoSize = true;
            this.InregistrareLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InregistrareLB.Location = new System.Drawing.Point(12, 617);
            this.InregistrareLB.Name = "InregistrareLB";
            this.InregistrareLB.Size = new System.Drawing.Size(153, 29);
            this.InregistrareLB.TabIndex = 7;
            this.InregistrareLB.Text = "Inregistrare ?";
            // 
            // ButonLogare
            // 
            this.ButonLogare.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonLogare.Location = new System.Drawing.Point(457, 585);
            this.ButonLogare.Name = "ButonLogare";
            this.ButonLogare.RobitaAniamtionColor = System.Drawing.Color.White;
            this.ButonLogare.RobitaBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButonLogare.Size = new System.Drawing.Size(161, 55);
            this.ButonLogare.TabIndex = 2;
            this.ButonLogare.Text = "Logare";
            this.ButonLogare.UseVisualStyleBackColor = true;
            this.ButonLogare.Click += new System.EventHandler(this.ButonLogare_Click);
            // 
            // FormaLogareAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 652);
            this.Controls.Add(this.InregistrareLB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ParolaTB);
            this.Controls.Add(this.NumeTB);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.ButonLogare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaLogareAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logare";
            this.Load += new System.EventHandler(this.FormaLogareAdministrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private LollipopButton ButonLogare;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox NumeTB;
        private System.Windows.Forms.TextBox ParolaTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label InregistrareLB;
    }
}