using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CreatorTeste
{
    public partial class FormaEditareIntreabare : Form
    {
        public TesteDBEntities contextForDaC { get; set; }
        public FormaEditareIntreabare(t_Intrebari obj)
        {
            InitializeComponent();
            //======================
            this.contextForDaC = new TesteDBEntities();           
            this.tIntrebariBindingSource.DataSource = obj;
            this.UpdateTB();
        }
        private void ButonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ModificaIntrebarea()
        {
            using (TesteDBEntities dbT = new TesteDBEntities())
            {
                (this.tIntrebariBindingSource.Current as t_Intrebari).EnuntIntrebare = this.EnuntIntrebareTB.Text.Trim();
                (this.tIntrebariBindingSource.Current as t_Intrebari).ID_Varianta1 = (dbT.t_Variante.FirstOrDefault(x => x.t_TexteVariante.TextVarianta == this.Varianta1TB.Text.Trim() && x.Corecta == this.Varianta1CB.Checked)).ID_Varianta;
                (this.tIntrebariBindingSource.Current as t_Intrebari).ID_Varianta2 = (dbT.t_Variante.FirstOrDefault(x => x.t_TexteVariante.TextVarianta == this.Varianta2TB.Text.Trim() && x.Corecta == this.Varianta2CB.Checked)).ID_Varianta;
                (this.tIntrebariBindingSource.Current as t_Intrebari).ID_Varianta3 = (dbT.t_Variante.FirstOrDefault(x => x.t_TexteVariante.TextVarianta == this.Varianta3TB.Text.Trim() && x.Corecta == this.Varianta3CB.Checked)).ID_Varianta;
                (this.tIntrebariBindingSource.Current as t_Intrebari).ID_Varianta4 = (dbT.t_Variante.FirstOrDefault(x => x.t_TexteVariante.TextVarianta == this.Varianta4TB.Text.Trim() && x.Corecta == this.Varianta4CB.Checked)).ID_Varianta;
                if (this.check1.Checked == false && this.check2.Checked == false)
                {
                    (this.tIntrebariBindingSource.Current as t_Intrebari).ID_Capitol = (dbT.t_Capitole.FirstOrDefault(x => x.Capitol == this.CapitolCB.Text.Trim() && x.t_Domenii.Domeniu == this.DomeniuCB.Text.Trim())).ID_Capitol;
                }
                else if(this.check1.Checked)
                {
                    (this.tIntrebariBindingSource.Current as t_Intrebari).ID_Capitol = (dbT.t_Capitole.FirstOrDefault(x => x.Capitol == this.CapitolTB.Text.Trim() && x.t_Domenii.Domeniu == this.DomeniuTB.Text.Trim())).ID_Capitol;
                }else if (this.check2.Checked)
                {
                    (this.tIntrebariBindingSource.Current as t_Intrebari).ID_Capitol = (dbT.t_Capitole.FirstOrDefault(x => x.Capitol == this.CapitolTB.Text.Trim() && x.t_Domenii.Domeniu == this.DomeniuCB.Text.Trim())).ID_Capitol;
                }
                (this.tIntrebariBindingSource.Current as t_Intrebari).ID_Dificultate = (dbT.t_Dificultati.FirstOrDefault(x => x.Dificultate == this.DificultateCB.Text.Trim())).ID_Dificultate;
            }
        }
        private void ModificareParametrizata(string TB,bool CB)
        {
            using (TesteDBEntities db = new TesteDBEntities())
            {
                var verificaret_TextVar = db.t_TexteVariante.FirstOrDefault(x => x.TextVarianta == TB);
                if (verificaret_TextVar != null)
                {
                    var verificaret_Var = db.t_Variante.Any(x => x.t_TexteVariante.TextVarianta == TB && x.Corecta == CB);
                    if (!verificaret_Var)
                    {
                        db.t_Variante.Add(new t_Variante() { ID_TextVarianta = verificaret_TextVar.ID_TextVarianta, Corecta = CB });
                        db.SaveChanges();
                    }
                }
                else
                {
                    db.t_TexteVariante.Add(new t_TexteVariante() { TextVarianta = TB });
                    db.SaveChanges();
                    db.t_Variante.Add(new t_Variante() { ID_TextVarianta = (db.t_TexteVariante.FirstOrDefault(x => x.TextVarianta == TB)).ID_TextVarianta, Corecta = CB });
                    db.SaveChanges();
                }
            }
        }
        private void ModificareBazaDeDate()
        {
            this.ModificareParametrizata(this.Varianta1TB.Text.Trim(), this.Varianta1CB.Checked);
            this.ModificareParametrizata(this.Varianta2TB.Text.Trim(), this.Varianta2CB.Checked);
            this.ModificareParametrizata(this.Varianta3TB.Text.Trim(), this.Varianta3CB.Checked);
            this.ModificareParametrizata(this.Varianta4TB.Text.Trim(), this.Varianta4CB.Checked);
        }
        private void UpdateTB()
        {
            using (TesteDBEntities db = new TesteDBEntities())
            {
                this.Varianta1TB.Text = (this.tIntrebariBindingSource.Current as t_Intrebari).t_Variante.t_TexteVariante.TextVarianta;
                this.Varianta2TB.Text = (this.tIntrebariBindingSource.Current as t_Intrebari).t_Variante1.t_TexteVariante.TextVarianta;
                this.Varianta3TB.Text = (this.tIntrebariBindingSource.Current as t_Intrebari).t_Variante2.t_TexteVariante.TextVarianta;
                this.Varianta4TB.Text = (this.tIntrebariBindingSource.Current as t_Intrebari).t_Variante3.t_TexteVariante.TextVarianta;
                this.DomeniuCB.DataSource = FormaProfilAdministrator.ExtractUnique();
                this.DificultateCB.DataSource = db.t_Dificultati.Select(x => x.Dificultate).ToList();
                this.DificultateCB.Text = (this.tIntrebariBindingSource.Current as t_Intrebari).t_Dificultati.Dificultate;
                this.MesajLB.Text = "Bifati pentru o valoare \"custom\" \npentru Domeniu si Capitol";


                this.DomeniuCB.Text = (this.tIntrebariBindingSource.Current as t_Intrebari).t_Capitole.t_Domenii.Domeniu;
                this.CapitolCB.DataSource = this.contextForDaC.t_Capitole.Where(x => x.t_Domenii.Domeniu == this.DomeniuCB.Text.Trim()).Select(y => y.Capitol).ToList();
                this.CapitolCB.Text = (this.tIntrebariBindingSource.Current as t_Intrebari).t_Capitole.Capitol;
                this.DomeniuCB.TextChanged += delegate { this.CapitolCB.DataSource = this.contextForDaC.t_Capitole.Where(x => x.t_Domenii.Domeniu == this.DomeniuCB.Text.Trim()).Select(y => y.Capitol).ToList(); };                



                this.Varianta1CB.Checked = (this.tIntrebariBindingSource.Current as t_Intrebari).t_Variante.Corecta;
                this.Varianta2CB.Checked = (this.tIntrebariBindingSource.Current as t_Intrebari).t_Variante1.Corecta;
                this.Varianta3CB.Checked = (this.tIntrebariBindingSource.Current as t_Intrebari).t_Variante2.Corecta;
                this.Varianta4CB.Checked = (this.tIntrebariBindingSource.Current as t_Intrebari).t_Variante3.Corecta;     
            }
        }        
        private bool AnalizareExistentaCapitol_Domeniu()
        {
            bool GTG = false;
            using (TesteDBEntities db = new TesteDBEntities())
            {       
                if (this.EnuntIntrebareTB.Text.Trim().Length != 0 &&
                    this.Varianta1TB.Text.Trim().Length != 0 &&
                    this.Varianta2TB.Text.Trim().Length != 0 &&
                    this.Varianta3TB.Text.Trim().Length != 0 &&
                    this.Varianta4TB.Text.Trim().Length != 0 &&
                    this.DificultateCB.Text.Trim().Length != 0)
                {
                    if (this.Varianta1CB.Checked || this.Varianta2CB.Checked || this.Varianta3CB.Checked || this.Varianta4CB.Checked)
                    {
                        if (this.check1.Checked)
                        {
                            if (this.DomeniuTB.Text.Trim().Length != 0 && this.CapitolTB.Text.Trim().Length != 0)
                            {
                                bool verificareDomeniu = FormaProfilAdministrator.ExtractUnique().Contains(this.DomeniuTB.Text.Trim());
                                bool verificareCapitol = db.t_Capitole.Any(x => x.Capitol == this.CapitolTB.Text.Trim());
                                if (verificareDomeniu == false && verificareCapitol == false)
                                {
                                    GTG = true;
                                    db.t_Domenii.Add(new t_Domenii() { Domeniu = this.DomeniuTB.Text.Trim() });
                                    db.SaveChanges();
                                    db.t_DomeniiAdministratori.Add(new t_DomeniiAdministratori() { ID_ContAdministrator = FormaLogareAdministrator.cont.ID_Cont, ID_Domeniu = (db.t_Domenii.FirstOrDefault(x => x.Domeniu == this.DomeniuTB.Text.Trim())).ID_Domeniu });
                                    db.SaveChanges();
                                    db.t_Capitole.Add(new t_Capitole() { Capitol = this.CapitolTB.Text.Trim(), ID_Domeniu = (db.t_Domenii.FirstOrDefault(x => x.Domeniu == this.DomeniuTB.Text.Trim())).ID_Domeniu });
                                    db.SaveChanges();
                                }
                                else
                                {
                                    MessageBox.Show("Trebuie sa adaugati valori diferite de cele deja existente in baza de date .", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    GTG = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Trebuie sa completati totul pentru a putea continua !");
                                GTG = false;
                            }
                        }
                        else if (this.check2.Checked)
                        {
                            if (this.DomeniuCB.Text.Trim().Length != 0 && this.CapitolTB.Text.Trim().Length != 0)
                            {
                                bool verificareDomeniu = FormaProfilAdministrator.ExtractUnique().Contains(this.DomeniuCB.Text.Trim());
                                bool verificareCapitol = db.t_Capitole.Any(x => x.Capitol == this.CapitolTB.Text.Trim());
                                if (verificareDomeniu && verificareCapitol == false)
                                {
                                    GTG = true;
                                    db.t_Capitole.Add(new t_Capitole() { Capitol = this.CapitolTB.Text.Trim(), ID_Domeniu = (db.t_Domenii.FirstOrDefault(x => x.Domeniu == this.DomeniuCB.Text.Trim())).ID_Domeniu });
                                    db.SaveChanges();
                                }
                                else
                                {
                                    if (verificareCapitol)
                                    {
                                        MessageBox.Show("Trebuie sa adaugati un capitol diferit de unul deja existent .");
                                    }
                                    else if (verificareDomeniu == false)
                                    {
                                        MessageBox.Show("Trebuie sa adaugati un domeniu deja existent in baza de date .");
                                    }
                                    GTG = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Trebuie sa completati totul pentru a putea continua !");
                                GTG = false;
                            }
                        }
                        else if (this.check1.Checked == false && this.check2.Checked == false)
                        {
                            if (this.DomeniuCB.Text.Trim().Length != 0 && this.CapitolCB.Text.Trim().Length != 0)
                            {
                                bool verificareDomeniu = db.t_Domenii.Any(x => x.Domeniu == this.DomeniuCB.Text.Trim());
                                bool verificareCapitol = db.t_Capitole.Any(x => x.Capitol == this.CapitolCB.Text.Trim());
                                if (verificareDomeniu && verificareCapitol)
                                {
                                    GTG = true;
                                }
                                else
                                {
                                    MessageBox.Show("Valorile selectate nu sunt valide , va rugam reselectati .");
                                    GTG = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Trebuie sa completati totul pentru a putea continua !");
                                GTG = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Trebuie sa bifati cel putin o varianta corecta !");
                        GTG = false;
                    }
                    List<string> L = new List<string>() { this.Varianta1TB.Text.Trim(), this.Varianta2TB.Text.Trim(), this.Varianta3TB.Text.Trim(), this.Varianta4TB.Text.Trim() };
                    if (!(L.Distinct().Count() == L.Count()))
                    {
                        MessageBox.Show("Variantele trebuie sa fie diferite !");
                        GTG = false;
                    }
                    L.Clear(); L = null;
                    return GTG; 
                }
                else
                {
                    MessageBox.Show("Trebuie sa completati totul pentru a putea continua !");
                    return false;
                }
            }
        }        
        private void ButonSalvare_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteti sigur(a) ca doriti sa salvati continutul ?", "Intrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.AnalizareExistentaCapitol_Domeniu())
                {
                    using (TesteDBEntities db = new TesteDBEntities())
                    {
                        db.t_Intrebari.Attach(this.tIntrebariBindingSource.Current as t_Intrebari);
                        this.ModificareBazaDeDate();
                        this.ModificaIntrebarea();
                        db.Entry(this.tIntrebariBindingSource.Current as t_Intrebari).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    this.Hide();
                    FormaStergere_EditareIntrebare frm = new FormaStergere_EditareIntrebare();
                    frm.ShowDialog();
                    this.Close();
                }
            }                             
        }     
        private void QuesitonMarkLB_MouseEnter(object sender, EventArgs e)
        {
            this.MesajLB.Visible = true;
        }
        private void QuesitonMarkLB_MouseLeave(object sender, EventArgs e)
        {
            this.MesajLB.Visible = false;
        }
        private void FormaEditareIntreabare_Load(object sender, EventArgs e)
        {
            #region CheckBox pentru Domeniu
            this.check1.CheckedChanged += delegate
            {
                if (this.check1.Checked)
                {
                    this.check2.Enabled = false;
                    this.DomeniuCB.Visible = false;
                    this.DomeniuTB.Visible = true;
                    this.CapitolTB.Visible = true;
                    this.CapitolCB.Visible = false;
                }
                else
                {
                    this.check2.Enabled = true;
                    this.DomeniuCB.Visible = true;
                    this.DomeniuTB.Visible = false;
                    this.CapitolTB.Visible = false;
                    this.CapitolCB.Visible = true;
                }
            };
            #endregion
            #region CheckBox pentru Captiol
            this.check2.CheckedChanged += delegate
            {
                if (this.check2.Checked)
                {
                    this.check1.Enabled = false;
                    this.CapitolTB.Visible = true;
                    this.CapitolCB.Visible = false;
                }
                else
                {
                    this.check1.Enabled = true;
                    this.CapitolTB.Visible = false;
                    this.CapitolCB.Visible = true;
                }
            };
            #endregion                  
        }

        private void QuestionMarkLB2_MouseEnter(object sender, EventArgs e)
        {
            this.MesajLB.Text = "Bifati pentru o valoare \"custom\" \ndoar pentru Capitol";
            this.MesajLB.Visible = true;
        }

        private void QuestionMarkLB2_MouseLeave(object sender, EventArgs e)
        {
            this.MesajLB.Text = "Bifati pentru o valoare \"custom\" \npentru Domeniu si Capitol";
            this.MesajLB.Visible = false;
        }       
    }
}
