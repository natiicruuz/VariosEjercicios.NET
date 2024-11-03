namespace Cliente
{
    partial class ReservasAsientoFrm
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
            ventanaChBx = new CheckBox();
            pasilloChBx = new CheckBox();
            acceptBtn = new Button();
            respuestaTextBox = new TextBox();
            statusLbl = new Label();
            titleLbl = new Label();
            chooseSeatLbl = new Label();
            label1 = new Label();
            usuarioTextBox = new TextBox();
            SuspendLayout();
            // 
            // ventanaChBx
            // 
            ventanaChBx.AutoSize = true;
            ventanaChBx.Location = new Point(39, 111);
            ventanaChBx.Name = "ventanaChBx";
            ventanaChBx.Size = new Size(84, 24);
            ventanaChBx.TabIndex = 0;
            ventanaChBx.Text = "Ventana";
            ventanaChBx.UseVisualStyleBackColor = true;
            ventanaChBx.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pasilloChBx
            // 
            pasilloChBx.AutoSize = true;
            pasilloChBx.Location = new Point(261, 111);
            pasilloChBx.Name = "pasilloChBx";
            pasilloChBx.Size = new Size(73, 24);
            pasilloChBx.TabIndex = 1;
            pasilloChBx.Text = "Pasillo";
            pasilloChBx.UseVisualStyleBackColor = true;
            pasilloChBx.CheckedChanged += pasillo_CheckedChanged;
            // 
            // acceptBtn
            // 
            acceptBtn.Location = new Point(240, 152);
            acceptBtn.Name = "acceptBtn";
            acceptBtn.Size = new Size(94, 29);
            acceptBtn.TabIndex = 2;
            acceptBtn.Text = "Aceptar";
            acceptBtn.UseVisualStyleBackColor = true;
            acceptBtn.Click += acceptBtn_Click;
            // 
            // respuestaTextBox
            // 
            respuestaTextBox.Location = new Point(39, 347);
            respuestaTextBox.Name = "respuestaTextBox";
            respuestaTextBox.Size = new Size(295, 27);
            respuestaTextBox.TabIndex = 3;
            respuestaTextBox.TextChanged += statusTxtBx_TextChanged;
            // 
            // statusLbl
            // 
            statusLbl.AutoSize = true;
            statusLbl.Location = new Point(39, 307);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(147, 20);
            statusLbl.TabIndex = 4;
            statusLbl.Text = "Estado de tu Reserva";
            statusLbl.Click += label1_Click;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(12, 9);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(350, 28);
            titleLbl.TabIndex = 5;
            titleLbl.Text = "Reserva de Asientos en un Autobús";
            titleLbl.Click += label2_Click;
            // 
            // chooseSeatLbl
            // 
            chooseSeatLbl.AutoSize = true;
            chooseSeatLbl.Location = new Point(39, 73);
            chooseSeatLbl.Name = "chooseSeatLbl";
            chooseSeatLbl.Size = new Size(114, 20);
            chooseSeatLbl.TabIndex = 6;
            chooseSeatLbl.Text = "Elige tu asiento:";
            chooseSeatLbl.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 214);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 7;
            label1.Text = "Cual es tu nombre?";
            label1.Click += label1_Click_1;
            // 
            // usuarioTextBox
            // 
            usuarioTextBox.Location = new Point(39, 237);
            usuarioTextBox.Name = "usuarioTextBox";
            usuarioTextBox.Size = new Size(295, 27);
            usuarioTextBox.TabIndex = 8;
            usuarioTextBox.TextChanged += usuarioTextBox_TextChanged;
            // 
            // ReservasAsientoFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 399);
            Controls.Add(usuarioTextBox);
            Controls.Add(label1);
            Controls.Add(chooseSeatLbl);
            Controls.Add(titleLbl);
            Controls.Add(statusLbl);
            Controls.Add(respuestaTextBox);
            Controls.Add(acceptBtn);
            Controls.Add(pasilloChBx);
            Controls.Add(ventanaChBx);
            Name = "ReservasAsientoFrm";
            Text = "ReservasAsiento";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ventanaChBx;
        private CheckBox pasilloChBx;
        private Button acceptBtn;
        private TextBox respuestaTextBox;
        private Label statusLbl;
        private Label titleLbl;
        private Label chooseSeatLbl;
        private Label label1;
        private TextBox usuarioTextBox;
    }
}
