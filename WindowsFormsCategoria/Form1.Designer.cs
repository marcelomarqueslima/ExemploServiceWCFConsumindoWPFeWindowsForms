namespace WindowsFormsCategoria
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.compositeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblExcluir = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtIncluir = new System.Windows.Forms.TextBox();
            this.txtAlterar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInclusao = new System.Windows.Forms.Label();
            this.lblAterar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compositeTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Categoria: ";
            // 
            // txtIDCategoria
            // 
            this.txtIDCategoria.Location = new System.Drawing.Point(132, 35);
            this.txtIDCategoria.Name = "txtIDCategoria";
            this.txtIDCategoria.Size = new System.Drawing.Size(26, 20);
            this.txtIDCategoria.TabIndex = 1;
            this.txtIDCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCategoria_KeyPress);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compositeTypeBindingSource, "StringValue", true));
            this.lblCategoria.Location = new System.Drawing.Point(264, 38);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(61, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "_________";
            // 
            // compositeTypeBindingSource
            // 
            this.compositeTypeBindingSource.DataSource = typeof(WindowsFormsCategoria.SVC_Categorias.CompositeType);
            // 
            // lblIncluir
            // 
            this.lblIncluir.Location = new System.Drawing.Point(347, 63);
            this.lblIncluir.Name = "lblIncluir";
            this.lblIncluir.Size = new System.Drawing.Size(63, 23);
            this.lblIncluir.TabIndex = 3;
            this.lblIncluir.Text = "Incluir";
            this.lblIncluir.UseVisualStyleBackColor = true;
            this.lblIncluir.Click += new System.EventHandler(this.lblIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(347, 89);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(63, 23);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblExcluir
            // 
            this.lblExcluir.Location = new System.Drawing.Point(428, 28);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(63, 23);
            this.lblExcluir.TabIndex = 5;
            this.lblExcluir.Text = "Excluir";
            this.lblExcluir.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(347, 28);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(63, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Listar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtIncluir
            // 
            this.txtIncluir.Location = new System.Drawing.Point(132, 65);
            this.txtIncluir.Name = "txtIncluir";
            this.txtIncluir.Size = new System.Drawing.Size(124, 20);
            this.txtIncluir.TabIndex = 7;
            // 
            // txtAlterar
            // 
            this.txtAlterar.Location = new System.Drawing.Point(131, 91);
            this.txtAlterar.Name = "txtAlterar";
            this.txtAlterar.Size = new System.Drawing.Size(125, 20);
            this.txtAlterar.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome Categoria: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome Categoria: ";
            // 
            // lblInclusao
            // 
            this.lblInclusao.AutoSize = true;
            this.lblInclusao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compositeTypeBindingSource, "StringValue", true));
            this.lblInclusao.Location = new System.Drawing.Point(264, 68);
            this.lblInclusao.Name = "lblInclusao";
            this.lblInclusao.Size = new System.Drawing.Size(61, 13);
            this.lblInclusao.TabIndex = 11;
            this.lblInclusao.Text = "_________";
            // 
            // lblAterar
            // 
            this.lblAterar.AutoSize = true;
            this.lblAterar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compositeTypeBindingSource, "StringValue", true));
            this.lblAterar.Location = new System.Drawing.Point(264, 91);
            this.lblAterar.Name = "lblAterar";
            this.lblAterar.Size = new System.Drawing.Size(61, 13);
            this.lblAterar.TabIndex = 12;
            this.lblAterar.Text = "_________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAterar);
            this.Controls.Add(this.lblInclusao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlterar);
            this.Controls.Add(this.txtIncluir);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblIncluir);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtIDCategoria);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.compositeTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.BindingSource compositeTypeBindingSource;
        private System.Windows.Forms.Button lblIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button lblExcluir;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtIncluir;
        private System.Windows.Forms.TextBox txtAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInclusao;
        private System.Windows.Forms.Label lblAterar;
    }
}

