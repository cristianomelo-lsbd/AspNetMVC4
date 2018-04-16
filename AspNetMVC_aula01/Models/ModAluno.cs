using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; // it serves to use validation

namespace AspNetMVC_aula01.Models
{
    public class ModAluno
    {

        /*
        about display and regular expressions, please visit:
        codigoexpresso.com.br/Home/Postagem/27
        codigoexpresso.com.br/Home/Postagem/33
        */

        [Display(Name = "Student Code")]
        // Range( double minimum, double maximum, Named parameters... )
        [Range(minimum: 1, maximum: 50, ErrorMessage = "Student code must be between 1 and 50")]
        public int idAluno { get; set; }

        [Display(Name = "Student name")]
        [Required(ErrorMessage = "Blank space must be filled")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Field must be contain between 4 and 50")]
        public string nome { get; set; }

        [Display(Name = "Student email")]
        [Required(ErrorMessage = "Email space must be filled")]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage = "format email not valid")]
        public string email { get; set; }


        [Display(Name = "Data de Cadastro")] // label of field
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)] // show data in a correct way
        [DataBrasil(ErrorMessage = "Data inválida.", DataRequerida = true)] // =true means its obrigate to fill the field
        // the interrogation after DateTime (below) serves to indicate the field can be null
        public DateTime? DtCadastro { get; set; }

    }
}