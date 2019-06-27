using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Gestion.Entities;

namespace Gestion.API.Models {
    public class ResponseDTO {
        public ResponseDTO() {
            NewId           = 0;
            Errores         = "";
        }

        public int NewId { get; set; }

        public string Errores { get; set; }
    }
}