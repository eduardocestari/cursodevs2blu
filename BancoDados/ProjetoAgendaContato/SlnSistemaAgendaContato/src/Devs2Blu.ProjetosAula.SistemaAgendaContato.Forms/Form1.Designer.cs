﻿namespace Devs2Blu.ProjetosAula.SistemaAgendaContato.Forms
{
    partial class FormAgendaContato
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
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.btnAlterarContato = new System.Windows.Forms.Button();
            this.btnExcluirContato = new System.Windows.Forms.Button();
            this.btnSalvarContato = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.gpCompromisso = new System.Windows.Forms.GroupBox();
            this.btnAlterarCompromisso = new System.Windows.Forms.Button();
            this.btnSalvarCompromisso = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dtDataFim = new System.Windows.Forms.DateTimePicker();
            this.dtDataIni = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.gpContatos = new System.Windows.Forms.GroupBox();
            this.gridContato = new System.Windows.Forms.DataGridView();
            this.gpCompromissos = new System.Windows.Forms.GroupBox();
            this.gridCompromissos = new System.Windows.Forms.DataGridView();
            this.gbContato.SuspendLayout();
            this.gpCompromisso.SuspendLayout();
            this.gpContatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContato)).BeginInit();
            this.gpCompromissos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompromissos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.txtCelular);
            this.gbContato.Controls.Add(this.btnAlterarContato);
            this.gbContato.Controls.Add(this.btnExcluirContato);
            this.gbContato.Controls.Add(this.btnSalvarContato);
            this.gbContato.Controls.Add(this.txtEmail);
            this.gbContato.Controls.Add(this.lbEmail);
            this.gbContato.Controls.Add(this.lbCelular);
            this.gbContato.Controls.Add(this.txtNome);
            this.gbContato.Controls.Add(this.lbNome);
            this.gbContato.Controls.Add(this.lbEstado);
            this.gbContato.Controls.Add(this.cboEstado);
            this.gbContato.Location = new System.Drawing.Point(12, 12);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(312, 158);
            this.gbContato.TabIndex = 2;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(52, 46);
            this.txtCelular.Mask = "(00) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(105, 20);
            this.txtCelular.TabIndex = 2;
            // 
            // btnAlterarContato
            // 
            this.btnAlterarContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarContato.Location = new System.Drawing.Point(135, 126);
            this.btnAlterarContato.Name = "btnAlterarContato";
            this.btnAlterarContato.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarContato.TabIndex = 60;
            this.btnAlterarContato.Text = "Alterar";
            this.btnAlterarContato.UseVisualStyleBackColor = true;
            this.btnAlterarContato.Click += new System.EventHandler(this.btnAlterarContato_Click);
            // 
            // btnExcluirContato
            // 
            this.btnExcluirContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirContato.Location = new System.Drawing.Point(218, 126);
            this.btnExcluirContato.Name = "btnExcluirContato";
            this.btnExcluirContato.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirContato.TabIndex = 70;
            this.btnExcluirContato.Text = "Excluir";
            this.btnExcluirContato.UseVisualStyleBackColor = true;
            this.btnExcluirContato.Click += new System.EventHandler(this.btnExcluirContato_Click);
            // 
            // btnSalvarContato
            // 
            this.btnSalvarContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarContato.Location = new System.Drawing.Point(52, 126);
            this.btnSalvarContato.Name = "btnSalvarContato";
            this.btnSalvarContato.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarContato.TabIndex = 50;
            this.btnSalvarContato.Text = "Salvar";
            this.btnSalvarContato.UseVisualStyleBackColor = true;
            this.btnSalvarContato.Click += new System.EventHandler(this.btnSalvarContato_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(244, 20);
            this.txtEmail.TabIndex = 30;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(11, 78);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "Email";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Location = new System.Drawing.Point(11, 49);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(39, 13);
            this.lbCelular.TabIndex = 6;
            this.lbCelular.Text = "Celular";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(244, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(11, 19);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = "Nome";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(10, 106);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 3;
            this.lbEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(50, 99);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(244, 21);
            this.cboEstado.TabIndex = 40;
            // 
            // gpCompromisso
            // 
            this.gpCompromisso.Controls.Add(this.btnAlterarCompromisso);
            this.gpCompromisso.Controls.Add(this.btnSalvarCompromisso);
            this.gpCompromisso.Controls.Add(this.label5);
            this.gpCompromisso.Controls.Add(this.txtDescricao);
            this.gpCompromisso.Controls.Add(this.dtDataFim);
            this.gpCompromisso.Controls.Add(this.dtDataIni);
            this.gpCompromisso.Controls.Add(this.label1);
            this.gpCompromisso.Controls.Add(this.label2);
            this.gpCompromisso.Controls.Add(this.txtTitulo);
            this.gpCompromisso.Controls.Add(this.label3);
            this.gpCompromisso.Controls.Add(this.label4);
            this.gpCompromisso.Controls.Add(this.cboStatus);
            this.gpCompromisso.Location = new System.Drawing.Point(16, 176);
            this.gpCompromisso.Name = "gpCompromisso";
            this.gpCompromisso.Size = new System.Drawing.Size(308, 276);
            this.gpCompromisso.TabIndex = 3;
            this.gpCompromisso.TabStop = false;
            this.gpCompromisso.Text = "Compromisso";
            // 
            // btnAlterarCompromisso
            // 
            this.btnAlterarCompromisso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarCompromisso.Location = new System.Drawing.Point(215, 229);
            this.btnAlterarCompromisso.Name = "btnAlterarCompromisso";
            this.btnAlterarCompromisso.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCompromisso.TabIndex = 15;
            this.btnAlterarCompromisso.Text = "Alterar";
            this.btnAlterarCompromisso.UseVisualStyleBackColor = true;
            this.btnAlterarCompromisso.Click += new System.EventHandler(this.btnAlterarCompromisso_Click);
            // 
            // btnSalvarCompromisso
            // 
            this.btnSalvarCompromisso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCompromisso.Location = new System.Drawing.Point(136, 229);
            this.btnSalvarCompromisso.Name = "btnSalvarCompromisso";
            this.btnSalvarCompromisso.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCompromisso.TabIndex = 13;
            this.btnSalvarCompromisso.Text = "Salvar";
            this.btnSalvarCompromisso.UseVisualStyleBackColor = true;
            this.btnSalvarCompromisso.Click += new System.EventHandler(this.btnSalvarCompromisso_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Observação";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDescricao.Location = new System.Drawing.Point(13, 140);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(280, 83);
            this.txtDescricao.TabIndex = 10;
            // 
            // dtDataFim
            // 
            this.dtDataFim.Location = new System.Drawing.Point(48, 85);
            this.dtDataFim.Name = "dtDataFim";
            this.dtDataFim.Size = new System.Drawing.Size(246, 20);
            this.dtDataFim.TabIndex = 9;
            // 
            // dtDataIni
            // 
            this.dtDataIni.Location = new System.Drawing.Point(48, 58);
            this.dtDataIni.Name = "dtDataIni";
            this.dtDataIni.Size = new System.Drawing.Size(245, 20);
            this.dtDataIni.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Até";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "De";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(48, 30);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(246, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Título";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(173, 110);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 2;
            // 
            // gpContatos
            // 
            this.gpContatos.Controls.Add(this.gridContato);
            this.gpContatos.Location = new System.Drawing.Point(347, 12);
            this.gpContatos.Name = "gpContatos";
            this.gpContatos.Size = new System.Drawing.Size(858, 226);
            this.gpContatos.TabIndex = 4;
            this.gpContatos.TabStop = false;
            this.gpContatos.Text = "Lista de Contatos";
            // 
            // gridContato
            // 
            this.gridContato.AllowUserToAddRows = false;
            this.gridContato.AllowUserToOrderColumns = true;
            this.gridContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContato.Location = new System.Drawing.Point(7, 19);
            this.gridContato.Name = "gridContato";
            this.gridContato.ReadOnly = true;
            this.gridContato.Size = new System.Drawing.Size(845, 195);
            this.gridContato.TabIndex = 0;
            this.gridContato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContato_CellContentClick);
            // 
            // gpCompromissos
            // 
            this.gpCompromissos.Controls.Add(this.gridCompromissos);
            this.gpCompromissos.Location = new System.Drawing.Point(347, 244);
            this.gpCompromissos.Name = "gpCompromissos";
            this.gpCompromissos.Size = new System.Drawing.Size(858, 208);
            this.gpCompromissos.TabIndex = 5;
            this.gpCompromissos.TabStop = false;
            this.gpCompromissos.Text = "Lista de Compromissos";
            // 
            // gridCompromissos
            // 
            this.gridCompromissos.AllowUserToAddRows = false;
            this.gridCompromissos.AllowUserToOrderColumns = true;
            this.gridCompromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompromissos.Location = new System.Drawing.Point(7, 19);
            this.gridCompromissos.Name = "gridCompromissos";
            this.gridCompromissos.ReadOnly = true;
            this.gridCompromissos.Size = new System.Drawing.Size(845, 183);
            this.gridCompromissos.TabIndex = 0;
            this.gridCompromissos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCompromissos_CellContentClick);
            // 
            // FormAgendaContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 475);
            this.Controls.Add(this.gpCompromissos);
            this.Controls.Add(this.gpContatos);
            this.Controls.Add(this.gpCompromisso);
            this.Controls.Add(this.gbContato);
            this.Name = "FormAgendaContato";
            this.Text = "Sistema Agenda de Compromisso";
            this.Load += new System.EventHandler(this.FormContato_Load);
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.gpCompromisso.ResumeLayout(false);
            this.gpCompromisso.PerformLayout();
            this.gpContatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContato)).EndInit();
            this.gpCompromissos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCompromissos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.GroupBox gpCompromisso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker dtDataFim;
        private System.Windows.Forms.DateTimePicker dtDataIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.GroupBox gpContatos;
        private System.Windows.Forms.DataGridView gridContato;
        private System.Windows.Forms.Button btnAlterarContato;
        private System.Windows.Forms.Button btnExcluirContato;
        private System.Windows.Forms.Button btnSalvarContato;
        private System.Windows.Forms.Button btnAlterarCompromisso;
        private System.Windows.Forms.Button btnSalvarCompromisso;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.GroupBox gpCompromissos;
        private System.Windows.Forms.DataGridView gridCompromissos;
    }
}

