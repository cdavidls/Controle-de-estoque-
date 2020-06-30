namespace GUI
{
    partial class FrmCadastroCategoria
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btInserir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAlterar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btExcluir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btSalvar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.pnDados = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.Controls.Add(this.btInserir);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.btLocalizar);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.btAlterar);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.btExcluir);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.btSalvar);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.btCancelar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 429);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(767, 120);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btInserir
            // 
            this.btInserir.AllowDrop = true;
            this.btInserir.BackColor = System.Drawing.Color.White;
            this.btInserir.BackgroundImage = global::GUI.Properties.Resources.application_form_add;
            this.btInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btInserir.Location = new System.Drawing.Point(3, 3);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 82);
            this.btInserir.TabIndex = 0;
            this.btInserir.Text = "Inserir";
            this.btInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.Location = new System.Drawing.Point(84, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 117);
            this.panel2.TabIndex = 7;
            // 
            // btLocalizar
            // 
            this.btLocalizar.AllowDrop = true;
            this.btLocalizar.BackColor = System.Drawing.Color.White;
            this.btLocalizar.BackgroundImage = global::GUI.Properties.Resources.zoom;
            this.btLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLocalizar.Location = new System.Drawing.Point(140, 3);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(75, 82);
            this.btLocalizar.TabIndex = 1;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLocalizar.UseVisualStyleBackColor = false;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Location = new System.Drawing.Point(221, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 117);
            this.panel1.TabIndex = 8;
            // 
            // btAlterar
            // 
            this.btAlterar.AllowDrop = true;
            this.btAlterar.BackColor = System.Drawing.Color.White;
            this.btAlterar.BackgroundImage = global::GUI.Properties.Resources.application_edit;
            this.btAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAlterar.Location = new System.Drawing.Point(277, 3);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 82);
            this.btAlterar.TabIndex = 2;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.Location = new System.Drawing.Point(358, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 117);
            this.panel3.TabIndex = 8;
            // 
            // btExcluir
            // 
            this.btExcluir.AllowDrop = true;
            this.btExcluir.BackColor = System.Drawing.Color.White;
            this.btExcluir.BackgroundImage = global::GUI.Properties.Resources.application_form_delete;
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluir.Location = new System.Drawing.Point(414, 3);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 82);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // panel4
            // 
            this.panel4.AllowDrop = true;
            this.panel4.Location = new System.Drawing.Point(495, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 117);
            this.panel4.TabIndex = 8;
            // 
            // btSalvar
            // 
            this.btSalvar.AllowDrop = true;
            this.btSalvar.BackColor = System.Drawing.Color.White;
            this.btSalvar.BackgroundImage = global::GUI.Properties.Resources.table_save;
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSalvar.Location = new System.Drawing.Point(551, 3);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 82);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // panel5
            // 
            this.panel5.AllowDrop = true;
            this.panel5.Location = new System.Drawing.Point(632, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 117);
            this.panel5.TabIndex = 8;
            // 
            // btCancelar
            // 
            this.btCancelar.AllowDrop = true;
            this.btCancelar.BackColor = System.Drawing.Color.White;
            this.btCancelar.BackgroundImage = global::GUI.Properties.Resources.cancel;
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCancelar.Location = new System.Drawing.Point(688, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 82);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // pnDados
            // 
            this.pnDados.AllowDrop = true;
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Location = new System.Drawing.Point(8, 12);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(769, 397);
            this.pnDados.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome da categoria";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(711, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(20, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // FrmCadastroCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnDados);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Categoria";
            this.Load += new System.EventHandler(this.FrmCadastroCategoria_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        protected System.Windows.Forms.Button btInserir;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button btLocalizar;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button btAlterar;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btExcluir;
        protected System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Button btSalvar;
        protected System.Windows.Forms.Panel panel5;
        protected System.Windows.Forms.Button btCancelar;
        protected System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}