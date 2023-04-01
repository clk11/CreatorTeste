using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Threading;
using System.IO;
namespace CreatorTeste
{
    public partial class FormaInregistrareAdministrator : MaterialForm
    {
        public static InformatiiCont cont { get; set; }    
        public bool defaultImage { get; set; }
        public string text { get; set; }
        public FormaInregistrareAdministrator()
        {
            InitializeComponent();
        }
        public void RefereshData()
        {
            using (TesteDBEntities db = new TesteDBEntities())
            {
                this.ListaDomeniiLCB.Items.Clear();
                foreach (var item in (db.t_Domenii.Select(x => x.Domeniu)).ToList())
                { this.ListaDomeniiLCB.Items.Add(item); }
                this.DomeniiCoB.DataSource = (db.t_Domenii.Select(x => x.Domeniu)).ToList(); this.DomeniiCoB.Text = string.Empty;
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public class InformatiiCont
        {
            #region Fields
            string _nume;
            string _parola;
            Image _imagine;
            #endregion
            #region Properties
            public string Nume { get { return this._nume; } set { if (value != null) { this._nume = value; } } }
            public string Parola { get { return this._parola; } set { if (value != null) { this._parola = value; } } }
            public Image Imagine { get { return this._imagine; } set { if (value != null) { this._imagine = value; } } }
            public List<string> Domenii = new List<string>();
            #endregion
            #region Constructors
            public InformatiiCont()
            {

            }
            //public InformatiiCont(string n, string p, Image img)
            //{
            //    this.Nume = n;
            //    this.Parola = p;
            //    this.Imagine = img;
            //}
            #endregion
        }
        private void Hide_Show(bool value)
        {
            this.specialGeometrical.StartTheAnimation();
            if (value == false)
            {
                this.ListaDomeniiLCB.Visible = true;
                this.TextDupaAnimatieLB.Visible = true;
                this.ButonInapoi.Visible = true;
                this.WarningQuestionMarkLB.Visible = false;
                this.checkBox.Visible = false;
            }
            else 
            { 
                this.ButonInapoi.Visible = false;
                this.ListaDomeniiLCB.Visible = false;
                this.TextDupaAnimatieLB.Visible = false;
                this.checkBox.Visible = true;
            }
            //labels
            this.l1.Visible = value; this.l2.Visible = value; this.l3.Visible = value; this.l4.Visible = value; this.l5.Visible = value; this.l6.Visible = value;
            //pictureBoxes
            this.ImagineProfilPB.Visible = value; this.pictureBox2.Visible = value; this.VizualizareProfilPB.Visible = value;
            //textBoxes
            this.NumeTB.Visible = value; this.ParolaTB.Visible = value; this.ParolaReintrodusaTB.Visible = value; this.DomeniiCoB.Visible = value;
            //One more verification for comboBox
            //Others
            this.ButonInregistrare.Visible = value;
            this.QuestionMarkLB.Visible = value;
        }
        private void FormaInregistrareAdministrator_Load(object sender, EventArgs e)
        {
            this.text = "In caz ca predati\nmai multe discipline\napasati\"?\"";
            cont = new InformatiiCont();
            this.defaultImage = true;
            #region Material Setup
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.Green500, MaterialSkin.Primary.Green500, MaterialSkin.Accent.LightGreen400, MaterialSkin.TextShade.WHITE);
            #endregion           
            #region Events      
            this.checkBox.MouseEnter += delegate { this.checkBox.Text = "NU predau niciun domeniu din cele afisate !"; };
            this.checkBox.MouseLeave += delegate { this.checkBox.Text = string.Empty; };
            this.checkBox.CheckedChanged += delegate
            {
                Action<bool> Method = delegate (bool value) { this.DomeniiCoB.Visible = value;this.QuestionMarkLB.Visible = value; };
                if (this.checkBox.Checked)
                {
                    Method(false);
                    this.DomeniiCoB.Text = string.Empty;
                    if (this.DomeniiCoB.Enabled == false)
                    {                        
                        this.DomeniiCoB.Enabled = true;
                        this.WarningQuestionMarkLB.Visible = false;
                    }
                    new FormaAdaugareDomeniiNoi().ShowDialog();
                    this.RefereshData();
                }
                else
                {
                    Method(true);
                }
            };
            this.WarningQuestionMarkLB.MouseEnter += delegate { this.MesajLB.Visible = true; this.MesajLB.Text = "Pentru acces\ntrebuie sa debifati\ncasutele selectate\nin sectiunea \"mai\nmulte discipline\" !"; };
            this.WarningQuestionMarkLB.MouseLeave += delegate { this.MesajLB.Visible = false; this.MesajLB.Text = this.text; };
            this.VizualizareProfilPB.Click += delegate { Verificare(false); };
            this.QuestionMarkLB.MouseEnter += delegate { this.MesajLB.Visible = true; };
            this.QuestionMarkLB.MouseLeave += delegate { this.MesajLB.Visible = false; };
            this.QuestionMarkLB.Click += delegate { this.Hide_Show(false); this.specialGeometrical.StartTheAnimation(); 
            };
            this.ButonInapoi.Click += delegate {this.checkBox.Checked = false; if (this.ListaDomeniiLCB.CheckedItems.Count != 0) { this.WarningQuestionMarkLB.Visible = true; this.DomeniiCoB.Enabled = false; this.DomeniiCoB.Text = string.Empty; } else {this.WarningQuestionMarkLB.Visible = false; this.DomeniiCoB.Enabled = true; };this.Hide_Show(true); this.specialGeometrical.StartTheAnimation(); };
            this.RefereshData();

            #endregion            
        }
        private void Verificare(bool value)
        {
            bool pass = false;
            if (this.checkBox.Checked == false)
            {
                if (this.DomeniiCoB.Text.Trim().Length != 0)
                {
                    bool verificareDomeniu;
                    using (TesteDBEntities db = new TesteDBEntities())
                    {
                        verificareDomeniu = db.t_Domenii.Any(x => x.Domeniu == this.DomeniiCoB.Text.Trim());
                    }
                    if (verificareDomeniu)
                    {
                        cont.Domenii.Clear();
                        cont.Domenii.Add(this.DomeniiCoB.Text.Trim());
                        pass = true;
                    }
                    else
                    {
                        MessageBox.Show("Domeniul pe care l-ati selectat nu exista !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (this.ListaDomeniiLCB.CheckedItems.Count != 0)
                {
                    pass = true;
                    cont.Domenii.Clear();
                    for (int i = 0; i < this.ListaDomeniiLCB.CheckedItems.Count; i++)
                    {
                        cont.Domenii.Add(this.ListaDomeniiLCB.CheckedItems[i].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Trebuie sa selectati domeniul/domeniile de specialitate !", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (cont.Domenii.Count != 0)
                {
                    pass = true;
                }
                else
                {
                    MessageBox.Show("Trebuie sa aveti cel putin un domeniu ca specializare !", "Atentie !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (pass)
            {
                bool verificareNume_1 = this.NumeTB.Text.Trim().Length == 0 ? false : true;
                bool verificareParola_1 = this.ParolaTB.Text.Trim().Length == 0 ? false : true;
                bool verificareParolaReintrodusa = this.ParolaTB.Text.Trim() == this.ParolaReintrodusaTB.Text.Trim() ? true : false;
                if (verificareNume_1 && verificareParola_1)
                {
                    if (verificareParolaReintrodusa)
                    {
                        using (TesteDBEntities db = new TesteDBEntities())
                        {
                            bool verificareNume_2 = db.t_Conturi.Any(x => x.Nume == this.NumeTB.Text.Trim());
                            if (verificareNume_2)
                            {
                                MessageBox.Show("Exista deja un utilizator care are numele introdus de dumneavoastra !", "Atentie !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (value)
                                {
                                    t_Conturi ContNou = new t_Conturi();
                                    bool verificareNume_3 = db.t_Conturi.Any(x => x.Nume == this.NumeTB.Text.Trim());
                                    if (verificareNume_3 == false) ContNou.Nume = this.NumeTB.Text.Trim();                                    
                                    bool verificareParola_2 = db.t_Parole.Any(x => x.Parola == this.ParolaTB.Text.Trim());
                                    if (verificareParola_2 == false)
                                    {
                                        db.t_Parole.Add(new t_Parole() { Parola = this.ParolaTB.Text.Trim() });
                                        db.SaveChanges();
                                    }
                                    ContNou.ID_Parola = (db.t_Parole.FirstOrDefault(x => x.Parola == this.ParolaTB.Text.Trim())).ID_Parola;
                                    if (this.defaultImage)
                                    {
                                        ContNou.ImagineProfil = null;
                                    }
                                    else
                                    {
                                        ContNou.ImagineProfil = FormaIntrebare.ConvertImageToBinary(this.ImagineProfilPB.Image);
                                    }
                                    db.t_Conturi.Add(ContNou);
                                    db.SaveChanges();
                                    for (int i = 0; i < cont.Domenii.Count; i++)
                                    {
                                        string dom = cont.Domenii[i];
                                        db.t_DomeniiAdministratori.Add(new t_DomeniiAdministratori()
                                        {
                                            ID_ContAdministrator = db.t_Conturi.FirstOrDefault(x => x.Nume == this.NumeTB.Text.Trim()).ID_Cont,
                                            ID_Domeniu = (db.t_Domenii.FirstOrDefault(x => x.Domeniu == dom)).ID_Domeniu
                                        });
                                        db.SaveChanges();
                                    }
                                    MessageBox.Show("Ati fost inregistrat cu succes !", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();new FormaLogareAdministrator().ShowDialog();this.Close();
                                }
                                else
                                {
                                    cont.Nume = this.NumeTB.Text.Trim();
                                    cont.Parola = this.ParolaTB.Text.Trim();
                                    if (this.defaultImage)
                                    {
                                        cont.Imagine = null;
                                    }
                                    else
                                    {
                                        cont.Imagine = this.ImagineProfilPB.Image;
                                    }
                                    new FormaAfisareProfil().ShowDialog();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parola reintrodusa este incorecta !", "Atentie !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Trebuie sa completati totul pentru a putea cotinua !","Atentie !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
        private void ButonInregistrare_Click(object sender, EventArgs e)
        {
            this.Verificare(true);
        }
        private void ImagineProfilPB_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.defaultImage = false;
                    this.ImagineProfilPB.ImageLocation = ofd.FileName;
                    cont.Imagine = this.ImagineProfilPB.Image;
                }
            }
        }       
    }
}
