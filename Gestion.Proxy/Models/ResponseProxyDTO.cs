using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Gestion.Entities;

namespace Gestion.Proxy.Models {
    public class ResponseProxyDTO {
        public ResponseProxyDTO() {
            NewId           = 0;
            Errores         = "";
        }

        public int NewId { get; set; }

        public string Errores { get; set; }
    }
}