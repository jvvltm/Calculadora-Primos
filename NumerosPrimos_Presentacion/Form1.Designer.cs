namespace NumerosPrimos_Presentacion
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
            label1 = new Label();
            comboBoxRango = new ComboBox();
            btnAceptar = new Button();
            txtResultados = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione un rango:";
            // 
            // comboBoxRango
            // 
            comboBoxRango.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRango.FormattingEnabled = true;
            comboBoxRango.Location = new Point(135, 36);
            comboBoxRango.Name = "comboBoxRango";
            comboBoxRango.Size = new Size(121, 23);
            comboBoxRango.TabIndex = 1;
            comboBoxRango.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(276, 36);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtResultados
            // 
            txtResultados.Location = new Point(12, 91);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.Size = new Size(339, 111);
            txtResultados.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 237);
            Controls.Add(txtResultados);
            Controls.Add(btnAceptar);
            Controls.Add(comboBoxRango);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Numeros Primos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxRango;
        private Button btnAceptar;
        private TextBox txtResultados;
    }
}
