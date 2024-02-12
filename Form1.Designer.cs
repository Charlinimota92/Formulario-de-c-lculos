namespace Formulario_de_càlculos
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
            btn_limpiar = new Button();
            btn_salir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_valor1 = new TextBox();
            txt_valor2 = new TextBox();
            txt_resultado = new TextBox();
            btn_calcular = new Button();
            label4 = new Label();
            txt_resta = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txt_dvision = new TextBox();
            txt_multiplicacion = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // btn_limpiar
            // 
            btn_limpiar.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btn_limpiar.Location = new Point(390, 259);
            btn_limpiar.Margin = new Padding(4);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(105, 40);
            btn_limpiar.TabIndex = 1;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btn_salir.Location = new Point(390, 348);
            btn_salir.Margin = new Padding(4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(105, 40);
            btn_salir.TabIndex = 2;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold);
            label1.Location = new Point(121, 123);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 22);
            label1.TabIndex = 3;
            label1.Text = "Valor1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold);
            label2.Location = new Point(113, 181);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 4;
            label2.Text = "Valor2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold);
            label3.Location = new Point(103, 259);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 22);
            label3.TabIndex = 5;
            label3.Text = "Resultado";
            // 
            // txt_valor1
            // 
            txt_valor1.Location = new Point(212, 119);
            txt_valor1.Margin = new Padding(4);
            txt_valor1.Name = "txt_valor1";
            txt_valor1.Size = new Size(141, 26);
            txt_valor1.TabIndex = 8;
            // 
            // txt_valor2
            // 
            txt_valor2.Location = new Point(212, 177);
            txt_valor2.Margin = new Padding(4);
            txt_valor2.Name = "txt_valor2";
            txt_valor2.Size = new Size(141, 26);
            txt_valor2.TabIndex = 9;
            // 
            // txt_resultado
            // 
            txt_resultado.Location = new Point(237, 259);
            txt_resultado.Margin = new Padding(4);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.Size = new Size(100, 26);
            txt_resultado.TabIndex = 13;
            // 
            // btn_calcular
            // 
            btn_calcular.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btn_calcular.Location = new Point(390, 138);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(105, 46);
            btn_calcular.TabIndex = 18;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold);
            label4.Location = new Point(121, 305);
            label4.Name = "label4";
            label4.Size = new Size(67, 22);
            label4.TabIndex = 19;
            label4.Text = "Resta";
            // 
            // txt_resta
            // 
            txt_resta.Location = new Point(237, 305);
            txt_resta.Name = "txt_resta";
            txt_resta.Size = new Size(100, 26);
            txt_resta.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold);
            label5.Location = new Point(83, 412);
            label5.Name = "label5";
            label5.Size = new Size(148, 22);
            label5.TabIndex = 21;
            label5.Text = "Multiplicación";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold);
            label6.Location = new Point(103, 348);
            label6.Name = "label6";
            label6.Size = new Size(90, 22);
            label6.TabIndex = 22;
            label6.Text = "División";
            // 
            // txt_dvision
            // 
            txt_dvision.Location = new Point(237, 348);
            txt_dvision.Name = "txt_dvision";
            txt_dvision.Size = new Size(100, 26);
            txt_dvision.TabIndex = 23;
            // 
            // txt_multiplicacion
            // 
            txt_multiplicacion.Location = new Point(237, 408);
            txt_multiplicacion.Name = "txt_multiplicacion";
            txt_multiplicacion.Size = new Size(100, 26);
            txt_multiplicacion.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bernard MT Condensed", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(151, 34);
            label7.Name = "label7";
            label7.Size = new Size(289, 34);
            label7.TabIndex = 25;
            label7.Text = "Formulario de Cálculos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(551, 465);
            Controls.Add(label7);
            Controls.Add(txt_multiplicacion);
            Controls.Add(txt_dvision);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_resta);
            Controls.Add(label4);
            Controls.Add(btn_calcular);
            Controls.Add(txt_resultado);
            Controls.Add(txt_valor2);
            Controls.Add(txt_valor1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_salir);
            Controls.Add(btn_limpiar);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_limpiar;
        private Button btn_salir;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_valor1;
        private TextBox txt_valor2;
        private TextBox txt_resultado;
        private Button btn_calcular;
        private Label label4;
        private TextBox txt_resta;
        private Label label5;
        private Label label6;
        private TextBox txt_dvision;
        private TextBox txt_multiplicacion;
        private Label label7;
    }
}
