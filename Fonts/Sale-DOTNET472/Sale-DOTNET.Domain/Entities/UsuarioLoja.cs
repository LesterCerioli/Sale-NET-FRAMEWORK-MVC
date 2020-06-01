using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale_DOTNET.Domain.Entities
{
    public class UsuarioLoja : Entity
    {
        
        //Usuário da Loja
        //Store user
                
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string NomeMeio { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool EhAdministrador { get; set; }


        //Usuário pode ter nenhum ou muitos pedidos
        //a user maybe have no or many requests
        public virtual ICollection<Pedido> Pedidos { get; set; }



        public override void Validate()
        {
            if (string.IsNullOrEmpty(PrimeiroNome))
                AddCritical("O primeiro nome deve ser informado");

            if (string.IsNullOrEmpty(NomeMeio))
                AddCritical("O nome do meio deve ser informado");

            if (string.IsNullOrEmpty(SobreNome))
                AddCritical("O sobrenome deve ser informado");
        }
    }
}
