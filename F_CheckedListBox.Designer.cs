namespace Componentes
{
    partial class F_CheckedListBox
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
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_limparLista = new System.Windows.Forms.Button();
            this.btn_resetarLista = new System.Windows.Forms.Button();
            this.btn_addNovoTransporte = new System.Windows.Forms.Button();
            this.tb_NovoTransporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Navio",
            "Ônibus",
            "Trem"});
            this.clb_transportes.Location = new System.Drawing.Point(5, 2);
            this.clb_transportes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(127, 256);
            this.clb_transportes.TabIndex = 0;
            // 
            // btn_mostrarSelecionados
            // 
            this.btn_mostrarSelecionados.Location = new System.Drawing.Point(135, 1);
            this.btn_mostrarSelecionados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            this.btn_mostrarSelecionados.Size = new System.Drawing.Size(199, 20);
            this.btn_mostrarSelecionados.TabIndex = 1;
            this.btn_mostrarSelecionados.Text = "Mostrar Selecionado";
            this.btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionados.Click += new System.EventHandler(this.btn_mostrarSelecionados_Click);
            // 
            // btn_limparLista
            // 
            this.btn_limparLista.Location = new System.Drawing.Point(135, 25);
            this.btn_limparLista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_limparLista.Name = "btn_limparLista";
            this.btn_limparLista.Size = new System.Drawing.Size(199, 20);
            this.btn_limparLista.TabIndex = 2;
            this.btn_limparLista.Text = "Limpar lista";
            this.btn_limparLista.UseVisualStyleBackColor = true;
            this.btn_limparLista.Click += new System.EventHandler(this.btn_limparLista_Click);
            // 
            // btn_resetarLista
            // 
            this.btn_resetarLista.Location = new System.Drawing.Point(135, 49);
            this.btn_resetarLista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_resetarLista.Name = "btn_resetarLista";
            this.btn_resetarLista.Size = new System.Drawing.Size(199, 20);
            this.btn_resetarLista.TabIndex = 3;
            this.btn_resetarLista.Text = "Resetar Lista";
            this.btn_resetarLista.UseVisualStyleBackColor = true;
            this.btn_resetarLista.Click += new System.EventHandler(this.btn_resetarLista_Click);
            // 
            // btn_addNovoTransporte
            // 
            this.btn_addNovoTransporte.Location = new System.Drawing.Point(135, 209);
            this.btn_addNovoTransporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addNovoTransporte.Name = "btn_addNovoTransporte";
            this.btn_addNovoTransporte.Size = new System.Drawing.Size(198, 20);
            this.btn_addNovoTransporte.TabIndex = 4;
            this.btn_addNovoTransporte.Text = "Adicionar Novo Transporte";
            this.btn_addNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_addNovoTransporte.Click += new System.EventHandler(this.btn_addNovoTransporte_Click);
            // 
            // tb_NovoTransporte
            // 
            this.tb_NovoTransporte.Location = new System.Drawing.Point(136, 187);
            this.tb_NovoTransporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_NovoTransporte.Name = "tb_NovoTransporte";
            this.tb_NovoTransporte.Size = new System.Drawing.Size(102, 23);
            this.tb_NovoTransporte.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo transporte";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_NovoTransporte);
            this.Controls.Add(this.btn_addNovoTransporte);
            this.Controls.Add(this.btn_resetarLista);
            this.Controls.Add(this.btn_limparLista);
            this.Controls.Add(this.btn_mostrarSelecionados);
            this.Controls.Add(this.clb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox clb_transportes;
        private Button btn_mostrarSelecionados;
        private Button btn_limparLista;
        private Button btn_resetarLista;
        private Button btn_addNovoTransporte;
        private TextBox tb_NovoTransporte;
        private Label label1;
    }
}