using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;
using capa_entidades;
using System.Data;

namespace capa_negocios
{
    public class N_users
    {

        D_users objd = new D_users();

        public DataTable N_user(E_users obje)
        {
            return objd.D_user(obje);
        }


    }
}
