using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ChazovaSR.Sprint7.Project.V7
{
    public partial class FormAboutMe : Form
    {
        public FormAboutMe()
        {
            InitializeComponent();
        }

        private void buttonOK_CSR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
