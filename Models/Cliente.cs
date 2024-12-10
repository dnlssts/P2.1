using System.ComponentModel.DataAnnotations;
namespace P2.Models
{
    public class Cliente
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "Código")]
        public string Codigo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Esse campo é obrigatório!!")]
        [StringLength(1000)]
        [Display(Name = "Nome completo")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Esse campo é obrigatório!!")]
        [StringLength(10)]
        [Display(Name = "Data de nascimento")]
        public string Datan { get; set; } = string.Empty;

        [Required(ErrorMessage = "Esse campo é obrigatório!!")]
        [StringLength(12)]
        [Display(Name = "RG")]
        public string RG { get; set; } = string.Empty;

        [Required(ErrorMessage = "Esse campo é obrigatório!!")]
        [StringLength(13)]
        [Display(Name = "CPF")]
        public string CPF { get; set; } = string.Empty;

        [Required(ErrorMessage = "Esse campo é obrigatório!!")]
        [StringLength(1000)]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; } = string.Empty;

        [Required(ErrorMessage = "Esse campo é obrigatório!!")]
        [StringLength(1000)]
        [Display(Name = "Bairro")]
        public string bairro { get; set; } = string.Empty;

        [Required(ErrorMessage = "Esse campo é obrigatório!!")]
        [StringLength(100)]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "Esse campo é obrigatório!!")]
        [StringLength(1000)]
        [Display(Name = "Complemento")]
        public string complemento { get; set; } = string.Empty;

        [Required(ErrorMessage = "Esse campo é obrigatório!!")]
        [StringLength(2)]
        [Display(Name = "UF")]
        public string UF { get; set; } = string.Empty;

        [Required(ErrorMessage = "Esse campo é obrigatório!!")]
        [StringLength(10)]
        [Display(Name = "Estado civil")]
        public string Estado_civil { get; set; } = string.Empty;

        [Required(ErrorMessage = "Esse campo é obrigatório!!")]
        [StringLength(100)]
        [Display(Name = "Nome do pai")]
        public string Nome_pai { get; set; } = string.Empty;

        [Required(ErrorMessage = "Esse campo é obrigatório!!")]
        [StringLength(100)]
        [Display(Name = "Nome da mãe")]
        public string Nome_mae { get; set; } = string.Empty;
    }
}
