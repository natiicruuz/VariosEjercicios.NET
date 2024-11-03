namespace Cliente
{
    partial class ReservaFrm
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
            titleLbl = new Label();
            sinCargadorChBx = new CheckBox();
            conCargadorChBx = new CheckBox();
            acceptBtn = new Button();
            resultTxt = new TextBox();
            resultLbl = new Label();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(62, 19);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(426, 38);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Sistema de Reserva de Parking";
            // 
            // sinCargadorChBx
            // 
            sinCargadorChBx.AutoSize = true;
            sinCargadorChBx.Location = new Point(75, 82);
            sinCargadorChBx.Name = "sinCargadorChBx";
            sinCargadorChBx.Size = new Size(117, 24);
            sinCargadorChBx.TabIndex = 1;
            sinCargadorChBx.Text = "Sin Cargador";
            sinCargadorChBx.UseVisualStyleBackColor = true;
            sinCargadorChBx.CheckedChanged += this.sinCargadorChBx_CheckedChanged;
            // 
            // conCargadorChBx
            // 
            conCargadorChBx.AutoSize = true;
            conCargadorChBx.Location = new Point(75, 124);
            conCargadorChBx.Name = "conCargadorChBx";
            conCargadorChBx.Size = new Size(123, 24);
            conCargadorChBx.TabIndex = 2;
            conCargadorChBx.Text = "Con Cargador";
            conCargadorChBx.UseVisualStyleBackColor = true;
            conCargadorChBx.CheckedChanged += this.conCargadorChBx_CheckedChanged;
            // 
            // acceptBtn
            // 
            acceptBtn.Location = new Point(348, 107);
            acceptBtn.Name = "acceptBtn";
            acceptBtn.Size = new Size(140, 41);
            acceptBtn.TabIndex = 3;
            acceptBtn.Text = "Aceptar";
            acceptBtn.UseVisualStyleBackColor = true;
            acceptBtn.Click += acceptBtn_Click;
            // 
            // resultTxt
            // 
            resultTxt.Location = new Point(75, 233);
            resultTxt.Name = "resultTxt";
            resultTxt.Size = new Size(413, 27);
            resultTxt.TabIndex = 4;
            // 
            // resultLbl
            // 
            resultLbl.AutoSize = true;
            resultLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultLbl.Location = new Point(75, 191);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(178, 25);
            resultLbl.TabIndex = 5;
            resultLbl.Text = "Estado de la Reserva:";
            // 
            // ReservaFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 305);
            Controls.Add(resultLbl);
            Controls.Add(resultTxt);
            Controls.Add(acceptBtn);
            Controls.Add(conCargadorChBx);
            Controls.Add(sinCargadorChBx);
            Controls.Add(titleLbl);
            Name = "ReservaFrm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private CheckBox sinCargadorChBx;
        private CheckBox conCargadorChBx;
        private Button acceptBtn;
        private TextBox resultTxt;
        private Label resultLbl;
    }
}
