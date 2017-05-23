using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod02_01.Models
{
   public class Opera
    {
        //[DisplayName("編號")]
        [Display(Name = "編號")]
        [Required]
        public int OperaID { get; set; }
        [DisplayName("歌劇名稱")]
        [Required(ErrorMessage = "歌劇名稱不可以為空白")]
        [StringLength(200)]
        public string Title { get; set; }
        [DisplayName("年代")]
        [CheckValidYear]
        public int? Year { get; set; }
        [DisplayName("作者")]
        [Required]
        public string Composer { get; set; }

    }
}
