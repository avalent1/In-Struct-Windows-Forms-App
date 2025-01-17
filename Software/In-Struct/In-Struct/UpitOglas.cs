using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_Struct
{
    public partial class UpitOglas : Form
    {
        public static bool moze = false;
        public UpitOglas()
        {
            InitializeComponent();
            PostaviHelp();
        }
        private void PostaviHelp()
        {
            string appPutanja = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;
            string nazivFilea = @"Pomoc\In-Struct-Help.chm";
            string putanja = appPutanja + @"\" + nazivFilea;
            string stranica = "Upit_o_oglasu.htm";
            helpProvider1.HelpNamespace = putanja;
            helpProvider1.SetHelpKeyword(this, stranica);
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
        }

        private void UpitOglas_Load(object sender, EventArgs e)
        {

        }

        private void odaberiBtn_Click(object sender, EventArgs e)
        {
            if (daBtn.Checked == true)
            {
                moze = true;
                this.Close();
            }
            else
            {
                moze = false;
                this.Close();
            }
        }
    }
}
