using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cliente_versión_1
{
    public partial class Registro : Form
    {
        public delegate void DelegadoUsername(string rusername);
        public event DelegadoUsername eventousername;
        public delegate void DelegadoPassword(string rpassword);
        public event DelegadoPassword eventopassword;

        public Registro()
        {
            InitializeComponent();
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            this.eventousername(nombre.Text);
            this.eventopassword(contraseña.Text);
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            nombre.Clear();
            contraseña.Clear();
            this.Close();
        }
    }
}
