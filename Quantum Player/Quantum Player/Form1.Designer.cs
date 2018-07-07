namespace Quantum_Player
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirListaDeReproducaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeReproducaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaListaDeReproducaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparListaDeReproducaooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracaoSegundosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaMusicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonParar = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonAvancar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMusicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.opcoesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1037, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.novoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicaToolStripMenuItem,
            this.pastaToolStripMenuItem,
            this.abrirListaDeReproducaoToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // musicaToolStripMenuItem
            // 
            this.musicaToolStripMenuItem.Name = "musicaToolStripMenuItem";
            this.musicaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.musicaToolStripMenuItem.Text = "Música";
            this.musicaToolStripMenuItem.Click += new System.EventHandler(this.musicaToolStripMenuItem_Click);
            // 
            // pastaToolStripMenuItem
            // 
            this.pastaToolStripMenuItem.Name = "pastaToolStripMenuItem";
            this.pastaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pastaToolStripMenuItem.Text = "Pasta";
            this.pastaToolStripMenuItem.Click += new System.EventHandler(this.pastaToolStripMenuItem_Click);
            // 
            // abrirListaDeReproducaoToolStripMenuItem
            // 
            this.abrirListaDeReproducaoToolStripMenuItem.Name = "abrirListaDeReproducaoToolStripMenuItem";
            this.abrirListaDeReproducaoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.abrirListaDeReproducaoToolStripMenuItem.Text = "Lista de reprodução";
            this.abrirListaDeReproducaoToolStripMenuItem.Click += new System.EventHandler(this.abrirListaDeReproducaoToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeReproducaoToolStripMenuItem});
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // listaDeReproducaoToolStripMenuItem
            // 
            this.listaDeReproducaoToolStripMenuItem.Name = "listaDeReproducaoToolStripMenuItem";
            this.listaDeReproducaoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.listaDeReproducaoToolStripMenuItem.Text = "Lista de reprodução";
            this.listaDeReproducaoToolStripMenuItem.Click += new System.EventHandler(this.listaDeReproducaoToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaListaDeReproducaoToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // novaListaDeReproducaoToolStripMenuItem
            // 
            this.novaListaDeReproducaoToolStripMenuItem.Name = "novaListaDeReproducaoToolStripMenuItem";
            this.novaListaDeReproducaoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.novaListaDeReproducaoToolStripMenuItem.Text = "Lista de Reprodução";
            this.novaListaDeReproducaoToolStripMenuItem.Click += new System.EventHandler(this.novaListaDeReproducaoToolStripMenuItem_Click);
            // 
            // opcoesToolStripMenuItem
            // 
            this.opcoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenarToolStripMenuItem,
            this.limparListaDeReproducaooToolStripMenuItem});
            this.opcoesToolStripMenuItem.Name = "opcoesToolStripMenuItem";
            this.opcoesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opcoesToolStripMenuItem.Text = "Opções";
            // 
            // ordenarToolStripMenuItem
            // 
            this.ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            this.ordenarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ordenarToolStripMenuItem.Text = "Ordenar";
            this.ordenarToolStripMenuItem.Click += new System.EventHandler(this.ordenarToolStripMenuItem_Click);
            // 
            // limparListaDeReproducaooToolStripMenuItem
            // 
            this.limparListaDeReproducaooToolStripMenuItem.Name = "limparListaDeReproducaooToolStripMenuItem";
            this.limparListaDeReproducaooToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.limparListaDeReproducaooToolStripMenuItem.Text = "Limpar Lista de Reprodução";
            this.limparListaDeReproducaooToolStripMenuItem.Click += new System.EventHandler(this.limparListaDeReproducaooToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.albumDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.artistaDataGridViewTextBoxColumn,
            this.duracaoDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.duracaoSegundosDataGridViewTextBoxColumn,
            this.caminhoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listaMusicaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 398);
            this.dataGridView1.TabIndex = 1;
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn.HeaderText = "Album";
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            this.albumDataGridViewTextBoxColumn.ReadOnly = true;
            this.albumDataGridViewTextBoxColumn.Width = 260;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Width = 50;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 240;
            // 
            // artistaDataGridViewTextBoxColumn
            // 
            this.artistaDataGridViewTextBoxColumn.DataPropertyName = "Artista";
            this.artistaDataGridViewTextBoxColumn.HeaderText = "Artista";
            this.artistaDataGridViewTextBoxColumn.Name = "artistaDataGridViewTextBoxColumn";
            this.artistaDataGridViewTextBoxColumn.ReadOnly = true;
            this.artistaDataGridViewTextBoxColumn.Width = 200;
            // 
            // duracaoDataGridViewTextBoxColumn
            // 
            this.duracaoDataGridViewTextBoxColumn.DataPropertyName = "Duracao";
            this.duracaoDataGridViewTextBoxColumn.HeaderText = "Duracao";
            this.duracaoDataGridViewTextBoxColumn.Name = "duracaoDataGridViewTextBoxColumn";
            this.duracaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.duracaoDataGridViewTextBoxColumn.Width = 70;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            this.generoDataGridViewTextBoxColumn.Width = 140;
            // 
            // duracaoSegundosDataGridViewTextBoxColumn
            // 
            this.duracaoSegundosDataGridViewTextBoxColumn.DataPropertyName = "DuracaoSegundos";
            this.duracaoSegundosDataGridViewTextBoxColumn.HeaderText = "DuracaoSegundos";
            this.duracaoSegundosDataGridViewTextBoxColumn.Name = "duracaoSegundosDataGridViewTextBoxColumn";
            this.duracaoSegundosDataGridViewTextBoxColumn.ReadOnly = true;
            this.duracaoSegundosDataGridViewTextBoxColumn.Visible = false;
            // 
            // caminhoDataGridViewTextBoxColumn
            // 
            this.caminhoDataGridViewTextBoxColumn.DataPropertyName = "Caminho";
            this.caminhoDataGridViewTextBoxColumn.HeaderText = "Caminho";
            this.caminhoDataGridViewTextBoxColumn.Name = "caminhoDataGridViewTextBoxColumn";
            this.caminhoDataGridViewTextBoxColumn.ReadOnly = true;
            this.caminhoDataGridViewTextBoxColumn.Visible = false;
            // 
            // listaMusicaBindingSource
            // 
            this.listaMusicaBindingSource.DataSource = typeof(Ropositorio.ListaMusica);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(12, 431);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 2;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonParar
            // 
            this.buttonParar.Location = new System.Drawing.Point(93, 431);
            this.buttonParar.Name = "buttonParar";
            this.buttonParar.Size = new System.Drawing.Size(75, 23);
            this.buttonParar.TabIndex = 3;
            this.buttonParar.Text = "Parar";
            this.buttonParar.UseVisualStyleBackColor = true;
            this.buttonParar.Click += new System.EventHandler(this.buttonParar_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(174, 431);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 4;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(255, 431);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonAvancar
            // 
            this.buttonAvancar.Location = new System.Drawing.Point(336, 431);
            this.buttonAvancar.Name = "buttonAvancar";
            this.buttonAvancar.Size = new System.Drawing.Size(75, 23);
            this.buttonAvancar.TabIndex = 6;
            this.buttonAvancar.Text = "Avançar";
            this.buttonAvancar.UseVisualStyleBackColor = true;
            this.buttonAvancar.Click += new System.EventHandler(this.buttonAvancar_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "playList";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(573, 431);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 7;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(654, 433);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(371, 20);
            this.textBoxPesquisar.TabIndex = 8;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(417, 431);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(150, 45);
            this.trackBarVolume.TabIndex = 9;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 466);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.textBoxPesquisar);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonAvancar);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonParar);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quantum Player";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMusicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcoesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem listaDeReproducaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaListaDeReproducaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirListaDeReproducaoToolStripMenuItem;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonParar;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonAvancar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource listaMusicaBindingSource;
        private System.Windows.Forms.ToolStripMenuItem limparListaDeReproducaooToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracaoSegundosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TrackBar trackBarVolume;
    }
}

