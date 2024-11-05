namespace Cliente
{
    partial class ReservaPlazaClienteFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombreComprador = new Label();
            chkCargador = new CheckBox();
            txtNombreComprador = new TextBox();
            btnAceptar = new Button();
            lblRespuesta = new Label();
            txtBxPlazaAsignada = new TextBox();
            txtNumPlaza = new Label();
            txtBxError = new TextBox();
            txtError = new Label();
            SuspendLayout();
            // 
            // lblNombreComprador
            // 
            lblNombreComprador.AutoSize = true;
            lblNombreComprador.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreComprador.Location = new Point(20, 24);
            lblNombreComprador.Name = "lblNombreComprador";
            lblNombreComprador.Size = new Size(180, 20);
            lblNombreComprador.TabIndex = 0;
            lblNombreComprador.Text = "Nombre del Comprador:";
            // 
            // chkCargador
            // 
            chkCargador.AutoSize = true;
            chkCargador.Location = new Point(20, 109);
            chkCargador.Name = "chkCargador";
            chkCargador.Size = new Size(133, 24);
            chkCargador.TabIndex = 1;
            chkCargador.Text = "Tiene Cargador";
            chkCargador.UseVisualStyleBackColor = true;
            // 
            // txtNombreComprador
            // 
            txtNombreComprador.Location = new Point(20, 47);
            txtNombreComprador.Name = "txtNombreComprador";
            txtNombreComprador.Size = new Size(525, 27);
            txtNombreComprador.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(368, 100);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(181, 40);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRespuesta.Location = new Point(20, 149);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(85, 20);
            lblRespuesta.TabIndex = 4;
            lblRespuesta.Text = "Respuesta:";
            // 
            // txtBxPlazaAsignada
            // 
            txtBxPlazaAsignada.Location = new Point(24, 209);
            txtBxPlazaAsignada.Name = "txtBxPlazaAsignada";
            txtBxPlazaAsignada.Size = new Size(168, 27);
            txtBxPlazaAsignada.TabIndex = 5;
            // 
            // txtNumPlaza
            // 
            txtNumPlaza.AutoSize = true;
            txtNumPlaza.Location = new Point(20, 186);
            txtNumPlaza.Name = "txtNumPlaza";
            txtNumPlaza.Size = new Size(149, 20);
            txtNumPlaza.TabIndex = 6;
            txtNumPlaza.Text = "Num. Plaza Asignada";
            txtNumPlaza.TextAlign = ContentAlignment.TopRight;
            txtNumPlaza.Click += txtNumPlaza_Click;
            // 
            // txtBxError
            // 
            txtBxError.Location = new Point(24, 283);
            txtBxError.Name = "txtBxError";
            txtBxError.Size = new Size(525, 27);
            txtBxError.TabIndex = 7;
            // 
            // txtError
            // 
            txtError.AutoSize = true;
            txtError.Location = new Point(24, 260);
            txtError.Name = "txtError";
            txtError.Size = new Size(44, 20);
            txtError.TabIndex = 8;
            txtError.Text = "Error:";
            txtError.TextAlign = ContentAlignment.TopRight;
            // 
            // ReservaPlazaClienteFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 336);
            Controls.Add(txtError);
            Controls.Add(txtBxError);
            Controls.Add(txtNumPlaza);
            Controls.Add(txtBxPlazaAsignada);
            Controls.Add(lblRespuesta);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombreComprador);
            Controls.Add(chkCargador);
            Controls.Add(lblNombreComprador);
            Name = "ReservaPlazaClienteFrm";
            Text = "Form1";
            Load += ReservaPlazaClienteFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreComprador;
        private CheckBox chkCargador;
        private TextBox txtNombreComprador;
        private Button btnAceptar;
        private Label lblRespuesta;
        private TextBox txtBxPlazaAsignada;
        private Label txtNumPlaza;
        private TextBox txtBxError;
        private Label txtError;
    }
}
