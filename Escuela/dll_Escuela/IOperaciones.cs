using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_Escuela
{
    public interface IOperaciones
    {
        bool actualizar();
        bool agregar();
        DataTable buscarxId();
        DataTable consultar();
        bool eliminar();
    }
}
