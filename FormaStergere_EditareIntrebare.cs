using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CreatorTeste
{
    public partial class FormaStergere_EditareIntrebare : Form
    {
        public TesteDBEntities db { get; set; }
        public FormaStergere_EditareIntrebare()
        {
            InitializeComponent();
            //=====================            
        }
        private void ButonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormaStergereIntrebare_Load(object sender, EventArgs e)
        {
            this.db = new TesteDBEntities();
            List<t_Intrebari> Intr = new List<t_Intrebari>();
            var Intrebari = FormaProfilAdministrator.ExtractUnique();
            foreach (var item in db.t_Intrebari)
            {
                if (Intrebari.Contains(item.t_Capitole.t_Domenii.Domeniu) && !item.Stearsa)
                {
                    Intr.Add(item);
                }
            }
            if (Intr != null)
            {
                 this.tIntrebariBindingSource.DataSource = Intr;
            }
            this.UpdateazaDataGridView();
        }
        private void UpdateazaDataGridView()
        {
            for (int i = 0; i < this.dataGridView.Rows.Count; i++)
            {
                this.dataGridView.Rows[i].Cells[2].Value = (this.dataGridView.Rows[i].Cells[9].Value as t_Variante).t_TexteVariante.TextVarianta;
                this.dataGridView.Rows[i].Cells[3].Value = (this.dataGridView.Rows[i].Cells[10].Value as t_Variante).t_TexteVariante.TextVarianta;
                this.dataGridView.Rows[i].Cells[4].Value = (this.dataGridView.Rows[i].Cells[11].Value as t_Variante).t_TexteVariante.TextVarianta;
                this.dataGridView.Rows[i].Cells[5].Value = (this.dataGridView.Rows[i].Cells[12].Value as t_Variante).t_TexteVariante.TextVarianta;
                this.dataGridView.Rows[i].Cells[6].Value = (this.dataGridView.Rows[i].Cells[13].Value as t_Capitole).t_Domenii.Domeniu;
                this.dataGridView.Rows[i].Cells[7].Value = (this.dataGridView.Rows[i].Cells[13].Value as t_Capitole).Capitol;
                this.dataGridView.Rows[i].Cells[8].Value = (this.dataGridView.Rows[i].Cells[14].Value as t_Dificultati).Dificultate;
            }
        }
        private void ButonOK_Click(object sender, EventArgs e)
        {
            if (this.dataGridView.RowCount == 0)
            {
                MessageBox.Show("Nicio inregistrare gasita !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Sunteti sigur(a) ca doriti sa stergeti intrebarea respectiva ?", "Intrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.db.t_Intrebari.Attach(this.tIntrebariBindingSource.Current as t_Intrebari);
                    (this.tIntrebariBindingSource.Current as t_Intrebari).Stearsa = true;
                    this.tIntrebariBindingSource.RemoveCurrent();
                    this.db.SaveChanges();
                }
            }
        }
        private void ButonInapoiLaProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaProfilAdministrator frm = new FormaProfilAdministrator();
            frm.ShowDialog();
            this.Close();
        }
        private void ButonEditare_Click(object sender, EventArgs e)
        {
            if (this.tIntrebariBindingSource.Current as t_Intrebari != null)
            {
                this.db.Dispose();
                this.Hide();
                FormaEditareIntreabare frm = new FormaEditareIntreabare((this.tIntrebariBindingSource.Current as t_Intrebari));
                frm.ShowDialog();
                this.Close();
            } 
            else
            {
                MessageBox.Show("Nicio inregistrare gasita !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
    }
}
