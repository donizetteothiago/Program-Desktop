using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia.Model
{
    public partial class Tipo_produto
    {
        public void Incluir()
        {
            using (var odb = new DataClassesDataContext())
            {
                odb.Tipo_produtos.InsertOnSubmit(this);
                odb.SubmitChanges();
            }

        }

        public void Alterar()
        {
            using (var odb = new DataClassesDataContext())
            {
                odb.Tipo_produtos.Attach(this, true);
                odb.SubmitChanges();
            }
        }

        public void Excluir()
        {
            using (var odb = new DataClassesDataContext())
            {
                odb.Tipo_produtos.Attach(this);
                odb.Tipo_produtos.DeleteOnSubmit(this);
                odb.SubmitChanges();
            }
        }

        public static Tipo_produto Selecionar(int Cod_tipo)
        {
            using (var odb = new DataClassesDataContext())
            {
                return (from p in odb.Tipo_produtos where p.Cod_tipo == Cod_tipo select p).FirstOrDefault();
            }
        }

        public static List<Tipo_produto > SelecionarTodos()
        {
            using (var odb = new DataClassesDataContext())
            {
                return (from p in odb.Tipo_produtos orderby p.Cod_tipo select p).ToList();
            }
        }
    }
}
