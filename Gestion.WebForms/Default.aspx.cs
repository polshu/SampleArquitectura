using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.UI.HtmlControls;
using Gestion.Entities;
using Gestion.Services;

namespace Gestion.WebForms {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnInsertar_Click(object sender, EventArgs e) {
            Persona newPersona;
            int     intNewId;
            string  strErrores = "";

            newPersona = new Persona();
            newPersona.Nombre   = txtNombre.Text;
            newPersona.Email    = txtEmail.Text;
            newPersona.Activo   = chkActivo.Checked;
            //intNewId = PersonasService.Insert(newPersona);
            //intNewId = PersonasService.InsertScalar(newPersona);
            intNewId = PersonasService.InsertValid(newPersona, out strErrores);

            if (intNewId > 0) {
                litOutput.Text = "Se inserto el ID:" + intNewId.ToString();
            } else {
                litOutput.Text = "Errores: " + strErrores;
            }

            
        }

        protected void btnRefresh_Click(object sender, EventArgs e) {
            List<Persona> personasList;

            personasList = PersonasService.GetAll();
            repPersonas.DataSource = personasList;

            repPersonas.DataBind();
        }
    }
}