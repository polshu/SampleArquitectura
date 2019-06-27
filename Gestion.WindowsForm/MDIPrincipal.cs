using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.WindowsForm {
    public partial class MDIPrincipal : Form {

        public MDIPrincipal() {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e) {
            frmPersonas childForm = new frmPersonas();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e) {
            frmPersonasProxy childForm = new frmPersonasProxy();
            childForm.MdiParent = this;
            childForm.Show();
        }

       

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (Form childForm in MdiChildren) {
                childForm.Close();
            }
        }
    }
}
