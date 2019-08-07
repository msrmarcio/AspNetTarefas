using System.ComponentModel.DataAnnotations;

namespace Impacta.MOD
{
    public class Editora
	{
        [Display(Name ="CÓDIGO DA EDITORA")]
		public int EditoraId { get; set; }
        [Display(Name ="RAZÃO SOCIAL")]
        [Required(ErrorMessage ="Razão social deve ser informada")]
		public string Nome { get; set; }
        [EmailAddress]
        [Required(ErrorMessage ="E-mail de contato não esta sendo informado")]
		public string Email { get; set; }
        [Required]
        public string Cnpj { get; set; }
        [Phone]
        public string Telefone { get; set; }

        public Endereco Endereco { get; set; }
    }
}

/*
 <div class="row">
        <div class="form-group col-md-4">
            <label for="campo1">Campo Um</label>
            <input type="text" class="form-control" id="campo1">
        </div>

        <div class="form-group col-md-4">
            <label for="campo2">Campo Dois</label>
            <input type="text" class="form-control" id="campo3">
        </div>

        <div class="form-group col-md-4">
            <label for="campo3">Campo Três</label>
            <input type="text" class="form-control" id="campo3">
        </div>
    </div>
    */
