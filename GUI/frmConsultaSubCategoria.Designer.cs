﻿namespace GUI
{
    partial class frmConsultaSubCategoria
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
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDados
            // 
            this.DgvDados.AllowUserToAddRows = false;
            this.DgvDados.AllowUserToDeleteRows = false;
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDados.Location = new System.Drawing.Point(15, 77);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.ReadOnly = true;
            this.DgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDados.Size = new System.Drawing.Size(757, 461);
            this.DgvDados.TabIndex = 7;
            this.DgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDados_CellDoubleClick);
            // 
            // btLocalizar
            // 
            this.btLocalizar.BackColor = System.Drawing.Color.White;
            this.btLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLocalizar.Image = global::GUI.Properties.Resources.zoom;
            this.btLocalizar.Location = new System.Drawing.Point(704, 37);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(68, 23);
            this.btLocalizar.TabIndex = 6;
            this.btLocalizar.UseVisualStyleBackColor = false;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(15, 39);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(683, 20);
            this.txtValor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SubCategoria";
            // 
            // frmConsultaSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.DgvDados);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmConsultaSubCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta SubCategoria";
            this.Load += new System.EventHandler(this.frmConsultaSubCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDados;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
    }
}