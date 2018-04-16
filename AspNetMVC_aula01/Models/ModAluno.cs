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

        // DISPLAY METHODS SERVES TO SHOW ON SCREEN A TEXT INSTEAD OF VARIABLE NAME
        [Display(Name = "Student Code")]
        // Range( double minimum, double maximum, Named parameters... )
        [Range(minimum: 1, maximum: 500, ErrorMessage = "Student code must be between 1 and 50")]
        [DisplayFormat(DataFormatString ="{0:N0}", ApplyFormatInEditMode =true)]
        [NumeroBrasil(PontoMilharPermitido =true, DecimalRequerido =false)]
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

        [Display(Name = "Valor do curso")]
        [Range(minimum:1.0,maximum:1000.00,ErrorMessage ="Valor do curso deve ser entre 1 real e 1000 reais")]
        // The display below serves to kep the standard format to show decimal (2 decimal houses), but
        // if you want to show 4 decimal houses, put {0:N4} 
        [DisplayFormat(DataFormatString ="{0:N}",ApplyFormatInEditMode = true)]
        [NumeroBrasil(ErrorMessage ="Valor inválido.", PontoMilharPermitido =true, DecimalRequerido =true)]
        public double? ValorCurso { get; set; }
    }
}