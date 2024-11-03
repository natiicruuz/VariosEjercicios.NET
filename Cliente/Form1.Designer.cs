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
            Titlelbl = new Label();
            NormalBikeChBx = new CheckBox();
            ElectricBikeChBx = new CheckBox();
            SelectTypeLbl = new Label();
            label2 = new Label();
            statusResponseTxt = new TextBox();
            responseLbl = new Label();
            AcceptBtn = new Button();
            SuspendLayout();
            // 
            // Titlelbl
            // 
            Titlelbl.AutoSize = true;
            Titlelbl.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Titlelbl.Location = new Point(12, 9);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(372, 31);
            Titlelbl.TabIndex = 0;
            Titlelbl.Text = "Sistema de Reservas de Bicicletas";
            Titlelbl.Click += label1_Click;
            // 
            // NormalBikeChBx
            // 
            NormalBikeChBx.AutoSize = true;
            NormalBikeChBx.Location = new Point(272, 142);
            NormalBikeChBx.Name = "NormalBikeChBx";
            NormalBikeChBx.Size = new Size(113, 24);
            NormalBikeChBx.TabIndex = 1;
            NormalBikeChBx.Text = "Normal Bike";
            NormalBikeChBx.UseVisualStyleBackColor = true;
            NormalBikeChBx.CheckedChanged += NormalBikeChBx_CheckedChanged;
            // 
            // ElectricBikeChBx
            // 
            ElectricBikeChBx.AutoSize = true;
            ElectricBikeChBx.Location = new Point(13, 142);
            ElectricBikeChBx.Name = "ElectricBikeChBx";
            ElectricBikeChBx.Size = new Size(111, 24);
            ElectricBikeChBx.TabIndex = 2;
            ElectricBikeChBx.Text = "Electric Bike";
            ElectricBikeChBx.UseVisualStyleBackColor = true;
            ElectricBikeChBx.CheckedChanged += ElectricBikeChBx_CheckedChanged;
            // 
            // SelectTypeLbl
            // 
            SelectTypeLbl.AutoSize = true;
            SelectTypeLbl.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectTypeLbl.Location = new Point(12, 105);
            SelectTypeLbl.Name = "SelectTypeLbl";
            SelectTypeLbl.Size = new Size(215, 25);
            SelectTypeLbl.TabIndex = 4;
            SelectTypeLbl.Text = "Elige el Tipo De Bicicleta";
            SelectTypeLbl.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(139, 40);
            label2.Name = "label2";
            label2.Size = new Size(123, 17);
            label2.TabIndex = 6;
            label2.Text = "Natalia Cruz Babbar";
            // 
            // statusResponseTxt
            // 
            statusResponseTxt.Location = new Point(13, 289);
            statusResponseTxt.Name = "statusResponseTxt";
            statusResponseTxt.Size = new Size(372, 27);
            statusResponseTxt.TabIndex = 7;
            // 
            // responseLbl
            // 
            responseLbl.AutoSize = true;
            responseLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            responseLbl.Location = new Point(13, 242);
            responseLbl.Name = "responseLbl";
            responseLbl.Size = new Size(225, 28);
            responseLbl.TabIndex = 8;
            responseLbl.Text = "El estado de tu reserva:";
            // 
            // AcceptBtn
            // 
            AcceptBtn.Location = new Point(112, 189);
            AcceptBtn.Name = "AcceptBtn";
            AcceptBtn.Size = new Size(173, 36);
            AcceptBtn.TabIndex = 9;
            AcceptBtn.Text = "Aceptar";
            AcceptBtn.UseVisualStyleBackColor = true;
            AcceptBtn.Click += AcceptBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 358);
            Controls.Add(AcceptBtn);
            Controls.Add(responseLbl);
            Controls.Add(statusResponseTxt);
            Controls.Add(label2);
            Controls.Add(SelectTypeLbl);
            Controls.Add(ElectricBikeChBx);
            Controls.Add(NormalBikeChBx);
            Controls.Add(Titlelbl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titlelbl;
        private CheckBox NormalBikeChBx;
        private CheckBox ElectricBikeChBx;
        private Label SelectTypeLbl;
        private Label label2;
        private TextBox statusResponseTxt;
        private Label responseLbl;
        private Button AcceptBtn;
    }
}
