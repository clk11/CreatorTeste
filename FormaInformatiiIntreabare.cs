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
    public partial class FormaInformatiiIntreabare : Form
    {
        public static string DomeniuSelectat { get; set; }
        public string ValoarePentruDomeniu { get; set; }
        public bool FontGenerat { get; set; }
        public string ValoarePentruCapitol { get; set; }
        public static string CapitolSelectat { get; set; }
        public static string DificulatateSelectata { get; set; }
        public bool DomeniuCustom = false;        
        public TesteDBEntities db { get; set; }       
        public FormaInformatiiIntreabare()
        {
            InitializeComponent();
        }      
        private void ButonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.db.Dispose();
        }
        private void FormaInformatiiIntreabare_Load(object sender, EventArgs e)
        {
            this.db = new TesteDBEntities();
            this.ButonInapoi.Click += delegate { this.Hide(); new FormaProfilAdministrator().ShowDialog(); this.Close(); };
            this.DomeniiCB.DataSource = FormaProfilAdministrator.ExtractUnique(); this.DomeniiCB.Text = string.Empty;
            this.DomeniiCB.TextChanged += delegate { this.CapitoleCB.DataSource = this.db.t_Capitole.Where(x => x.t_Domenii.Domeniu == this.DomeniiCB.Text.Trim()).Select(y=>y.Capitol).ToList(); this.CapitoleCB.Enabled = true; this.CapitoleCB.Text = string.Empty; };
            this.DificultatiCB.DataSource = this.db.t_Dificultati.Select(x => x.Dificultate).ToList(); this.DificultatiCB.Enabled = true; this.DificultatiCB.Text = string.Empty;
        }
        private void ButonX_Click(object sender, EventArgs e)
        {
            if (this.ButonX.Text != "Back")
            {
                if (MessageBox.Show("Doriti sa adaugati un domeniu nou ? ", "Intrebare !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.specialGeometrical.StartTheAnimation();
                    this.DomeniuCustom = true;
                    this.DomeniuLB.Text = "Introduceti noul domeniu : ";
                    this.DomeniiCB.Visible = false; this.DomeniuTB.Visible = true;
                    this.DomeniuTB.TextChanged += delegate { this.DomeniiCB.Text = this.DomeniuTB.Text.Trim(); };//This should be improved using the asignment of the variable
                }
                else
                {
                    this.specialGeometrical.StartTheAnimation();
                }
                if (this.FontGenerat == false)
                {
                    this.FontGenerat = true;
                    this.DomeniuTB.Text = string.Empty; this.CapitoleTB.Text = string.Empty; this.DomeniiCB.Text = string.Empty;
                    this.ButonX.Font = new Font("Microsoft Sans Serif", 20.11F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    this.ButonX.Location = new Point(this.ButonX.Location.X, this.ButonX.Location.Y + 18);
                    this.ButonInainte.Location = new Point(this.ButonInainte.Location.X, this.ButonInainte.Location.Y - 50);
                    this.MesajLB.Text = "Te-ai razgandit ? Apasa \"Back\"";
                    this.ButonX.Text = "Back";
                    this.ButonInainte.Text = "Salveaza";
                    this.CapitolLB.Text = "Introduceti noul capitol : ";
                    this.CapitoleCB.Visible = false; this.CapitoleTB.Visible = true;
                    this.DificultateLB.Visible = false; this.DificultatiCB.Visible = false;
                }
            }
            else
            {
                if (MessageBox.Show("Toate informatiile adaugate pana in momentul actual vor fi sterse , sunteti sigur(a) ?", "Atentie!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.EditeazaForma();
                    
                    this.DomeniiCB.Text = string.Empty; this.CapitoleCB.Text = string.Empty; this.DificultatiCB.Text = string.Empty;
                }
            }
        }
        private void EditeazaForma()
        {
            this.FontGenerat = false;
            this.specialGeometrical.StartTheAnimation();
            this.ButonInainte.Text = "INAINTE";
            this.ButonX.Font = new Font("Microsoft Sans Serif", 48.11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButonX.Text = "+";
            this.ButonX.Location = new Point(this.ButonX.Location.X, this.ButonX.Location.Y - 18);            
            this.ButonInainte.Location = new Point(this.ButonInainte.Location.X, this.ButonInainte.Location.Y + 50);
            this.MesajLB.Text = "Creeaza noi capitole sau domenii  !!!";
            //Visual Editing
            if (this.DomeniuCustom)
            {
                this.DomeniuCustom = false;
                this.DomeniuLB.Text = "Introduceti domeniul testului :";
                this.DomeniiCB.Visible = true; this.DomeniuTB.Visible = false;
            }
            this.CapitolLB.Text = "Introduceti capitolul testului :";            
            this.CapitoleCB.Text = this.CapitoleTB.Text.Trim();
            this.CapitoleCB.Visible = true; this.CapitoleTB.Visible = false;
            this.DificultateLB.Visible = true; this.DificultatiCB.Visible = true;           
        }
        private void ButonInainte_Click(object sender, EventArgs e)
        {
            if (this.ButonInainte.Text == "INAINTE")
            {    
                if (this.DomeniiCB.Text.Trim().Length != 0 && this.CapitoleCB.Text.Trim().Length != 0 && this.DificultatiCB.Text.Trim().Length != 0)
                {
                    this.VerificareValori();
                }
                else
                {
                    MessageBox.Show("Trebuie completati totul pentru a putea continua !!!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (this.ButonInainte.Text == "Salveaza") 
            {
                if (MessageBox.Show("Sunteti sigur(a) ca doriti sa salvati informatiile adaugate ?", "Intrebare !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool verificare1 = false;
                    bool verificareCazIdentice;
                    if (this.DomeniuCustom)
                    {
                        if (!this.DomeniiCB.Items.Contains(this.DomeniiCB.Text.Trim()))
                        {
                            verificare1 = true;
                        }
                        verificareCazIdentice = this.DomeniuTB.Text.Trim() == this.CapitoleTB.Text.Trim() ? true : false;
                    }
                    else
                    {
                        if (this.DomeniiCB.Items.Contains(this.DomeniiCB.Text.Trim()))
                        {
                            verificare1 = true;
                        }
                        verificareCazIdentice = this.DomeniiCB.Text.Trim() == this.CapitoleTB.Text.Trim() ? true : false;
                    } 
                    bool verificare2 = db.t_Capitole.Any(x => x.Capitol == this.CapitoleTB.Text.Trim());                                                
                    if (verificare1==true&&verificare2==false&&verificareCazIdentice==false) 
                    {
                        this.ValoarePentruDomeniu = this.DomeniiCB.Text.Trim();
                        this.ValoarePentruCapitol = this.CapitoleTB.Text.Trim();                        
                        this.EditeazaForma();
                    }
                    else
                    {
                        MessageBox.Show("Valorile introduse nu sunt valide :(", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);                                              
                    }
                }                              
            }
        }
        private void VerificareValori()
        {
            #region Verificari
            bool verificare1 = false; bool verificare2 = false; bool verificare3 = false;
            if (this.DomeniiCB.Items.Contains(this.DomeniiCB.Text.Trim()) || this.DomeniiCB.Text.Trim() == this.ValoarePentruDomeniu) 
            {
                verificare1 = true;
            }           
            if (this.CapitoleCB.Items.Contains(this.CapitoleCB.Text.Trim()) || this.CapitoleCB.Text.Trim() == this.ValoarePentruCapitol)
            {
                verificare2 = true;
            }
            if (this.DificultatiCB.Items.Contains(this.DificultatiCB.Text.Trim()))
            {
                verificare3 = true;
            }
            #endregion
            if (verificare1 == true && verificare2 == true && verificare3 == true)
            {
                DomeniuSelectat = this.DomeniiCB.Text.Trim();
                CapitolSelectat = this.CapitoleCB.Text.Trim();
                DificulatateSelectata = this.DificultatiCB.Text.Trim();
                this.Hide();
                FormaIntrebare frm = new FormaIntrebare();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Din pacate informatiile introduse nu sunt valide :(","Eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }   
    }
}
