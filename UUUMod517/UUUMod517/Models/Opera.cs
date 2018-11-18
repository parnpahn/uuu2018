﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UUUMod517.Models
{
    public class Opera
    {
        [DisplayName("編號")]
        public int OperaID { get; set; }


        [Required(ErrorMessage ="歌劇名稱不得為空白")]
        [StringLength(200)]
        [DisplayName("")]
        public string Title { get; set; }

        [DisplayName("年代")]
        public int Year { get; set; }

        [Required]
        [DisplayName("作者")]
        public string Composer { get; set; }
    }
}