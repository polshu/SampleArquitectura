using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Gestion.Entities;
using Gestion.Proxy;
using Gestion.Proxy.Models;

namespace Gestion.WindowsForm {
    public partial class frmPersonasProxy : Form {
        public frmPersonasProxy() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void btnPersonasGetAll_Click(object sender, EventArgs e) {
            List<Persona> personasList;

            personasList = PersonasServiceProxy.GetAll();
            dgvPersonas.DataSource = personasList;
        }

        private void btnGetById_Click(object sender, EventArgs e) {
            Persona oPersona;
            int     intId;
            
            if (int.TryParse(txtPersonaId.Text, out intId)){
                oPersona = PersonasServiceProxy.GetById(intId);
                if (oPersona != null) {
                    txtPersonaOutput.Text = oPersona.ToString();
                } else {
                    txtPersonaOutput.Text = "No se encontro la Persona";
                }
                
            } else {
                txtPersonaOutput.Text = "-ERROR-";
            }
        }

        private void btnPersonasGetActivos_Click(object sender, EventArgs e) {
            List<Persona> personasList;
            
            personasList = PersonasServiceProxy.GetActivos();
            dgvPersonas.DataSource = personasList;
        }

        private void btnPersonasGetInactivos_Click(object sender, EventArgs e) {
            List<Persona> personasList;
            
            personasList = PersonasServiceProxy.GetInActivos();
            dgvPersonas.DataSource = personasList;
        }

        private void btnInsert_Click(object sender, EventArgs e) {
            Persona             newPersona;
            ResponseProxyDTO    responseDTO;
            string              strErrores = "";
            
            newPersona = new Persona();
            newPersona.Nombre   = txtNombre.Text;
            newPersona.Email    = txtEmail.Text;
            newPersona.Activo   = chkActivo.Checked;

            responseDTO = PersonasServiceProxy.Insert(newPersona);
            if (responseDTO.NewId > 0) {
                MessageBox.Show("Se inserto el ID:" + responseDTO.NewId.ToString());
            } else {
                MessageBox.Show("Errores: " + responseDTO.Errores);
            }
        }
    }
}
