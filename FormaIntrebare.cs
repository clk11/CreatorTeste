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
using System.IO;
namespace CreatorTeste
{
    public partial class FormaIntrebare : MaterialForm
    {
        public Image img { get; set; }
        public FormaIntrebare()
        {
            InitializeComponent();
        }
        private void FormaIntrebare_Load(object sender, EventArgs e)
        {
            img = this.ImagineIntrebarePB.Image;
            #region MaterialSkin
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green700, MaterialSkin.Primary.Green600, MaterialSkin.Primary.Green500, MaterialSkin.Accent.Green400, MaterialSkin.TextShade.WHITE);
            #endregion
            //===
            #region Oglindire checkbox-uri
            this.Varianta1_TB.TextChanged += delegate { this.Varianta1_CB.Text = this.Varianta1_TB.Text.Trim(); };
            this.Varianta2_TB.TextChanged += delegate { this.Varianta2_CB.Text = this.Varianta2_TB.Text.Trim(); };
            this.Varianta3_TB.TextChanged += delegate { this.Varianta3_CB.Text = this.Varianta3_TB.Text.Trim(); };
            this.Varianta4_TB.TextChanged += delegate { this.Varianta4_CB.Text = this.Varianta4_TB.Text.Trim(); };
            #endregion
        }
        public static byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public static Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void OrganizeazaDateleDeIntrare(bool I,bool v1,bool v2,bool v3,bool v4,bool d,bool c,bool dif)
        {
            using (TesteDBEntities db = new TesteDBEntities())
            {
                if (I == false)
                {
                    t_TexteVariante VariantaNoua = null;
                    #region Adaugare data in cazul in care nu exista deja in baza de date
                    if (v1 == false)
                    {
                        if (!(db.t_TexteVariante.Any(x => x.TextVarianta == this.Varianta1_TB.Text.Trim())))
                        {
                            VariantaNoua = new t_TexteVariante() { TextVarianta = this.Varianta1_TB.Text.Trim() };
                            db.t_TexteVariante.Add(VariantaNoua);
                        }
                        else
                        {
                            VariantaNoua = db.t_TexteVariante.FirstOrDefault(x => x.TextVarianta == this.Varianta1_TB.Text.Trim());
                        }
                        db.t_Variante.Add(new t_Variante() { ID_TextVarianta = VariantaNoua.ID_TextVarianta, Corecta = this.Varianta1_CB.Checked });
                        db.SaveChanges();
                    }
                    if (v2 == false)
                    {
                        if (!(db.t_TexteVariante.Any(x => x.TextVarianta == this.Varianta2_TB.Text.Trim())))
                        {
                            VariantaNoua = new t_TexteVariante() { TextVarianta = this.Varianta2_TB.Text.Trim() };
                            db.t_TexteVariante.Add(VariantaNoua);
                        }
                        else
                        {
                            VariantaNoua = db.t_TexteVariante.FirstOrDefault(x => x.TextVarianta == this.Varianta2_TB.Text.Trim());
                        }
                        db.t_Variante.Add(new t_Variante() { ID_TextVarianta = VariantaNoua.ID_TextVarianta, Corecta = this.Varianta2_CB.Checked });
                        db.SaveChanges();
                    }
                    if (v3 == false)
                    {
                        if (!(db.t_TexteVariante.Any(x => x.TextVarianta == this.Varianta3_TB.Text.Trim())))
                        {
                            VariantaNoua = new t_TexteVariante() { TextVarianta = this.Varianta3_TB.Text.Trim() };
                            db.t_TexteVariante.Add(VariantaNoua);
                        }
                        else
                        {
                            VariantaNoua = db.t_TexteVariante.FirstOrDefault(x => x.TextVarianta == this.Varianta3_TB.Text.Trim());
                        }
                        db.t_Variante.Add(new t_Variante() { ID_TextVarianta = VariantaNoua.ID_TextVarianta, Corecta = this.Varianta3_CB.Checked });
                        db.SaveChanges();
                    }
                    if (v4 == false)
                    {
                        if (!(db.t_TexteVariante.Any(x => x.TextVarianta == this.Varianta4_TB.Text.Trim())))
                        {
                            VariantaNoua = new t_TexteVariante() { TextVarianta = this.Varianta4_TB.Text.Trim() };
                            db.t_TexteVariante.Add(VariantaNoua);
                        }
                        else
                        {
                            VariantaNoua = db.t_TexteVariante.FirstOrDefault(x => x.TextVarianta == this.Varianta4_TB.Text.Trim());
                        }
                        db.t_Variante.Add(new t_Variante() { ID_TextVarianta = VariantaNoua.ID_TextVarianta, Corecta = this.Varianta4_CB.Checked });
                        db.SaveChanges();
                    }
                    if (d == false)
                    {
                        db.t_Domenii.Add(new t_Domenii() { Domeniu = FormaInformatiiIntreabare.DomeniuSelectat });
                        db.SaveChanges();
                        db.t_DomeniiAdministratori.Add(new t_DomeniiAdministratori() { ID_ContAdministrator = FormaLogareAdministrator.cont.ID_Cont, ID_Domeniu = (db.t_Domenii.FirstOrDefault(x => x.Domeniu == FormaInformatiiIntreabare.DomeniuSelectat)).ID_Domeniu });
                        db.SaveChanges();
                    }
                    if (c == false)
                    {
                        db.t_Capitole.Add(new t_Capitole() { Capitol = FormaInformatiiIntreabare.CapitolSelectat, ID_Domeniu = (db.t_Domenii.FirstOrDefault(x => x.Domeniu == FormaInformatiiIntreabare.DomeniuSelectat)).ID_Domeniu });
                        db.SaveChanges();
                    }
                    if (dif == false)
                    {
                        db.t_Dificultati.Add(new t_Dificultati() { Dificultate = FormaInformatiiIntreabare.DificulatateSelectata });
                        db.SaveChanges();
                    }
                    #endregion                    
                    db.t_Intrebari.Add(new t_Intrebari()
                    {
                        EnuntIntrebare = this.EnuntIntrebare_TB.Text.Trim(),
                        ID_Varianta1 = (db.t_Variante.FirstOrDefault(x => x.t_TexteVariante.TextVarianta == this.Varianta1_TB.Text.Trim() && x.Corecta == this.Varianta1_CB.Checked).ID_Varianta),
                        ID_Varianta2 = (db.t_Variante.FirstOrDefault(x => x.t_TexteVariante.TextVarianta == this.Varianta2_TB.Text.Trim() && x.Corecta == this.Varianta2_CB.Checked).ID_Varianta),
                        ID_Varianta3 = (db.t_Variante.FirstOrDefault(x => x.t_TexteVariante.TextVarianta == this.Varianta3_TB.Text.Trim() && x.Corecta == this.Varianta3_CB.Checked).ID_Varianta),
                        ID_Varianta4 = (db.t_Variante.FirstOrDefault(x => x.t_TexteVariante.TextVarianta == this.Varianta4_TB.Text.Trim() && x.Corecta == this.Varianta4_CB.Checked).ID_Varianta),
                        ID_Capitol = (db.t_Capitole.FirstOrDefault(x => x.Capitol == FormaInformatiiIntreabare.CapitolSelectat && x.t_Domenii.Domeniu == FormaInformatiiIntreabare.DomeniuSelectat).ID_Capitol),
                        Imagine = ConvertImageToBinary(this.ImagineIntrebarePB.Image),
                        ID_Dificultate = (db.t_Dificultati.FirstOrDefault(x => x.Dificultate == FormaInformatiiIntreabare.DificulatateSelectata).ID_Dificultate),
                        Stearsa = false
                    });                 
                    db.SaveChanges();
                    this.ClearTBCB();
                }
                else
                {
                    MessageBox.Show("Nu puteti adauga doua intrebari identice !!!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void ClearTBCB()
        {
            #region AnimClear
            //this.Varianta1_CB.Checked = false;
            //this.Varianta2_CB.Checked = false;
            //this.Varianta3_CB.Checked = false;
            //this.Varianta4_CB.Checked = false;
            //this.EnuntIntrebare_TB.Text = string.Empty;
            //this.Varianta1_TB.Text = string.Empty;
            //this.Varianta2_TB.Text = string.Empty;
            //this.Varianta3_TB.Text = string.Empty;
            //this.Varianta4_TB.Text = string.Empty;
            //this.EnuntIntrebare_TB.Focus();
            //this.ImagineIntrebarePB.Size = new Size(77, 59);
            //this.ImagineIntrebarePB.Image = this.img;
            #endregion
            this.Hide();
            FormaIntrebare frm = new FormaIntrebare();
            frm.ShowDialog();
            this.Close();
        }
        private void ButonFinalizare_Click(object sender, EventArgs e)
        {
            bool verificare1 = true;
            bool verificare2 = false;
            //==
            if (this.EnuntIntrebare_TB.Text.Trim().Length == 0 || this.Varianta1_TB.Text.Trim().Length == 0 || this.Varianta2_TB.Text.Trim().Length == 0 || this.Varianta3_TB.Text.Trim().Length == 0 || this.Varianta4_TB.Text.Trim().Length == 0)
            {
                verificare1 = false;
            }
            if (this.Varianta1_CB.Checked == true || this.Varianta2_CB.Checked == true || this.Varianta3_CB.Checked == true || this.Varianta4_CB.Checked == true)
            {
                verificare2 = true;
            }            
            if (verificare1)
            {
                if (verificare2)
                {
                    using (TesteDBEntities db = new TesteDBEntities())
                    {
                        #region Cautare date de intrare in baza de date
                        bool VerificareEnunt = db.t_Intrebari.Any(x => x.EnuntIntrebare == this.EnuntIntrebare_TB.Text.Trim());
                        bool VerificareVarianta1 = db.t_Variante.Any(x => x.t_TexteVariante.TextVarianta == this.Varianta1_TB.Text.Trim() && x.Corecta == this.Varianta1_CB.Checked);
                        bool VerificareVarianta2 = db.t_Variante.Any(x => x.t_TexteVariante.TextVarianta == this.Varianta2_TB.Text.Trim() && x.Corecta == this.Varianta2_CB.Checked);
                        bool VerificareVarianta3 = db.t_Variante.Any(x => x.t_TexteVariante.TextVarianta == this.Varianta3_TB.Text.Trim() && x.Corecta == this.Varianta3_CB.Checked);
                        bool VerificareVarianta4 = db.t_Variante.Any(x => x.t_TexteVariante.TextVarianta == this.Varianta4_TB.Text.Trim() && x.Corecta == this.Varianta4_CB.Checked);
                        bool VerificareDomeniu = db.t_Domenii.Any(x => x.Domeniu == FormaInformatiiIntreabare.DomeniuSelectat);
                        bool VerificareCapitol = db.t_Capitole.Any(x => x.Capitol == FormaInformatiiIntreabare.CapitolSelectat);
                        bool VerificareDificulate = db.t_Dificultati.Any(x => x.Dificultate == FormaInformatiiIntreabare.DificulatateSelectata);
                        #endregion
                        this.OrganizeazaDateleDeIntrare(VerificareEnunt, VerificareVarianta1, VerificareVarianta2, VerificareVarianta3, VerificareVarianta4, VerificareDomeniu, VerificareCapitol, VerificareDificulate);

                    }
                }
                else
                {
                    MessageBox.Show("Trebuie sa bifati cel putin o varainta corecta !!!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Trebuie sa completati totul pentru a putea continua !!!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void InapoiLaProfilBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaProfilAdministrator frm = new FormaProfilAdministrator();
            frm.ShowDialog();
            this.Close();
        }
        private void ImagineIntrebarePB_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.ImagineIntrebarePB.ImageLocation = ofd.FileName;
                    if (this.ImagineIntrebarePB.Size.Height < 130)
                    {
                        this.ImagineIntrebarePB.Size = new Size(130, 80);
                    }
                }
            }
        }          
    }
}
