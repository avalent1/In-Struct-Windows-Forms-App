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
    public partial class HelperFrm : Form
    {
        public HelperFrm()
        {
            InitializeComponent();
        }

        private void HelperFrm_Load(object sender, EventArgs e)
        {

        }

        public void postaviHelp(string stranica)
        {
            string appPutanja = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;
            string nazivFilea = @"Pomoc\In-Struct-Help.chm";
            string putanja = appPutanja + @"\" + nazivFilea;
            helpProvider1.HelpNamespace = putanja;
            helpProvider1.SetHelpKeyword(this, stranica);
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
        }
    }
}
