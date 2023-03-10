namespace ACME_Desk
{
    partial class EditPatientForm
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
            this.txbEditNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxEditGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEditNascimento = new System.Windows.Forms.DateTimePicker();
            this.mskEditCpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskEditCep = new System.Windows.Forms.MaskedTextBox();
            this.txbEditRua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbEditNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbEditBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbEditCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbEditEstado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditConfirmar = new System.Windows.Forms.Button();
            this.btnEditCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbEditNome
            // 
            this.txbEditNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbEditNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEditNome.Location = new System.Drawing.Point(28, 144);
            this.txbEditNome.Name = "txbEditNome";
            this.txbEditNome.Size = new System.Drawing.Size(333, 28);
            this.txbEditNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gênero";
            // 
            // cbxEditGenero
            // 
            this.cbxEditGenero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxEditGenero.BackColor = System.Drawing.SystemColors.Control;
            this.cbxEditGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEditGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbxEditGenero.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxEditGenero.Location = new System.Drawing.Point(28, 218);
            this.cbxEditGenero.Name = "cbxEditGenero";
            this.cbxEditGenero.Size = new System.Drawing.Size(241, 30);
            this.cbxEditGenero.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data de Nascimento";
            // 
            // dtEditNascimento
            // 
            this.dtEditNascimento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtEditNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.dtEditNascimento.CustomFormat = "";
            this.dtEditNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dtEditNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEditNascimento.Location = new System.Drawing.Point(371, 218);
            this.dtEditNascimento.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtEditNascimento.MinDate = new System.DateTime(1925, 1, 1, 0, 0, 0, 0);
            this.dtEditNascimento.Name = "dtEditNascimento";
            this.dtEditNascimento.Size = new System.Drawing.Size(264, 28);
            this.dtEditNascimento.TabIndex = 4;
            this.dtEditNascimento.Value = new System.DateTime(2023, 3, 8, 0, 0, 0, 0);
            // 
            // mskEditCpf
            // 
            this.mskEditCpf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mskEditCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.mskEditCpf.Location = new System.Drawing.Point(371, 144);
            this.mskEditCpf.Mask = "999,999,999-99";
            this.mskEditCpf.Name = "mskEditCpf";
            this.mskEditCpf.Size = new System.Drawing.Size(264, 28);
            this.mskEditCpf.TabIndex = 5;
            this.mskEditCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "CEP";
            // 
            // mskEditCep
            // 
            this.mskEditCep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mskEditCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.mskEditCep.Location = new System.Drawing.Point(28, 294);
            this.mskEditCep.Mask = "00000-999";
            this.mskEditCep.Name = "mskEditCep";
            this.mskEditCep.Size = new System.Drawing.Size(158, 28);
            this.mskEditCep.TabIndex = 5;
            this.mskEditCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskEditCep.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskEditCep_KeyUp);
            // 
            // txbEditRua
            // 
            this.txbEditRua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbEditRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEditRua.Location = new System.Drawing.Point(212, 294);
            this.txbEditRua.Name = "txbEditRua";
            this.txbEditRua.Size = new System.Drawing.Size(423, 28);
            this.txbEditRua.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(208, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Rua";
            // 
            // txbEditNumero
            // 
            this.txbEditNumero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbEditNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEditNumero.Location = new System.Drawing.Point(28, 361);
            this.txbEditNumero.Name = "txbEditNumero";
            this.txbEditNumero.Size = new System.Drawing.Size(158, 28);
            this.txbEditNumero.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Número";
            // 
            // txbEditBairro
            // 
            this.txbEditBairro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbEditBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEditBairro.Location = new System.Drawing.Point(250, 361);
            this.txbEditBairro.Name = "txbEditBairro";
            this.txbEditBairro.Size = new System.Drawing.Size(385, 28);
            this.txbEditBairro.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(246, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Bairro";
            // 
            // txbEditCidade
            // 
            this.txbEditCidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbEditCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEditCidade.Location = new System.Drawing.Point(28, 431);
            this.txbEditCidade.Name = "txbEditCidade";
            this.txbEditCidade.Size = new System.Drawing.Size(333, 28);
            this.txbEditCidade.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cidade";
            // 
            // txbEditEstado
            // 
            this.txbEditEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbEditEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEditEstado.Location = new System.Drawing.Point(371, 431);
            this.txbEditEstado.Name = "txbEditEstado";
            this.txbEditEstado.Size = new System.Drawing.Size(264, 28);
            this.txbEditEstado.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(367, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Editar Paciente";
            // 
            // btnEditConfirmar
            // 
            this.btnEditConfirmar.Location = new System.Drawing.Point(139, 490);
            this.btnEditConfirmar.Name = "btnEditConfirmar";
            this.btnEditConfirmar.Size = new System.Drawing.Size(187, 49);
            this.btnEditConfirmar.TabIndex = 7;
            this.btnEditConfirmar.Text = "Confirmar";
            this.btnEditConfirmar.UseVisualStyleBackColor = true;
            this.btnEditConfirmar.Click += new System.EventHandler(this.btnEditConfirmar_Click);
            // 
            // btnEditCancelar
            // 
            this.btnEditCancelar.Location = new System.Drawing.Point(341, 490);
            this.btnEditCancelar.Name = "btnEditCancelar";
            this.btnEditCancelar.Size = new System.Drawing.Size(187, 49);
            this.btnEditCancelar.TabIndex = 7;
            this.btnEditCancelar.Text = "Cancelar";
            this.btnEditCancelar.UseVisualStyleBackColor = true;
            this.btnEditCancelar.Click += new System.EventHandler(this.btnEditCancelar_Click);
            // 
            // EditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 585);
            this.Controls.Add(this.btnEditCancelar);
            this.Controls.Add(this.btnEditConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskEditCep);
            this.Controls.Add(this.mskEditCpf);
            this.Controls.Add(this.dtEditNascimento);
            this.Controls.Add(this.cbxEditGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbEditEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbEditCidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbEditBairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbEditNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbEditRua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbEditNome);
            this.Name = "EditPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPatientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txbEditNome;
        public System.Windows.Forms.ComboBox cbxEditGenero;
        public System.Windows.Forms.DateTimePicker dtEditNascimento;
        public System.Windows.Forms.MaskedTextBox mskEditCpf;
        public System.Windows.Forms.MaskedTextBox mskEditCep;
        public System.Windows.Forms.TextBox txbEditRua;
        public System.Windows.Forms.TextBox txbEditNumero;
        public System.Windows.Forms.TextBox txbEditBairro;
        public System.Windows.Forms.TextBox txbEditCidade;
        public System.Windows.Forms.TextBox txbEditEstado;
        private System.Windows.Forms.Button btnEditConfirmar;
        private System.Windows.Forms.Button btnEditCancelar;
    }
}