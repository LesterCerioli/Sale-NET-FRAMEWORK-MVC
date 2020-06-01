using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale_DOTNET.Domain.Entities
{
    public class Pedido : Entity
    {

        public int Id { get; set; }
        public int UsuarioLojaId { get; set; }
        public virtual UsuarioLoja UsuarioLoja { get; set; }


        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
