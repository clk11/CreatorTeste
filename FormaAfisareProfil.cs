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
    public partial class FormaAfisareProfil : Form
    {
        public char passChr { get; set; }
        public FormaAfisareProfil()
        {
            InitializeComponent();
            this.passChr = this.ParolaTB.PasswordChar;
            this.UpdateControls();
            this.ParolaTB.PasswordChar = '*';
        }
        private void UpdateControls()
        {
            this.NumeTB.Text = FormaInregistrareAdministrator.cont.Nume;
            this.ParolaTB.Text = FormaInregistrareAdministrator.cont.Parola;
            for (int i = 0; i < FormaInregistrareAdministrator.cont.Domenii.Count; i++)

            { this.ListBoxDomenii.Items.Add(FormaInregistrareAdministrator.cont.Domenii[i]); }
            
            if (FormaInregistrareAdministrator.cont.Imagine != null)
            {
                this.ImagineProfilPB.Image = FormaInregistrareAdministrator.cont.Imagine;
            }
            else
            {
                this.MesajLB.Visible = true;
            }
        }
        private void AfisareParolaLB_MouseDown(object sender, MouseEventArgs e)
        {
            this.ParolaTB.PasswordChar = passChr;
        }
        private void AfisareParolaLB_MouseUp(object sender, MouseEventArgs e)
        {
            this.ParolaTB.PasswordChar = '*';
        }
    }
}
