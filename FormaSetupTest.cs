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
    public partial class FormaSetupTest : MaterialSkin.Controls.MaterialForm
    {
        public static string path { get; set; }
        public FormaSetupTest()
        {
            InitializeComponent();
            //
        }
        public static string ReturnNotepadPath()
        {
            path = Application.StartupPath;
            string value = string.Empty;
            string[] V=path.Split('\\');
            for (int i = 0; i < V.Length-4; i++)
            {
                value = value + V[i]+"\\";
            }
            return value + "TestFormat.txt";
        }        
        private void FormaSetupTest_Load(object sender, EventArgs e)
        {
            this.InapoiLB.Click += delegate { this.Hide(); new FormaProfilAdministrator().ShowDialog(); this.Close(); };  
            string[] L = File.ReadAllLines(FormaSetupTest.ReturnNotepadPath());
            this.NumarIntrebariLB.Text = L[0];
            this.NumarMinuteLB.Text = L[1];
            this.StatusLB.Text = L[2];
        }
        private void ButonFinalizare_Click(object sender, EventArgs e)
        {
            if (this.NumarIntrebari.Value != 0 && this.NumarMinute.Value != 0)
            {
                StreamWriter sw = new StreamWriter(ReturnNotepadPath());
                sw.WriteLine(this.NumarIntrebari.Value.ToString());
                sw.WriteLine(this.NumarMinute.Value.ToString()); sw.WriteLine("Status");
                sw.Close();
                this.Hide(); new FormaProfilAdministrator().ShowDialog(); this.Close();
            }
            else
            {
                MessageBox.Show("Trebuie sa adaugati valori diferite de 0 !", "Atentie !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }       
    }
}
