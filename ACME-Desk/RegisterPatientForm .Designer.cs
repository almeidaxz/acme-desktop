namespace ACME_Desk
{
    partial class RegisterPatientForm
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
            this.txbRegisterNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxRegisterGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtRegisterNascimento = new System.Windows.Forms.DateTimePicker();
            this.mskRegisterCpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskRegisterCep = new System.Windows.Forms.MaskedTextBox();
            this.txbRegisterRua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbRegisterNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbRegisterBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbRegisterCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbRegisterEstado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditCancelar = new System.Windows.Forms.Button();
            this.btnEditConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbRegisterNome
            // 
            this.txbRegisterNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbRegisterNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRegisterNome.Location = new System.Drawing.Point(26, 140);
            this.txbRegisterNome.Name = "txbRegisterNome";
            this.txbRegisterNome.Size = new System.Drawing.Size(333, 28);
            this.txbRegisterNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 117);
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
            this.label3.Location = new System.Drawing.Point(365, 117);
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
            this.label4.Location = new System.Drawing.Point(22, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gênero";
            // 
            // cbxRegisterGenero
            // 
            this.cbxRegisterGenero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxRegisterGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegisterGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbxRegisterGenero.FormattingEnabled = true;
            this.cbxRegisterGenero.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxRegisterGenero.Location = new System.Drawing.Point(26, 214);
            this.cbxRegisterGenero.Name = "cbxRegisterGenero";
            this.cbxRegisterGenero.Size = new System.Drawing.Size(241, 30);
            this.cbxRegisterGenero.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data de Nascimento";
            // 
            // dtRegisterNascimento
            // 
            this.dtRegisterNascimento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtRegisterNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.dtRegisterNascimento.CustomFormat = "";
            this.dtRegisterNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dtRegisterNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRegisterNascimento.Location = new System.Drawing.Point(369, 214);
            this.dtRegisterNascimento.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtRegisterNascimento.MinDate = new System.DateTime(1925, 1, 1, 0, 0, 0, 0);
            this.dtRegisterNascimento.Name = "dtRegisterNascimento";
            this.dtRegisterNascimento.Size = new System.Drawing.Size(264, 28);
            this.dtRegisterNascimento.TabIndex = 4;
            this.dtRegisterNascimento.Value = new System.DateTime(2023, 3, 8, 0, 0, 0, 0);
            // 
            // mskRegisterCpf
            // 
            this.mskRegisterCpf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mskRegisterCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.mskRegisterCpf.Location = new System.Drawing.Point(369, 140);
            this.mskRegisterCpf.Mask = "999,999,999-99";
            this.mskRegisterCpf.Name = "mskRegisterCpf";
            this.mskRegisterCpf.Size = new System.Drawing.Size(264, 28);
            this.mskRegisterCpf.TabIndex = 5;
            this.mskRegisterCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskRegisterCpf.Click += new System.EventHandler(this.mskRegisterCpf_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "CEP";
            // 
            // mskRegisterCep
            // 
            this.mskRegisterCep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mskRegisterCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.mskRegisterCep.Location = new System.Drawing.Point(26, 290);
            this.mskRegisterCep.Mask = "00000-999";
            this.mskRegisterCep.Name = "mskRegisterCep";
            this.mskRegisterCep.Size = new System.Drawing.Size(158, 28);
            this.mskRegisterCep.TabIndex = 5;
            this.mskRegisterCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskRegisterCep.Click += new System.EventHandler(this.mskRegisterCep_Click);
            this.mskRegisterCep.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskRegisterCep_KeyUp);
            // 
            // txbRegisterRua
            // 
            this.txbRegisterRua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbRegisterRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRegisterRua.Location = new System.Drawing.Point(210, 290);
            this.txbRegisterRua.Name = "txbRegisterRua";
            this.txbRegisterRua.Size = new System.Drawing.Size(423, 28);
            this.txbRegisterRua.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Rua";
            // 
            // txbRegisterNumero
            // 
            this.txbRegisterNumero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbRegisterNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRegisterNumero.Location = new System.Drawing.Point(26, 357);
            this.txbRegisterNumero.Name = "txbRegisterNumero";
            this.txbRegisterNumero.Size = new System.Drawing.Size(158, 28);
            this.txbRegisterNumero.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Número";
            // 
            // txbRegisterBairro
            // 
            this.txbRegisterBairro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbRegisterBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRegisterBairro.Location = new System.Drawing.Point(248, 357);
            this.txbRegisterBairro.Name = "txbRegisterBairro";
            this.txbRegisterBairro.Size = new System.Drawing.Size(385, 28);
            this.txbRegisterBairro.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(244, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Bairro";
            // 
            // txbRegisterCidade
            // 
            this.txbRegisterCidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbRegisterCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRegisterCidade.Location = new System.Drawing.Point(26, 427);
            this.txbRegisterCidade.Name = "txbRegisterCidade";
            this.txbRegisterCidade.Size = new System.Drawing.Size(333, 28);
            this.txbRegisterCidade.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cidade";
            // 
            // txbRegisterEstado
            // 
            this.txbRegisterEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbRegisterEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRegisterEstado.Location = new System.Drawing.Point(369, 427);
            this.txbRegisterEstado.Name = "txbRegisterEstado";
            this.txbRegisterEstado.Size = new System.Drawing.Size(264, 28);
            this.txbRegisterEstado.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(365, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cadastrar Paciente";
            // 
            // btnEditCancelar
            // 
            this.btnEditCancelar.Location = new System.Drawing.Point(339, 483);
            this.btnEditCancelar.Name = "btnEditCancelar";
            this.btnEditCancelar.Size = new System.Drawing.Size(187, 49);
            this.btnEditCancelar.TabIndex = 8;
            this.btnEditCancelar.Text = "Cancelar";
            this.btnEditCancelar.UseVisualStyleBackColor = true;
            this.btnEditCancelar.Click += new System.EventHandler(this.btnEditCancelar_Click);
            // 
            // btnEditConfirmar
            // 
            this.btnEditConfirmar.Location = new System.Drawing.Point(137, 483);
            this.btnEditConfirmar.Name = "btnEditConfirmar";
            this.btnEditConfirmar.Size = new System.Drawing.Size(187, 49);
            this.btnEditConfirmar.TabIndex = 9;
            this.btnEditConfirmar.Text = "Confirmar";
            this.btnEditConfirmar.UseVisualStyleBackColor = true;
            this.btnEditConfirmar.Click += new System.EventHandler(this.btnEditConfirmar_Click);
            // 
            // RegisterPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 563);
            this.Controls.Add(this.btnEditCancelar);
            this.Controls.Add(this.btnEditConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskRegisterCep);
            this.Controls.Add(this.mskRegisterCpf);
            this.Controls.Add(this.dtRegisterNascimento);
            this.Controls.Add(this.cbxRegisterGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbRegisterEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbRegisterCidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbRegisterBairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbRegisterNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbRegisterRua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbRegisterNome);
            this.Name = "RegisterPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPatientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterPatientForm_FormClosing);
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
        public System.Windows.Forms.TextBox txbRegisterNome;
        public System.Windows.Forms.ComboBox cbxRegisterGenero;
        public System.Windows.Forms.DateTimePicker dtRegisterNascimento;
        public System.Windows.Forms.MaskedTextBox mskRegisterCpf;
        public System.Windows.Forms.MaskedTextBox mskRegisterCep;
        public System.Windows.Forms.TextBox txbRegisterRua;
        public System.Windows.Forms.TextBox txbRegisterNumero;
        public System.Windows.Forms.TextBox txbRegisterBairro;
        public System.Windows.Forms.TextBox txbRegisterCidade;
        public System.Windows.Forms.TextBox txbRegisterEstado;
        private System.Windows.Forms.Button btnEditCancelar;
        private System.Windows.Forms.Button btnEditConfirmar;
    }
}