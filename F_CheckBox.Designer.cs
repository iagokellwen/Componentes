﻿namespace Componentes
{
    partial class F_CheckBox
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
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.cb_aviao = new System.Windows.Forms.CheckBox();
            this.cb_navio = new System.Windows.Forms.CheckBox();
            this.cb_onibus = new System.Windows.Forms.CheckBox();
            this.btn_transportesMarcados = new System.Windows.Forms.Button();
            this.cb_patinete = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(12, 12);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(55, 19);
            this.cb_carro.TabIndex = 0;
            this.cb_carro.Text = "Carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            // 
            // cb_aviao
            // 
            this.cb_aviao.AutoSize = true;
            this.cb_aviao.Location = new System.Drawing.Point(12, 37);
            this.cb_aviao.Name = "cb_aviao";
            this.cb_aviao.Size = new System.Drawing.Size(56, 19);
            this.cb_aviao.TabIndex = 1;
            this.cb_aviao.Text = "Avião";
            this.cb_aviao.UseVisualStyleBackColor = true;
            // 
            // cb_navio
            // 
            this.cb_navio.AutoSize = true;
            this.cb_navio.Location = new System.Drawing.Point(12, 62);
            this.cb_navio.Name = "cb_navio";
            this.cb_navio.Size = new System.Drawing.Size(57, 19);
            this.cb_navio.TabIndex = 2;
            this.cb_navio.Text = "Navio";
            this.cb_navio.UseVisualStyleBackColor = true;
            // 
            // cb_onibus
            // 
            this.cb_onibus.AutoSize = true;
            this.cb_onibus.Location = new System.Drawing.Point(12, 87);
            this.cb_onibus.Name = "cb_onibus";
            this.cb_onibus.Size = new System.Drawing.Size(64, 19);
            this.cb_onibus.TabIndex = 3;
            this.cb_onibus.Text = "Ônibus";
            this.cb_onibus.UseVisualStyleBackColor = true;
            // 
            // btn_transportesMarcados
            // 
            this.btn_transportesMarcados.Location = new System.Drawing.Point(120, 14);
            this.btn_transportesMarcados.Name = "btn_transportesMarcados";
            this.btn_transportesMarcados.Size = new System.Drawing.Size(159, 23);
            this.btn_transportesMarcados.TabIndex = 4;
            this.btn_transportesMarcados.Text = "Transportes marcados";
            this.btn_transportesMarcados.UseVisualStyleBackColor = true;
            this.btn_transportesMarcados.Click += new System.EventHandler(this.btn_transportesMarcados_Click);
            // 
            // cb_patinete
            // 
            this.cb_patinete.AutoSize = true;
            this.cb_patinete.Location = new System.Drawing.Point(12, 126);
            this.cb_patinete.Name = "cb_patinete";
            this.cb_patinete.Size = new System.Drawing.Size(69, 19);
            this.cb_patinete.TabIndex = 5;
            this.cb_patinete.Text = "Patinete";
            this.cb_patinete.UseVisualStyleBackColor = true;
            this.cb_patinete.CheckedChanged += new System.EventHandler(this.cb_patinete_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Abrir forms filho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_patinete);
            this.Controls.Add(this.btn_transportesMarcados);
            this.Controls.Add(this.cb_onibus);
            this.Controls.Add(this.cb_navio);
            this.Controls.Add(this.cb_aviao);
            this.Controls.Add(this.cb_carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_transportesMarcados;
        private CheckBox cb_patinete;
        public CheckBox cb_carro;
        public CheckBox cb_aviao;
        public CheckBox cb_navio;
        public CheckBox cb_onibus;
        private Button button1;
    }
}