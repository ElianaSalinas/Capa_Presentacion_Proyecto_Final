using ProyectoLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
     class CN_Login

        {

            private UsuarioDAL usuarioDAL = new UsuarioDAL();
        // el fran paso por aqui
            public bool IniciarSesion(string nombreUsuario, string contraseña)
            {
                if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña))
                {
                    return false; // No se permite login con campos vacíos
                }

                return usuarioDAL.ValidarUsuario(nombreUsuario, contraseña);
            }
        }
    }


