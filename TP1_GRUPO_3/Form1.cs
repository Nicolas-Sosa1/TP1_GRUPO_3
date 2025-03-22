using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_3
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            FormEjercicio1 formEjercicio1 = new FormEjercicio1(this);
            formEjercicio1.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            FormEjercicio2 formEjercicio2 = new FormEjercicio2(this);
            formEjercicio2.Show();
        }

        private void btnEjercicico3_Click(object sender, EventArgs e)
        {
            FormEjercicio3 formEjercicio3 = new FormEjercicio3(this);
            formEjercicio3.Show();
        }
    }
}
