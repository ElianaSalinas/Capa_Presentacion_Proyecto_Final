using ProyectoLogin.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_Presentacion_Proyecto_Final
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txt_entrar_Click(object sender, EventArgs e)
        {
            
                {
                    string usuario = txt_nombre.Text;
                    string contraseña = txt_clave.Text;

                    MessageBox.Show("Entró al botón"); // 1️⃣ Verifica que el botón responde

                    UsuarioDAL usuarioDAL = new UsuarioDAL();

                    bool resultado = usuarioDAL.ValidarUsuario(usuario, contraseña);

                    MessageBox.Show("Resultado de ValidarUsuario: " + resultado); // 2️⃣ Muestra true o false

                    if (resultado)
                    {
                        MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        // Aquí puedes abrir otro formulario principal
                    }
                    else 
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            
    }
    }
}



