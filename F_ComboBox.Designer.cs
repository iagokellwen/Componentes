namespace Componentes
{
    partial class F_ComboBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_mostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_resetarElementos = new System.Windows.Forms.Button();
            this.tb_novoTransporte = new System.Windows.Forms.TextBox();
            this.btn_adcionarNovoTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Moto",
            "Trem",
            "Ônibus"});
            this.cb_transportes.Location = new System.Drawing.Point(5, 7);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(177, 23);
            this.cb_transportes.TabIndex = 0;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // btn_mostrarSelecionados
            // 
            this.btn_mostrarSelecionados.Location = new System.Drawing.Point(188, 9);
            this.btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            this.btn_mostrarSelecionados.Size = new System.Drawing.Size(192, 23);
            this.btn_mostrarSelecionados.TabIndex = 1;
            this.btn_mostrarSelecionados.Text = "Mostrar Selecionados";
            this.btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionados.Click += new System.EventHandler(this.btn_mostrarSelecionados_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(188, 40);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(192, 23);
            this.btn_limpar.TabIndex = 2;
            this.btn_limpar.Text = "Limpar Elementos";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_resetarElementos
            // 
            this.btn_resetarElementos.Location = new System.Drawing.Point(188, 69);
            this.btn_resetarElementos.Name = "btn_resetarElementos";
            this.btn_resetarElementos.Size = new System.Drawing.Size(192, 23);
            this.btn_resetarElementos.TabIndex = 3;
            this.btn_resetarElementos.Text = "Resetar Elementos";
            this.btn_resetarElementos.UseVisualStyleBackColor = true;
            this.btn_resetarElementos.Click += new System.EventHandler(this.btn_resetarElementos_Click);
            // 
            // tb_novoTransporte
            // 
            this.tb_novoTransporte.Location = new System.Drawing.Point(188, 142);
            this.tb_novoTransporte.Name = "tb_novoTransporte";
            this.tb_novoTransporte.Size = new System.Drawing.Size(192, 23);
            this.tb_novoTransporte.TabIndex = 4;
            // 
            // btn_adcionarNovoTransporte
            // 
            this.btn_adcionarNovoTransporte.Location = new System.Drawing.Point(188, 171);
            this.btn_adcionarNovoTransporte.Name = "btn_adcionarNovoTransporte";
            this.btn_adcionarNovoTransporte.Size = new System.Drawing.Size(192, 23);
            this.btn_adcionarNovoTransporte.TabIndex = 5;
            this.btn_adcionarNovoTransporte.Text = "Adcionar novo transporte";
            this.btn_adcionarNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_adcionarNovoTransporte.Click += new System.EventHandler(this.btn_adcionarNovoTransporte_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.btn_adcionarNovoTransporte);
            this.Controls.Add(this.tb_novoTransporte);
            this.Controls.Add(this.btn_resetarElementos);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_mostrarSelecionados);
            this.Controls.Add(this.cb_transportes);
            this.Name = "F_ComboBox";
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cb_transportes;
        private Button btn_mostrarSelecionados;
        private Button btn_limpar;
        private Button btn_resetarElementos;
        private TextBox tb_novoTransporte;
        private Button btn_adcionarNovoTransporte;
    }
}