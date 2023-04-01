using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CreatorTeste
{
    public partial class FormaAdaugareDomeniiNoi : Form
    {
        public FormaAdaugareDomeniiNoi()
        {
            InitializeComponent();            
        }
        private void FormaAdaugareDomeniiNoi_Load(object sender, EventArgs e)
        {
            this.ButonCuratare.Click += delegate { this.ListaDomeniiLCB.Items.Clear(); };
            this.ButonAdaugaDomeniu.Click += delegate {
                var L = new List<string>();
                foreach (string item in this.ListaDomeniiLCB.Items) L.Add(item);
                var verificare = L.Any(x => x == this.DomeniuTB.Text.Trim());
                if (this.DomeniuTB.Text.Trim().Length != 0 && verificare == false) 
                {
                    this.ListaDomeniiLCB.Items.Add(this.DomeniuTB.Text.Trim());
                    this.DomeniuTB.Clear();this.DomeniuTB.Focus();
                }
                else
                { 
                    MessageBox.Show("Trebuie adaugati un domeniu unic si valid !", "Atentie !", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }
            };
            this.ButonConfirmare.Click += delegate
            {
                if (this.ListaDomeniiLCB.Items.Count != 0)
                {
                    using (TesteDBEntities db = new TesteDBEntities())
                    {
                        if (MessageBox.Show("Sunteti sigur(a) ca doriti sa salvat modificarile ? Datele noi vor fi salvate in baza de date", "Atentie !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            FormaInregistrareAdministrator.cont.Domenii.Clear();
                            bool check = false;
                            for (int i = 0; i < this.ListaDomeniiLCB.Items.Count; i++)
                            {
                                string value = this.ListaDomeniiLCB.Items[i].ToString();
                                if (db.t_Domenii.Any(x => x.Domeniu == value)) 
                                {
                                    check = true;
                                    break;
                                }
                            }
                            if (!check) {
                                for (int i = 0; i < this.ListaDomeniiLCB.Items.Count; i++)
                                {                            
                                    db.t_Domenii.Add(new t_Domenii() { Domeniu = this.ListaDomeniiLCB.Items[i].ToString()});
                                    db.SaveChanges();
                                    FormaInregistrareAdministrator.cont.Domenii.Add(this.ListaDomeniiLCB.Items[i].ToString());
                                }
                                this.Close();
                            }
                            else { 
                                MessageBox.Show("Datele introduse se repeta , va rugam reintroduceti !", "Eroare !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                check = false;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Trebuie sa adaugati ceva inainte sa puteti continua !", "Atentie !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }
    }
}
