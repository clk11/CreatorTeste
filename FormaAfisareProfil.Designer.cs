namespace CreatorTeste
{
    partial class FormaAfisareProfil
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
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.NumeTB = new System.Windows.Forms.TextBox();
            this.ParolaTB = new System.Windows.Forms.TextBox();
            this.ListBoxDomenii = new System.Windows.Forms.ListBox();
            this.l3 = new System.Windows.Forms.Label();
            this.AfisareParolaLB = new System.Windows.Forms.PictureBox();
            this.ImagineProfilPB = new System.Windows.Forms.PictureBox();
            this.MesajLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AfisareParolaLB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagineProfilPB)).BeginInit();
            this.SuspendLayout();
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.04478F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.White;
            this.l2.Location = new System.Drawing.Point(8, 172);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(123, 33);
            this.l2.TabIndex = 0;
            this.l2.Text = "Parola : ";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.04478F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.Color.White;
            this.l1.Location = new System.Drawing.Point(16, 66);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(117, 33);
            this.l1.TabIndex = 0;
            this.l1.Text = "Nume : ";
            // 
            // NumeTB
            // 
            this.NumeTB.BackColor = System.Drawing.Color.Silver;
            this.NumeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeTB.ForeColor = System.Drawing.Color.White;
            this.NumeTB.Location = new System.Drawing.Point(116, 63);
            this.NumeTB.Name = "NumeTB";
            this.NumeTB.ReadOnly = true;
            this.NumeTB.Size = new System.Drawing.Size(293, 37);
            this.NumeTB.TabIndex = 0;
            // 
            // ParolaTB
            // 
            this.ParolaTB.BackColor = System.Drawing.Color.Silver;
            this.ParolaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParolaTB.ForeColor = System.Drawing.Color.White;
            this.ParolaTB.Location = new System.Drawing.Point(116, 172);
            this.ParolaTB.Name = "ParolaTB";
            this.ParolaTB.ReadOnly = true;
            this.ParolaTB.Size = new System.Drawing.Size(293, 37);
            this.ParolaTB.TabIndex = 1;
            // 
            // ListBoxDomenii
            // 
            this.ListBoxDomenii.BackColor = System.Drawing.Color.Silver;
            this.ListBoxDomenii.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxDomenii.ForeColor = System.Drawing.Color.White;
            this.ListBoxDomenii.FormattingEnabled = true;
            this.ListBoxDomenii.ItemHeight = 36;
            this.ListBoxDomenii.Location = new System.Drawing.Point(464, 247);
            this.ListBoxDomenii.Name = "ListBoxDomenii";
            this.ListBoxDomenii.Size = new System.Drawing.Size(315, 112);
            this.ListBoxDomenii.TabIndex = 3;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.ForeColor = System.Drawing.Color.White;
            this.l3.Location = new System.Drawing.Point(12, 276);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(410, 36);
            this.l3.TabIndex = 4;
            this.l3.Text = "Domeniile pe care le predati\r\n";
            // 
            // AfisareParolaLB
            // 
            this.AfisareParolaLB.Image = global::CreatorTeste.Properties.Resources.eye;
            this.AfisareParolaLB.Location = new System.Drawing.Point(421, 172);
            this.AfisareParolaLB.Name = "AfisareParolaLB";
            this.AfisareParolaLB.Size = new System.Drawing.Size(37, 34);
            this.AfisareParolaLB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AfisareParolaLB.TabIndex = 5;
            this.AfisareParolaLB.TabStop = false;
            this.AfisareParolaLB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AfisareParolaLB_MouseDown);
            this.AfisareParolaLB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AfisareParolaLB_MouseUp);
            // 
            // ImagineProfilPB
            // 
            this.ImagineProfilPB.Location = new System.Drawing.Point(464, 3);
            this.ImagineProfilPB.Name = "ImagineProfilPB";
            this.ImagineProfilPB.Size = new System.Drawing.Size(315, 238);
            this.ImagineProfilPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagineProfilPB.TabIndex = 1;
            this.ImagineProfilPB.TabStop = false;
            // 
            // MesajLB
            // 
            this.MesajLB.AutoSize = true;
            this.MesajLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesajLB.Location = new System.Drawing.Point(549, 62);
            this.MesajLB.Name = "MesajLB";
            this.MesajLB.Size = new System.Drawing.Size(157, 108);
            this.MesajLB.TabIndex = 6;
            this.MesajLB.Text = "Nu aveti o \r\nimagine \r\nde profil ";
            this.MesajLB.Visible = false;
            // 
            // FormaAfisareProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(780, 376);
            this.Controls.Add(this.MesajLB);
            this.Controls.Add(this.AfisareParolaLB);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.ListBoxDomenii);
            this.Controls.Add(this.ParolaTB);
            this.Controls.Add(this.NumeTB);
            this.Controls.Add(this.ImagineProfilPB);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.l2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaAfisareProfil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informatiile dumneavoastra";
            ((System.ComponentModel.ISupportInitialize)(this.AfisareParolaLB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagineProfilPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.PictureBox ImagineProfilPB;
        private System.Windows.Forms.TextBox NumeTB;
        private System.Windows.Forms.TextBox ParolaTB;
        private System.Windows.Forms.ListBox ListBoxDomenii;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.PictureBox AfisareParolaLB;
        private System.Windows.Forms.Label MesajLB;
    }
}