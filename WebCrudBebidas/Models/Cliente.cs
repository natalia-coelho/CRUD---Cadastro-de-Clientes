using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCrudBebidas.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column ("Id")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("TipoPessoa")]
        [Display(Name = "Tipo Pessoa")]
        public string TipoPessoa { get; set; }

        [Column("Documento")]
        [Display(Name = "CPF/CNPJ")]
        public string Documento { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Column("TipoTelefone")]
        [Display(Name = "Tipo de Telefone")]
        public string TipoTelefone { get; set; }
        
        [Column("Endereco")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
                
        [Column("TipoEndereco")]
        [Display(Name = "Tipo de Endereço")]
        public string TipoEndereco { get; set; }

    }
}
