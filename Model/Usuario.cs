using Perfius.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Perfius
{
    [Table("usuarios")]
    public class Usuario : BaseEntity
    {
        [Column("user")]
        public string User { get; set; }
        [Column("senha")]
        public string Senha { get; set; }
    }
}
