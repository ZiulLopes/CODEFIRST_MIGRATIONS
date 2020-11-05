using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFIRST_MIGRATIONS.Model
{
    public class FILME
    {
        [Key]
        public int FILMEID { get; set; }
        
        [MaxLength(200)]
        [Column(TypeName ="varchar")]
        public string NOMEFILME { get; set; }

        [Required]
        public int ANOLANCAMENTO { get; set; }
    }
}
