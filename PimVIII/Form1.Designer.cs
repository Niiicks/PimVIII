
namespace PimVIII
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
            this.InserirPessoa = new System.Windows.Forms.Button();
            this.ExcluirPessoa = new System.Windows.Forms.Button();
            this.txtIdPessoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AlterarPessoa = new System.Windows.Forms.Button();
            this.buscarPessoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InserirPessoa
            // 
            this.InserirPessoa.Location = new System.Drawing.Point(120, 110);
            this.InserirPessoa.Name = "InserirPessoa";
            this.InserirPessoa.Size = new System.Drawing.Size(192, 88);
            this.InserirPessoa.TabIndex = 0;
            this.InserirPessoa.Text = "Inserir Pessoa";
            this.InserirPessoa.UseVisualStyleBackColor = true;
            this.InserirPessoa.Click += new System.EventHandler(this.InserirPessoa_Click);
            // 
            // ExcluirPessoa
            // 
            this.ExcluirPessoa.Location = new System.Drawing.Point(120, 267);
            this.ExcluirPessoa.Name = "ExcluirPessoa";
            this.ExcluirPessoa.Size = new System.Drawing.Size(192, 90);
            this.ExcluirPessoa.TabIndex = 1;
            this.ExcluirPessoa.Text = "Excluir Pessoa";
            this.ExcluirPessoa.UseVisualStyleBackColor = true;
            this.ExcluirPessoa.Click += new System.EventHandler(this.ExcluirPessoa_Click);
            // 
            // txtIdPessoa
            // 
            this.txtIdPessoa.Location = new System.Drawing.Point(318, 220);
            this.txtIdPessoa.Name = "txtIdPessoa";
            this.txtIdPessoa.Size = new System.Drawing.Size(192, 23);
            this.txtIdPessoa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id: ";
            // 
            // AlterarPessoa
            // 
            this.AlterarPessoa.Location = new System.Drawing.Point(494, 267);
            this.AlterarPessoa.Name = "AlterarPessoa";
            this.AlterarPessoa.Size = new System.Drawing.Size(192, 90);
            this.AlterarPessoa.TabIndex = 4;
            this.AlterarPessoa.Text = "Alterar Pessoa";
            this.AlterarPessoa.UseVisualStyleBackColor = true;
            this.AlterarPessoa.Click += new System.EventHandler(this.AlterarPessoa_Click);
            // 
            // buscarPessoa
            // 
            this.buscarPessoa.Location = new System.Drawing.Point(494, 108);
            this.buscarPessoa.Name = "buscarPessoa";
            this.buscarPessoa.Size = new System.Drawing.Size(192, 90);
            this.buscarPessoa.TabIndex = 5;
            this.buscarPessoa.Text = "Buscar Pessoa";
            this.buscarPessoa.UseVisualStyleBackColor = true;
            this.buscarPessoa.Click += new System.EventHandler(this.buscarPessoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscarPessoa);
            this.Controls.Add(this.AlterarPessoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdPessoa);
            this.Controls.Add(this.ExcluirPessoa);
            this.Controls.Add(this.InserirPessoa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InserirPessoa;
        private System.Windows.Forms.Button ExcluirPessoa;
        private System.Windows.Forms.TextBox txtIdPessoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AlterarPessoa;
        private System.Windows.Forms.Button buscarPessoa;
    }
}

