using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale_DOTNET.Domain.Entities
{
    public class GrupoProduto : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }



        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AddCritical("O nome do GRUPO DE PRODUTO deve ser informado");
        }
    }
}
