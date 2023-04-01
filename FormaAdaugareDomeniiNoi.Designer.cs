namespace CreatorTeste
{
    partial class FormaAdaugareDomeniiNoi
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
            this.ButonAdaugaDomeniu = new System.Windows.Forms.Button();
            this.ListaDomeniiLCB = new System.Windows.Forms.ListBox();
            this.DomeniuTB = new System.Windows.Forms.TextBox();
            this.ButonConfirmare = new System.Windows.Forms.Button();
            this.ButonCuratare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adaugati domeniu\\domeniile pe care le predati";
            // 
            // ButonAdaugaDomeniu
            // 
            this.ButonAdaugaDomeniu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonAdaugaDomeniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonAdaugaDomeniu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButonAdaugaDomeniu.Location = new System.Drawing.Point(12, 55);
            this.ButonAdaugaDomeniu.Name = "ButonAdaugaDomeniu";
            this.ButonAdaugaDomeniu.Size = new System.Drawing.Size(176, 61);
            this.ButonAdaugaDomeniu.TabIndex = 1;
            this.ButonAdaugaDomeniu.Text = "Adauga";
            this.ButonAdaugaDomeniu.UseVisualStyleBackColor = true;
            // 
            // ListaDomeniiLCB
            // 
            this.ListaDomeniiLCB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListaDomeniiLCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaDomeniiLCB.FormattingEnabled = true;
            this.ListaDomeniiLCB.ItemHeight = 25;
            this.ListaDomeniiLCB.Location = new System.Drawing.Point(0, 122);
            this.ListaDomeniiLCB.Name = "ListaDomeniiLCB";
            this.ListaDomeniiLCB.Size = new System.Drawing.Size(665, 204);
            this.ListaDomeniiLCB.TabIndex = 2;
            // 
            // DomeniuTB
            // 
            this.DomeniuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomeniuTB.Location = new System.Drawing.Point(220, 65);
            this.DomeniuTB.Name = "DomeniuTB";
            this.DomeniuTB.Size = new System.Drawing.Size(214, 38);
            this.DomeniuTB.TabIndex = 0;
            // 
            // ButonConfirmare
            // 
            this.ButonConfirmare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonConfirmare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonConfirmare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButonConfirmare.Location = new System.Drawing.Point(514, 280);
            this.ButonConfirmare.Name = "ButonConfirmare";
            this.ButonConfirmare.Size = new System.Drawing.Size(151, 46);
            this.ButonConfirmare.TabIndex = 1;
            this.ButonConfirmare.Text = "Confirmare";
            this.ButonConfirmare.UseVisualStyleBackColor = true;
            // 
            // ButonCuratare
            // 
            this.ButonCuratare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonCuratare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonCuratare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButonCuratare.Location = new System.Drawing.Point(440, 64);
            this.ButonCuratare.Name = "ButonCuratare";
            this.ButonCuratare.Size = new System.Drawing.Size(52, 43);
            this.ButonCuratare.TabIndex = 3;
            this.ButonCuratare.Text = "C";
            this.ButonCuratare.UseVisualStyleBackColor = true;
            // 
            // FormaAdaugareDomeniiNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 326);
            this.Controls.Add(this.ButonCuratare);
            this.Controls.Add(this.DomeniuTB);
            this.Controls.Add(this.ButonConfirmare);
            this.Controls.Add(this.ButonAdaugaDomeniu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaDomeniiLCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormaAdaugareDomeniiNoi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adaugare Domenii";
            this.Load += new System.EventHandler(this.FormaAdaugareDomeniiNoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButonAdaugaDomeniu;
        private System.Windows.Forms.ListBox ListaDomeniiLCB;
        private System.Windows.Forms.TextBox DomeniuTB;
        private System.Windows.Forms.Button ButonConfirmare;
        private System.Windows.Forms.Button ButonCuratare;
    }
}