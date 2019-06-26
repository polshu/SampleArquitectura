namespace Gestion.WindowsForm {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnPersonasGetAll = new System.Windows.Forms.Button();
            this.btnPersonasGetActivos = new System.Windows.Forms.Button();
            this.btnPersonasGetInactivos = new System.Windows.Forms.Button();
            this.txtPersonaOutput = new System.Windows.Forms.TextBox();
            this.txtPersonaId = new System.Windows.Forms.TextBox();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtPersonaOutput);
            this.groupBox1.Controls.Add(this.txtPersonaId);
            this.groupBox1.Controls.Add(this.btnGetById);
            this.groupBox1.Controls.Add(this.btnPersonasGetInactivos);
            this.groupBox1.Controls.Add(this.btnPersonasGetActivos);
            this.groupBox1.Controls.Add(this.btnPersonasGetAll);
            this.groupBox1.Controls.Add(this.dgvPersonas);
            this.groupBox1.Location = new System.Drawing.Point(14, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PersonasService";
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(6, 53);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(642, 245);
            this.dgvPersonas.TabIndex = 0;
            // 
            // btnPersonasGetAll
            // 
            this.btnPersonasGetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonasGetAll.Location = new System.Drawing.Point(6, 24);
            this.btnPersonasGetAll.Name = "btnPersonasGetAll";
            this.btnPersonasGetAll.Size = new System.Drawing.Size(210, 23);
            this.btnPersonasGetAll.TabIndex = 1;
            this.btnPersonasGetAll.Text = "GetAll";
            this.btnPersonasGetAll.UseVisualStyleBackColor = true;
            this.btnPersonasGetAll.Click += new System.EventHandler(this.btnPersonasGetAll_Click);
            // 
            // btnPersonasGetActivos
            // 
            this.btnPersonasGetActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonasGetActivos.Location = new System.Drawing.Point(222, 24);
            this.btnPersonasGetActivos.Name = "btnPersonasGetActivos";
            this.btnPersonasGetActivos.Size = new System.Drawing.Size(210, 23);
            this.btnPersonasGetActivos.TabIndex = 2;
            this.btnPersonasGetActivos.Text = "GetActivos";
            this.btnPersonasGetActivos.UseVisualStyleBackColor = true;
            this.btnPersonasGetActivos.Click += new System.EventHandler(this.btnPersonasGetActivos_Click);
            // 
            // btnPersonasGetInactivos
            // 
            this.btnPersonasGetInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonasGetInactivos.Location = new System.Drawing.Point(438, 24);
            this.btnPersonasGetInactivos.Name = "btnPersonasGetInactivos";
            this.btnPersonasGetInactivos.Size = new System.Drawing.Size(210, 23);
            this.btnPersonasGetInactivos.TabIndex = 3;
            this.btnPersonasGetInactivos.Text = "GetInactivos";
            this.btnPersonasGetInactivos.UseVisualStyleBackColor = true;
            this.btnPersonasGetInactivos.Click += new System.EventHandler(this.btnPersonasGetInactivos_Click);
            // 
            // txtPersonaOutput
            // 
            this.txtPersonaOutput.Location = new System.Drawing.Point(7, 334);
            this.txtPersonaOutput.Multiline = true;
            this.txtPersonaOutput.Name = "txtPersonaOutput";
            this.txtPersonaOutput.Size = new System.Drawing.Size(315, 83);
            this.txtPersonaOutput.TabIndex = 6;
            // 
            // txtPersonaId
            // 
            this.txtPersonaId.Location = new System.Drawing.Point(222, 306);
            this.txtPersonaId.MaxLength = 3;
            this.txtPersonaId.Name = "txtPersonaId";
            this.txtPersonaId.Size = new System.Drawing.Size(100, 20);
            this.txtPersonaId.TabIndex = 5;
            this.txtPersonaId.Text = "0";
            // 
            // btnGetById
            // 
            this.btnGetById.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetById.Location = new System.Drawing.Point(7, 304);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(209, 23);
            this.btnGetById.TabIndex = 4;
            this.btnGetById.Text = "GetById";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(437, 306);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(209, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(437, 333);
            this.txtNombre.MaxLength = 150;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(437, 359);
            this.txtEmail.MaxLength = 320;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(437, 385);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 10;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 459);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion.WindowsForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPersonasGetAll;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnPersonasGetInactivos;
        private System.Windows.Forms.Button btnPersonasGetActivos;
        private System.Windows.Forms.TextBox txtPersonaOutput;
        private System.Windows.Forms.TextBox txtPersonaId;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnInsert;
    }
}

