using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFStudiiDeCaz.Model
{
    [Table("Business", Schema = "BazaDeDate")]
    public class ECommerce : Business
    {
        public string URL { get; set; }
    }
}
