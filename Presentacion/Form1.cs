using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;


namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Click += Form1_Click;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1_Click(null, EventArgs.Empty);
            txtUsuario_Enter(null, EventArgs.Empty);
            txtUsuario_Leave(null, EventArgs.Empty);
            txtContrase_Leave(null, EventArgs.Empty);





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnINICIO.TabIndex = 0;
            txtUsuario.TabIndex = 1;
            txtUsuario.TabIndex = 2;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (txtContrase.Text == "CONTRASEÑA")
            {
                txtContrase.Text = "";
                txtContrase.ForeColor = Color.DimGray;
                txtContrase.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DimGray;
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContrase_Leave(object sender, EventArgs e)
        {
            if (txtContrase.Text == "")
            {
                txtContrase.Text = "CONTRASEÑA";
                txtContrase.ForeColor = Color.Black;
                txtContrase.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;       
        }

        private void btnINICIO_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtContrase.Text != "CONTRASEÑA")
                {

                }
                else msgError("Debe ingresar su Contraseña");
            }
            else msgError("Debe ingresar su Usuario");


        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = " " + msg;
            lblErrorMessage.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

