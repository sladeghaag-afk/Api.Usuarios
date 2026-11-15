using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Usuarios.Domain.Entities
{
    public class Usuario
    {
       public string Id { get; set; } = string.Empty;
       
        public string Nome{ get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public Guid PerfilId { get; set; }

        #region  Relacionamentos

        public Perfil? Perfil { get; set; }
        

        #endregion



    }
}
