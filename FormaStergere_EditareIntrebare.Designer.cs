namespace CreatorTeste
{
    partial class FormaStergere_EditareIntrebare
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
            this.components = new System.ComponentModel.Container();
            this.ButonIesire = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ButonInapoiLaProfil = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButonEditare = new LollipopButton();
            this.ButonOK = new LollipopButton();
            this.tIntrebariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDIntrebareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enuntIntrebareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varianta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varianta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varianta3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varianta4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domeniu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capitol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dificultate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVarianteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVariante1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVariante2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVariante3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCapitoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDificultatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stearsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIntrebariBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButonIesire
            // 
            this.ButonIesire.AutoSize = true;
            this.ButonIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonIesire.ForeColor = System.Drawing.Color.Red;
            this.ButonIesire.Location = new System.Drawing.Point(1354, 0);
            this.ButonIesire.Name = "ButonIesire";
            this.ButonIesire.Size = new System.Drawing.Size(32, 31);
            this.ButonIesire.TabIndex = 0;
            this.ButonIesire.Text = "&X";
            this.ButonIesire.Click += new System.EventHandler(this.ButonIesire_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDIntrebareDataGridViewTextBoxColumn,
            this.enuntIntrebareDataGridViewTextBoxColumn,
            this.Varianta1,
            this.Varianta2,
            this.Varianta3,
            this.Varianta4,
            this.Domeniu,
            this.Capitol,
            this.Dificultate,
            this.tVarianteDataGridViewTextBoxColumn,
            this.tVariante1DataGridViewTextBoxColumn,
            this.tVariante2DataGridViewTextBoxColumn,
            this.tVariante3DataGridViewTextBoxColumn,
            this.tCapitoleDataGridViewTextBoxColumn,
            this.tDificultatiDataGridViewTextBoxColumn,
            this.Stearsa});
            this.dataGridView.DataSource = this.tIntrebariBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(123, 100);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1197, 546);
            this.dataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selectati intrebare pe care doriti sa o stergeti/editati";
            // 
            // ButonInapoiLaProfil
            // 
            this.ButonInapoiLaProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonInapoiLaProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonInapoiLaProfil.Location = new System.Drawing.Point(0, 0);
            this.ButonInapoiLaProfil.Name = "ButonInapoiLaProfil";
            this.ButonInapoiLaProfil.Size = new System.Drawing.Size(92, 35);
            this.ButonInapoiLaProfil.TabIndex = 4;
            this.ButonInapoiLaProfil.Text = "Inapoi";
            this.ButonInapoiLaProfil.UseVisualStyleBackColor = true;
            this.ButonInapoiLaProfil.Click += new System.EventHandler(this.ButonInapoiLaProfil_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "t_Variante3";
            this.dataGridViewTextBoxColumn1.HeaderText = "Stearsa";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // ButonEditare
            // 
            this.ButonEditare.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.26866F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonEditare.Location = new System.Drawing.Point(123, 670);
            this.ButonEditare.Name = "ButonEditare";
            this.ButonEditare.RobitaAniamtionColor = System.Drawing.Color.White;
            this.ButonEditare.RobitaBackColor = System.Drawing.Color.Orange;
            this.ButonEditare.Size = new System.Drawing.Size(252, 71);
            this.ButonEditare.TabIndex = 5;
            this.ButonEditare.Text = "Editeaza";
            this.ButonEditare.UseVisualStyleBackColor = true;
            this.ButonEditare.Click += new System.EventHandler(this.ButonEditare_Click);
            // 
            // ButonOK
            // 
            this.ButonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.26866F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonOK.Location = new System.Drawing.Point(1068, 671);
            this.ButonOK.Name = "ButonOK";
            this.ButonOK.RobitaAniamtionColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ButonOK.RobitaBackColor = System.Drawing.Color.Blue;
            this.ButonOK.Size = new System.Drawing.Size(252, 70);
            this.ButonOK.TabIndex = 3;
            this.ButonOK.Text = "Sterge";
            this.ButonOK.UseVisualStyleBackColor = true;
            this.ButonOK.Click += new System.EventHandler(this.ButonOK_Click);
            // 
            // tIntrebariBindingSource
            // 
            this.tIntrebariBindingSource.DataSource = typeof(CreatorTeste.t_Intrebari);
            // 
            // iDIntrebareDataGridViewTextBoxColumn
            // 
            this.iDIntrebareDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDIntrebareDataGridViewTextBoxColumn.DataPropertyName = "ID_Intrebare";
            this.iDIntrebareDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDIntrebareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDIntrebareDataGridViewTextBoxColumn.Name = "iDIntrebareDataGridViewTextBoxColumn";
            this.iDIntrebareDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDIntrebareDataGridViewTextBoxColumn.Width = 50;
            // 
            // enuntIntrebareDataGridViewTextBoxColumn
            // 
            this.enuntIntrebareDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.enuntIntrebareDataGridViewTextBoxColumn.DataPropertyName = "EnuntIntrebare";
            this.enuntIntrebareDataGridViewTextBoxColumn.HeaderText = "Intrebare";
            this.enuntIntrebareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enuntIntrebareDataGridViewTextBoxColumn.Name = "enuntIntrebareDataGridViewTextBoxColumn";
            this.enuntIntrebareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Varianta1
            // 
            this.Varianta1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Varianta1.HeaderText = "Varianta1";
            this.Varianta1.MinimumWidth = 6;
            this.Varianta1.Name = "Varianta1";
            this.Varianta1.ReadOnly = true;
            // 
            // Varianta2
            // 
            this.Varianta2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Varianta2.HeaderText = "Varianta2";
            this.Varianta2.MinimumWidth = 6;
            this.Varianta2.Name = "Varianta2";
            this.Varianta2.ReadOnly = true;
            // 
            // Varianta3
            // 
            this.Varianta3.HeaderText = "Varianta3";
            this.Varianta3.MinimumWidth = 6;
            this.Varianta3.Name = "Varianta3";
            this.Varianta3.ReadOnly = true;
            this.Varianta3.Width = 125;
            // 
            // Varianta4
            // 
            this.Varianta4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Varianta4.HeaderText = "Varianta4";
            this.Varianta4.MinimumWidth = 6;
            this.Varianta4.Name = "Varianta4";
            this.Varianta4.ReadOnly = true;
            // 
            // Domeniu
            // 
            this.Domeniu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Domeniu.HeaderText = "Domeniu";
            this.Domeniu.MinimumWidth = 6;
            this.Domeniu.Name = "Domeniu";
            this.Domeniu.ReadOnly = true;
            // 
            // Capitol
            // 
            this.Capitol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Capitol.HeaderText = "Capitol";
            this.Capitol.MinimumWidth = 6;
            this.Capitol.Name = "Capitol";
            this.Capitol.ReadOnly = true;
            // 
            // Dificultate
            // 
            this.Dificultate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dificultate.HeaderText = "Dificultate";
            this.Dificultate.MinimumWidth = 6;
            this.Dificultate.Name = "Dificultate";
            this.Dificultate.ReadOnly = true;
            // 
            // tVarianteDataGridViewTextBoxColumn
            // 
            this.tVarianteDataGridViewTextBoxColumn.DataPropertyName = "t_Variante";
            this.tVarianteDataGridViewTextBoxColumn.HeaderText = "t_Variante";
            this.tVarianteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tVarianteDataGridViewTextBoxColumn.Name = "tVarianteDataGridViewTextBoxColumn";
            this.tVarianteDataGridViewTextBoxColumn.ReadOnly = true;
            this.tVarianteDataGridViewTextBoxColumn.Visible = false;
            this.tVarianteDataGridViewTextBoxColumn.Width = 125;
            // 
            // tVariante1DataGridViewTextBoxColumn
            // 
            this.tVariante1DataGridViewTextBoxColumn.DataPropertyName = "t_Variante1";
            this.tVariante1DataGridViewTextBoxColumn.HeaderText = "t_Variante1";
            this.tVariante1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tVariante1DataGridViewTextBoxColumn.Name = "tVariante1DataGridViewTextBoxColumn";
            this.tVariante1DataGridViewTextBoxColumn.ReadOnly = true;
            this.tVariante1DataGridViewTextBoxColumn.Visible = false;
            this.tVariante1DataGridViewTextBoxColumn.Width = 125;
            // 
            // tVariante2DataGridViewTextBoxColumn
            // 
            this.tVariante2DataGridViewTextBoxColumn.DataPropertyName = "t_Variante2";
            this.tVariante2DataGridViewTextBoxColumn.HeaderText = "t_Variante2";
            this.tVariante2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tVariante2DataGridViewTextBoxColumn.Name = "tVariante2DataGridViewTextBoxColumn";
            this.tVariante2DataGridViewTextBoxColumn.ReadOnly = true;
            this.tVariante2DataGridViewTextBoxColumn.Visible = false;
            this.tVariante2DataGridViewTextBoxColumn.Width = 125;
            // 
            // tVariante3DataGridViewTextBoxColumn
            // 
            this.tVariante3DataGridViewTextBoxColumn.DataPropertyName = "t_Variante3";
            this.tVariante3DataGridViewTextBoxColumn.HeaderText = "t_Variante3";
            this.tVariante3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tVariante3DataGridViewTextBoxColumn.Name = "tVariante3DataGridViewTextBoxColumn";
            this.tVariante3DataGridViewTextBoxColumn.ReadOnly = true;
            this.tVariante3DataGridViewTextBoxColumn.Visible = false;
            this.tVariante3DataGridViewTextBoxColumn.Width = 125;
            // 
            // tCapitoleDataGridViewTextBoxColumn
            // 
            this.tCapitoleDataGridViewTextBoxColumn.DataPropertyName = "t_Capitole";
            this.tCapitoleDataGridViewTextBoxColumn.HeaderText = "t_Capitole";
            this.tCapitoleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCapitoleDataGridViewTextBoxColumn.Name = "tCapitoleDataGridViewTextBoxColumn";
            this.tCapitoleDataGridViewTextBoxColumn.ReadOnly = true;
            this.tCapitoleDataGridViewTextBoxColumn.Visible = false;
            this.tCapitoleDataGridViewTextBoxColumn.Width = 125;
            // 
            // tDificultatiDataGridViewTextBoxColumn
            // 
            this.tDificultatiDataGridViewTextBoxColumn.DataPropertyName = "t_Dificultati";
            this.tDificultatiDataGridViewTextBoxColumn.HeaderText = "t_Dificultati";
            this.tDificultatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tDificultatiDataGridViewTextBoxColumn.Name = "tDificultatiDataGridViewTextBoxColumn";
            this.tDificultatiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tDificultatiDataGridViewTextBoxColumn.Visible = false;
            this.tDificultatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // Stearsa
            // 
            this.Stearsa.DataPropertyName = "Stearsa";
            this.Stearsa.HeaderText = "Stearsa";
            this.Stearsa.MinimumWidth = 6;
            this.Stearsa.Name = "Stearsa";
            this.Stearsa.ReadOnly = true;
            this.Stearsa.Visible = false;
            this.Stearsa.Width = 125;
            // 
            // FormaStergere_EditareIntrebare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1392, 769);
            this.Controls.Add(this.ButonEditare);
            this.Controls.Add(this.ButonInapoiLaProfil);
            this.Controls.Add(this.ButonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ButonIesire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaStergere_EditareIntrebare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaStergereIntrebare";
            this.Load += new System.EventHandler(this.FormaStergereIntrebare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIntrebariBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ButonIesire;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private LollipopButton ButonOK;
        private System.Windows.Forms.BindingSource tIntrebariBindingSource;
        private System.Windows.Forms.Button ButonInapoiLaProfil;
        private LollipopButton ButonEditare;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDIntrebareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enuntIntrebareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varianta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varianta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varianta3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varianta4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domeniu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capitol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dificultate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tVarianteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tVariante1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tVariante2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tVariante3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCapitoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDificultatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stearsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}