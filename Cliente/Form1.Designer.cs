namespace Cliente
{
    partial class Form1
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
            conProyectorChBx = new CheckBox();
            sinProyectorChBx = new CheckBox();
            AcceptBtn = new Button();
            resultTxt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(28, 20);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(579, 35);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Sistema de Reserva de Salas de Conferencias";
            titleLbl.Click += label1_Click;
            // 
            // conProyectorChBx
            // 
            conProyectorChBx.AutoSize = true;
            conProyectorChBx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            conProyectorChBx.Location = new Point(47, 106);
            conProyectorChBx.Name = "conProyectorChBx";
            conProyectorChBx.Size = new Size(159, 32);
            conProyectorChBx.TabIndex = 1;
            conProyectorChBx.Text = "Con Proyector";
            conProyectorChBx.UseVisualStyleBackColor = true;
            conProyectorChBx.CheckedChanged += conProyectorChBx_CheckedChanged;
            // 
            // sinProyectorChBx
            // 
            sinProyectorChBx.AutoSize = true;
            sinProyectorChBx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sinProyectorChBx.Location = new Point(224, 106);
            sinProyectorChBx.Name = "sinProyectorChBx";
            sinProyectorChBx.Size = new Size(151, 32);
            sinProyectorChBx.TabIndex = 2;
            sinProyectorChBx.Text = "Sin Proyector";
            sinProyectorChBx.UseVisualStyleBackColor = true;
            sinProyectorChBx.CheckedChanged += sinProyectorChBx_CheckedChanged;
            // 
            // AcceptBtn
            // 
            AcceptBtn.Location = new Point(385, 104);
            AcceptBtn.Name = "AcceptBtn";
            AcceptBtn.Size = new Size(191, 41);
            AcceptBtn.TabIndex = 3;
            AcceptBtn.Text = "Reservar";
            AcceptBtn.UseVisualStyleBackColor = true;
            AcceptBtn.Click += AcceptBtn_Click;
            // 
            // resultTxt
            // 
            resultTxt.Location = new Point(385, 211);
            resultTxt.Name = "resultTxt";
            resultTxt.Size = new Size(191, 27);
            resultTxt.TabIndex = 4;
            resultTxt.TextChanged += resultTxt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 211);
            label1.Name = "label1";
            label1.Size = new Size(295, 28);
            label1.TabIndex = 5;
            label1.Text = "Estado de la solicitud de reserva:";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 301);
            Controls.Add(label1);
            Controls.Add(resultTxt);
            Controls.Add(AcceptBtn);
            Controls.Add(sinProyectorChBx);
            Controls.Add(conProyectorChBx);
            Controls.Add(titleLbl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private CheckBox conProyectorChBx;
        private CheckBox sinProyectorChBx;
        private Button AcceptBtn;
        private TextBox resultTxt;
        private Label label1;
    }
}
