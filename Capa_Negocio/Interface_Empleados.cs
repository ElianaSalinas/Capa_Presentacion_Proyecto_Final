using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public interface Interface_Empleados
    {
        DataTable MostrarUsu();
        void InsertarUsu(string nombre, string telefono, string edad);
        void EditarUsu(int id, string nombre, string telefono, string edad);
        void EliminarUsu(int id);
    }
}