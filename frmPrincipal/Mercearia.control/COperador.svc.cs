using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Mercearia.Model;

namespace Mercearia.control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "COperador" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select COperador.svc or COperador.svc.cs at the Solution Explorer and start debugging.
    public class COperador : ICOperador
    {
        public void Alterar(Operador oOperador)
        {
            oOperador.Alterar();
        }

        public void DoWork()
        {
        }

        public void Excluir(Operador oOperador)
        {
            oOperador.Excluir();
        }

        public void Incluir(Operador oOperador)
        {
            oOperador.Incluir();
        }

        public Operador Selecionar(int Cod_op)
        {
            return Operador.Selecionar(Cod_op);
        }

        public List<Operador> SelecionarTodos()
        {
            return Operador.SelecionarTodos();
        }
    }
}
