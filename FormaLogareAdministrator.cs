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
namespace CreatorTeste
{
    public partial class FormaLogareAdministrator : MaterialForm
    {
        public static t_Conturi cont { get; set; }
        public FormaLogareAdministrator()
        {
            InitializeComponent();
        }
        private void FormaLogareAdministrator_Load(object sender, EventArgs e)
        {
            #region Material Setup
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple600, MaterialSkin.Primary.Purple500, MaterialSkin.Primary.Purple500, MaterialSkin.Accent.Purple400, MaterialSkin.TextShade.WHITE);
            #endregion            
            this.InregistrareLB.Click += delegate { this.Hide();new FormaInregistrareAdministrator().ShowDialog(); this.Close(); };
            cont = new t_Conturi();
        }
        private void ButonLogare_Click(object sender, EventArgs e)
        {
            using (TesteDBEntities db = new TesteDBEntities())
            {
                if (this.NumeTB.Text.Trim().Length == 0 || this.ParolaTB.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Trebuie sa completati totul pentru a putea continua !","Atentie !",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    t_Conturi c = db.t_Conturi.FirstOrDefault(x => x.Nume == this.NumeTB.Text.Trim() && x.t_Parole.Parola == this.ParolaTB.Text.Trim());
                    cont = c;
                    if (c != null)
                    {
                        MessageBox.Show("V-ati logat cu succes !", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Hide();new FormaProfilAdministrator().ShowDialog();this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nu s-a gasit niciun cont care sa cuprinde informatiile respective !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                }
            }
        }
    }
}
