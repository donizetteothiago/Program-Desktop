using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia.Model
{
    public partial class Operador
    {
        public void Incluir()
        {
            using (var odb = new DataClassesDataContext())
            {
                odb.Operadors.InsertOnSubmit(this);
                odb.SubmitChanges();
            }

        }

        public void Alterar()
        {
            using (var odb = new DataClassesDataContext())
            {
                odb.Operadors.Attach(this, true);
                odb.SubmitChanges();
            }
        }

        public void Excluir()
        {
            using (var odb = new DataClassesDataContext())
            {
                odb.Operadors.Attach(this);
                odb.Operadors.DeleteOnSubmit(this);
                odb.SubmitChanges();
            }
        }

        public static Operador Selecionar(int Cod_op)
        {
            using (var odb = new DataClassesDataContext())
            {
                return (from p in odb.Operadors where p.Cod_op == Cod_op select p).FirstOrDefault();
            }
        }

        public static List<Operador> SelecionarTodos()
        {
            using (var odb = new DataClassesDataContext())
            {
                return (from p in odb.Operadors orderby p.Nome select p).ToList();
            }
        }
    }
}
