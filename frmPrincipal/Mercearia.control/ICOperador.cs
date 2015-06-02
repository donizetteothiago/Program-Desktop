using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Mercearia.Model;

namespace Mercearia.control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICOperador" in both code and config file together.
    [ServiceContract]
    public interface ICOperador
    {
        [OperationContract]
         void Incluir(Operador oOperador);

        [OperationContract]
         void Alterar(Operador oOperador);

        [OperationContract]
         void Excluir(Operador oOperador);

        [OperationContract]
          Operador Selecionar(int Cod_op);

        [OperationContract]
         List<Operador> SelecionarTodos();
    }
}
