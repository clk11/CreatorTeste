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
using System.IO;
namespace CreatorTeste
{
    public partial class FormaProfilAdministrator : Form
    {
        public FormaProfilAdministrator()
        {
            //public TesteDBEntities db MyProperty { get; set; }
        InitializeComponent();
            //
            this.LogOffLabel.Click += delegate { this.Hide(); FormaLogareAdministrator frm = new FormaLogareAdministrator(); frm.ShowDialog(); };
            this.Qm1LB.MouseEnter += delegate { this.MesajToggle.Visible = true; };
            this.Qm1LB.MouseLeave += delegate { this.MesajToggle.Visible = false; };
            this.UpdateCtr();
        }
        private void UpdateCtr()
        {
            string[] V = File.ReadAllLines(FormaSetupTest.ReturnNotepadPath());
            if (V[2] == "Enabled") { this.StatusToggle.Checked = true; }
            this.StatusToggle.CheckedChanged += delegate
            {
                string[] L = File.ReadAllLines(FormaSetupTest.ReturnNotepadPath());
                if (this.StatusToggle.Checked)
                {
                    L[2] = "Enabled";
                }
                else
                {
                    L[2] = "Disabled";
                }
                File.WriteAllLines(FormaSetupTest.ReturnNotepadPath(), L);
            };
            using (TesteDBEntities db = new TesteDBEntities())
            {
                var rec = db.t_Conturi.FirstOrDefault(x => x.ID_Cont == FormaLogareAdministrator.cont.ID_Cont);
                if (rec.ImagineProfil != null)
                {
                    this.ImagineProfilPB.Image = FormaIntrebare.ConvertBinaryToImage(rec.ImagineProfil);
                    this.MesajLB.Visible = false;
                }
                else
                {
                    MesajLB.Visible = true;
                }
                this.NumeLB.Text = FormaLogareAdministrator.cont.Nume;
                for (int i = 0; i < ExtractUnique().Count; i++)
                {
                    this.ListaDomenii.Items.Add(ExtractUnique()[i]);
                }
            }            
        }       
        public static List<string> ExtractUnique()//t_DomeniiAdministratori
        {
            List<string> L = new List<string>();
            using (TesteDBEntities db = new TesteDBEntities())
            {
                foreach (var item in db.t_DomeniiAdministratori) 
                {
                    if (item.ID_ContAdministrator==FormaLogareAdministrator.cont.ID_Cont) 
                    { 
                        L.Add(item.t_Domenii.Domeniu); 
                    }
                }
            }
            return L;
        }                                      
        private void ImagineProfilPB_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (TesteDBEntities db = new TesteDBEntities())
                    {
                        if (MessageBox.Show("Sunteti sigura ca doriti sa schimbati imaginea de profil ? ", "Intrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.MesajLB.Visible = false;
                            this.ImagineProfilPB.ImageLocation = ofd.FileName;
                            t_Conturi con = db.t_Conturi.FirstOrDefault(x => x.ID_Cont == FormaLogareAdministrator.cont.ID_Cont);
                            MessageBox.Show("Imagine schimbata cu success !", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.ImagineProfil = FormaIntrebare.ConvertImageToBinary(this.ImagineProfilPB.Image);
                            db.SaveChanges();
                        }
                    }
                }
            }
        }
        private void SetupTestBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); new FormaSetupTest().ShowDialog(); this.Close();
        }
        private void StergereIntrebare_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaStergere_EditareIntrebare frm = new FormaStergere_EditareIntrebare();
            frm.ShowDialog();
            this.Close();
        }
        private void RezultateElevi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaVizualizareRezultate frm = new FormaVizualizareRezultate();
            frm.ShowDialog();
            this.Close();
        }
        private void AdaugareIntrebare_Click(object sender, EventArgs e)
        {
            FormaInformatiiIntreabare frm = new FormaInformatiiIntreabare();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
        private void ButonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
