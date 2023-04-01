using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
namespace CreatorTeste
{
    public partial class FormaVizualizareRezultate : Form
    {
        public List<int> Rez = new List<int>();
        public int Poz = 0;
        public bool ReturnToDGV = false;
        public FormaVizualizareRezultate()
        {
            InitializeComponent();
        }              
        private void ButonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void UpdateDGV()
        {
            using (TesteDBEntities db = new TesteDBEntities())
            {
                int count = 0;
                foreach (var item in db.t_InformatiiRezultate)
                {
                    if (FormaProfilAdministrator.ExtractUnique().Contains((item.t_Capitole.t_Domenii.Domeniu)))
                    {
                        this.dataGridView.Rows.Add();
                        this.dataGridView.Rows[count].Cells[0].Value = item.ID_InformatiiRezultat;
                        this.dataGridView.Rows[count].Cells[1].Value = item.t_Conturi.Nume;
                        this.dataGridView.Rows[count].Cells[2].Value = item.t_Capitole.t_Domenii.Domeniu;
                        this.dataGridView.Rows[count].Cells[3].Value = item.t_Capitole.Capitol;
                        this.dataGridView.Rows[count].Cells[4].Value = item.Punctaj;
                        this.dataGridView.Rows[count].Cells[5].Value = item.Nivel;
                        this.dataGridView.Rows[count].Cells[6].Value = item.Data;
                        count++;
                    }
                }
            }
        }
        private void FormaVizualizareRezultate_Load(object sender, EventArgs e)
        {
            this.ButonUrmatoareIntrebare.Click += delegate { this.UrmatoareaIntrebare(); };
            this.ButonInapoiElevi.Click += delegate { this.Hide(); new FormaVizualizareRezultate().ShowDialog(); this.Close(); };
            using (TesteDBEntities db = new TesteDBEntities())
            {
                this.UpdateDGV();
            }
        }
        private void ButonInapoiLaProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormaProfilAdministrator().ShowDialog();
            this.Close();
        }
        #region InapoiEleviAnimation
        private void ButonInapoiElevi_MouseUp(object sender, MouseEventArgs e)
        {
            this.ButonInapoiElevi.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
        }
        private void ButonInapoiElevi_MouseDown(object sender, MouseEventArgs e)
        {
            this.ButonInapoiElevi.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
        }
        private void ButonInapoiElevi_MouseEnter(object sender, EventArgs e)
        {
            this.ButonInapoiElevi.BackColor = Color.Aqua;
        }
        private void ButonInapoiElevi_MouseLeave(object sender, EventArgs e)
        {
            this.ButonInapoiElevi.BackColor = ColorTranslator.FromHtml("#00c0c0");
        }
        #endregion
        public void SpecialGeometricalAnimation(Color clr)
        {
            SpecialGeometrical sp = new SpecialGeometrical(); this.Controls.Add(sp);
            sp.Dock = DockStyle.Fill; sp.specialPropr = true; sp.AnimationColor = clr; sp.StartTheAnimation();
        }
        private void UrmatoareaIntrebare()
        {
            using (TesteDBEntities db = new TesteDBEntities())
            {
                if (this.Poz != this.Rez.Count())
                {
                    #region Setup
                    var val = this.Rez[this.Poz];
                    t_IntrebariRezultate intr = (db.t_IntrebariRezultate.FirstOrDefault(x => x.ID_IntrebareRezultat == val));
                    //Intrebare
                    this.IntrebareTest.Text = intr.t_Intrebari.EnuntIntrebare;
                    //Variante
                    this.VariantaTest1.Text = intr.t_Intrebari.t_Variante.t_TexteVariante.TextVarianta;
                    this.VariantaTest2.Text = intr.t_Intrebari.t_Variante1.t_TexteVariante.TextVarianta;
                    this.VariantaTest3.Text = intr.t_Intrebari.t_Variante2.t_TexteVariante.TextVarianta;
                    this.VariantaTest4.Text = intr.t_Intrebari.t_Variante3.t_TexteVariante.TextVarianta;
                    //CheckBox-uri
                    this.checkBox1.Checked = intr.Raspuns1;
                    this.checkBox2.Checked = intr.Raspuns2;
                    this.checkBox3.Checked = intr.Raspuns3;
                    this.checkBox4.Checked = intr.Raspuns4;
                    //Rezultate
                    Action<bool, Label> GiveRes = delegate (bool verif, Label lbl) { if (verif) { lbl.Text = "corect"; lbl.ForeColor = Color.Green; } else { lbl.Text = "gresit"; lbl.ForeColor = Color.Red; } };
                    GiveRes(this.checkBox1.Checked == intr.t_Intrebari.t_Variante.Corecta, this.RezultatVarianta1);
                    GiveRes(this.checkBox2.Checked == intr.t_Intrebari.t_Variante1.Corecta, this.RezultatVarianta2);
                    GiveRes(this.checkBox3.Checked == intr.t_Intrebari.t_Variante2.Corecta, this.RezultatVarianta3);
                    GiveRes(this.checkBox4.Checked == intr.t_Intrebari.t_Variante3.Corecta, this.RezultatVarianta4);
                    //PictureBox
                    this.pictureBox.Image = FormaIntrebare.ConvertBinaryToImage(intr.t_Intrebari.Imagine);
                    #endregion
                    this.Poz++;
                }
                else
                {
                    MessageBox.Show("Gata intrebarile !!! :)");
                }
            }
        }
        private void ButonInapoiElevi_Click(object sender, EventArgs e)
        {
            this.SpecialGeometricalAnimation(Color.DarkTurquoise);
            this.UpdateDGV();
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                using (TesteDBEntities db = new TesteDBEntities())
                {
                    int id = int.Parse(this.dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    Rez = (db.t_Rezultate.Where(x => x.ID_InformatiiRezultat == id).Select(x => x.ID_IntrebareRezultat)).ToList();
                    this.UrmatoareaIntrebare();
                    this.SpecialGeometricalAnimation(Color.DarkTurquoise);
                    this.dataGridView.Hide();
                    this.ButonInapoiElevi.Visible=true;
                    this.MesajLbl.Text = "Rezultat " + this.dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.MesajLbl.Location = new Point(this.MesajLbl.Location.X + 40, this.MesajLbl.Location.Y);                    
                }
            }
        }   
    }
}