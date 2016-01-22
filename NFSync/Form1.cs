using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace NFSync
{
    public partial class frmNFSync : Form
    {

        public delegate void DelegateAtualizaTela(int qtde, String ultArq);

        DelegateAtualizaTela atualizatela;

        


        public int QtdeArquivos = 0;
        public frmNFSync()
        {
            InitializeComponent();
        }



        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!CheckConfig())
            {
                return;
            }
            if ((int)btnIniciar.Tag == 0)
            {
                bw.RunWorkerAsync();
                btnIniciar.Tag = 1;
                atualizatela(QtdeArquivos,"");

            }
            else
            {
                bw.CancelAsync();
                btnIniciar.Tag = 0;
            }
            ConfigUI();
            
        }

        private bool CheckConfig()
        {
            bool ret = true;
            if (String.IsNullOrWhiteSpace(txtDirOrigem.Text))
            {
                MostraErro("Origem não pode estar em branco");
                ret = false;
            }
            if (String.IsNullOrWhiteSpace(txtDirDestino.Text))
            {
                MostraErro("Destino não pode estar em branco");
                ret = false;
            }
            if (String.IsNullOrWhiteSpace(txtFiltro.Text))
            {
                MostraErro("Filtro não pode estar em branco");
                ret = false;
            }

            return ret;
        }

        public void MostraErro(String msg)
        {
            MessageBox.Show(msg, "NFSync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ConfigUI()
        {
            bool iniciado = (int)btnIniciar.Tag == 1;

            if (!iniciado)
            {
                btnIniciar.Text = "Iniciar";
            }
            else
            {
                btnIniciar.Text = "Parar";
            }

            
            txtDirDestino.Enabled = !iniciado;
            txtDirOrigem.Enabled = !iniciado;
            btnSelOrigem.Enabled = !iniciado;
            btnSelDestino.Enabled = !iniciado;
            txtFiltro.Enabled = !iniciado;
            btnCarregar.Enabled = !iniciado;
            btnGravar.Enabled = !iniciado;

        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            QtdeArquivos = 0;
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = txtDirOrigem.Text;
            watcher.Filter = txtFiltro.Text;
            watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName;




            watcher.IncludeSubdirectories = true;
            watcher.Created += Watcher_Created;
            watcher.Changed += Watcher_Changed;
            watcher.Deleted += Watcher_Deleted;
            watcher.Renamed += Watcher_Renamed;

            watcher.EnableRaisingEvents = true;


            while (bw.IsBusy)
            {
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    watcher.EnableRaisingEvents = false;                    
                    break;
                }
            }


        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            

        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            

        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            if (CopiaParaDestino(e.FullPath))
            {
                QtdeArquivos++;
                this.Invoke(atualizatela, QtdeArquivos, e.Name);
            }

        }

        private void frmNFSync_Load(object sender, EventArgs e)
        {

            lblVersao.Text = "Versão "+ Application.ProductVersion;

            btnIniciar.Tag = 0;
            atualizatela = new DelegateAtualizaTela(AtualizaTela);
            CarregarConfiguracao();


        }

        public void AtualizaTela(int qtde, String ultArq)
        {
            lblQtde.Text = qtde.ToString();
            lblUltimoArquivo.Text = ultArq;
        }

        private void btnSelOrigem_Click(object sender, EventArgs e)
        {
            dlgOrigem.SelectedPath = txtDirOrigem.Text;
           
            if (dlgOrigem.ShowDialog() == DialogResult.OK)
            {
                txtDirOrigem.Text = dlgOrigem.SelectedPath;
            }
        }

        private void btnSelDestino_Click(object sender, EventArgs e)
        {
            dlgDestino.SelectedPath = txtDirDestino.Text;
            if (dlgDestino.ShowDialog() == DialogResult.OK)
            {
                txtDirDestino.Text = dlgDestino.SelectedPath;
            }
        }



        public bool CopiaParaDestino(String nomeArq)
        {
            bool ret = false;
            String[] partArq = nomeArq.Split(new Char[] { Path.DirectorySeparatorChar});
            String destino = Path.Combine(txtDirDestino.Text,partArq[partArq.Length-4], partArq[partArq.Length-3]);
            if (!Directory.Exists(destino))
                Directory.CreateDirectory(destino);

            File.Copy(nomeArq, Path.Combine(destino, partArq[partArq.Length - 1]),true);
            ret = true;
            return ret;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            SalvarConfiguracao();
        }

        private void SalvarConfiguracao()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            
            config.AppSettings.Settings.Remove("Origem");
            config.AppSettings.Settings.Add("Origem", txtDirOrigem.Text);

            config.AppSettings.Settings.Remove("Destino");
            config.AppSettings.Settings.Add("Destino", txtDirDestino.Text);

            config.AppSettings.Settings.Remove("Filtro");
            config.AppSettings.Settings.Add("Filtro", txtFiltro.Text);
            config.Save(ConfigurationSaveMode.Minimal);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarConfiguracao();

        }

        private void CarregarConfiguracao()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            txtDirOrigem.Text = config.AppSettings.Settings["Origem"].Value;
            txtDirDestino.Text = config.AppSettings.Settings["Destino"].Value;
            txtFiltro.Text = config.AppSettings.Settings["Filtro"].Value;
        }

        private void frmNFSync_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bw.IsBusy)
            {
                e.Cancel = true;
                MessageBox.Show("Primeiro pare a execução!");
            }
        }
    }
}
