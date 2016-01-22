namespace NFSync
{
    partial class frmNFSync
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNFSync));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dlgOrigem = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgDestino = new System.Windows.Forms.FolderBrowserDialog();
            this.txtDirOrigem = new System.Windows.Forms.TextBox();
            this.txtDirDestino = new System.Windows.Forms.TextBox();
            this.btnSelOrigem = new System.Windows.Forms.Button();
            this.btnSelDestino = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUltimoArquivo = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Este programa sincroniza as notas fiscais copiando todos os XML das NF de um dire" +
    "tório de origem para um central de destino.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diretório de origem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diretório de destino";
            // 
            // txtDirOrigem
            // 
            this.txtDirOrigem.Location = new System.Drawing.Point(16, 98);
            this.txtDirOrigem.Name = "txtDirOrigem";
            this.txtDirOrigem.Size = new System.Drawing.Size(459, 22);
            this.txtDirOrigem.TabIndex = 3;
            // 
            // txtDirDestino
            // 
            this.txtDirDestino.Location = new System.Drawing.Point(16, 161);
            this.txtDirDestino.Name = "txtDirDestino";
            this.txtDirDestino.Size = new System.Drawing.Size(459, 22);
            this.txtDirDestino.TabIndex = 4;
            // 
            // btnSelOrigem
            // 
            this.btnSelOrigem.Location = new System.Drawing.Point(482, 98);
            this.btnSelOrigem.Name = "btnSelOrigem";
            this.btnSelOrigem.Size = new System.Drawing.Size(42, 23);
            this.btnSelOrigem.TabIndex = 5;
            this.btnSelOrigem.Text = "...";
            this.btnSelOrigem.UseVisualStyleBackColor = true;
            this.btnSelOrigem.Click += new System.EventHandler(this.btnSelOrigem_Click);
            // 
            // btnSelDestino
            // 
            this.btnSelDestino.Location = new System.Drawing.Point(481, 160);
            this.btnSelDestino.Name = "btnSelDestino";
            this.btnSelDestino.Size = new System.Drawing.Size(42, 23);
            this.btnSelDestino.TabIndex = 6;
            this.btnSelDestino.Text = "...";
            this.btnSelDestino.UseVisualStyleBackColor = true;
            this.btnSelDestino.Click += new System.EventHandler(this.btnSelDestino_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(394, 248);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(129, 39);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Tag = "";
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // bw
            // 
            this.bw.WorkerReportsProgress = true;
            this.bw.WorkerSupportsCancellation = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "NFSync";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantidade de arquivos sincronizados:";
            // 
            // lblQtde
            // 
            this.lblQtde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQtde.Location = new System.Drawing.Point(278, 317);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(245, 28);
            this.lblQtde.TabIndex = 9;
            this.lblQtde.Text = "0";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Último arquivo:";
            // 
            // lblUltimoArquivo
            // 
            this.lblUltimoArquivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUltimoArquivo.Location = new System.Drawing.Point(16, 364);
            this.lblUltimoArquivo.Name = "lblUltimoArquivo";
            this.lblUltimoArquivo.Size = new System.Drawing.Size(507, 28);
            this.lblUltimoArquivo.TabIndex = 11;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(16, 220);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(507, 22);
            this.txtFiltro.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Filtro";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(16, 248);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(129, 39);
            this.btnCarregar.TabIndex = 14;
            this.btnCarregar.Tag = "";
            this.btnCarregar.Text = "Carregar Padrão";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(152, 248);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(129, 39);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Tag = "";
            this.btnGravar.Text = "Gravar Padrão";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.Location = new System.Drawing.Point(301, 404);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(223, 22);
            this.lblVersao.TabIndex = 16;
            this.lblVersao.Text = "Versão";
            this.lblVersao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmNFSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 445);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblUltimoArquivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnSelDestino);
            this.Controls.Add(this.btnSelOrigem);
            this.Controls.Add(this.txtDirDestino);
            this.Controls.Add(this.txtDirOrigem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNFSync";
            this.Text = "Sincronizador de Notas Fiscais";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNFSync_FormClosing);
            this.Load += new System.EventHandler(this.frmNFSync_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog dlgOrigem;
        private System.Windows.Forms.FolderBrowserDialog dlgDestino;
        private System.Windows.Forms.TextBox txtDirOrigem;
        private System.Windows.Forms.TextBox txtDirDestino;
        private System.Windows.Forms.Button btnSelOrigem;
        private System.Windows.Forms.Button btnSelDestino;
        private System.Windows.Forms.Button btnIniciar;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUltimoArquivo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label lblVersao;
    }
}

