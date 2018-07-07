using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ropositorio;

namespace Quantum_Player
{
    public partial class Form1 : Form
    {

        ReprodutorMusical reprodutorMusical = new ReprodutorMusical();
        ListaMusica listaDeReporducao = new ListaMusica();
        

        public Form1()
        {
            InitializeComponent();
            trackBarVolume.Value = reprodutorMusical.Volume;
        }

        private void salvaELimpaListaReproducao()
        {
            if (MessageBox.Show("Deseja salvar a lista de reprodução?", "Salvar Lista de Reprodução", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();
                    Serializavel.salvaPlayList(listaDeReporducao, saveFileDialog.FileName);
                    stopwatch.Stop();
                    Log.salvarLog(stopwatch.Elapsed.ToString().Remove(0, 6), "salvar lista de reprodução");
                    stopwatch.Reset();
                }
                    
            }
            listaDeReporducao.Clear();
            reprodutorMusical.LimpaPlayList();
            var source = new BindingSource();
            source.DataSource = listaDeReporducao;
            dataGridView1.DataSource = source;
        }

        private void abreMusicasDaPasta()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dir = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                foreach (FileInfo file in dir.GetFiles())
                {
                    // aqui no caso estou guardando o nome completo do arquivo em em controle ListBox
                    // voce faz como quiser
                    FileStream arq = new FileStream(file.FullName, FileMode.Open);
                    Musica musc = new Musica(arq);
                    arq.Dispose();
                    listaDeReporducao.Add(musc);
                }
                var source = new BindingSource();
                source.DataSource = listaDeReporducao;
                dataGridView1.DataSource = source;
                reprodutorMusical.PlayList = listaDeReporducao;
                stopwatch.Stop();
                Log.salvarLog(stopwatch.Elapsed.ToString().Remove(0, 6), "Adicionar musicas de uma pasta");
                stopwatch.Reset();
            }
            
        }

        // Adicionar Música
        private void musicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Filtro para .MP3
            openFileDialog.Filter = "Músicas (*.mp3)|*.mp3";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();
                    //Pega uma música e adiciona ela a uma lista de musicas
                    FileStream arquivo = new FileStream(openFileDialog.FileName, FileMode.Open);
                    Musica musica = new Musica(arquivo);
                    arquivo.Dispose();
                    listaDeReporducao.Add(musica);
                    var source = new BindingSource();
                    source.DataSource = listaDeReporducao;
                    dataGridView1.DataSource = source;
                    reprodutorMusical.Musica = musica;
                    stopwatch.Stop();
                    Log.salvarLog(stopwatch.Elapsed.ToString().Remove(0, 6), "adicionar musica");
                    stopwatch.Reset();
                }
                catch (IOException)
                {
                    Log.salvarLog("Erro IOException", " ao adicionar musica"); ;
                }
                
            }
        }

        private void listaDeReproducaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Filtro para .playList
            saveFileDialog.Filter = "Lista de Reprodução (*.playList)|*.playList";
            if(listaDeReporducao.Count > 0)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();
                    Serializavel.salvaPlayList(listaDeReporducao, saveFileDialog.FileName);
                    stopwatch.Stop();
                    Log.salvarLog(stopwatch.Elapsed.ToString().Remove(0, 6), "salvar lista de reprodução");
                    stopwatch.Reset();
                }
                    
                
            }
            else
                MessageBox.Show("Não é possível salvar a lista de reprodução, pois ela não tem musicas.");
        }

        private void abrirListaDeReproducaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Filtro para .playList
            openFileDialog.Filter = "Lista de Reprodução (*.playList)|*.playList";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                listaDeReporducao = (ListaMusica)Serializavel.abrePlayList(openFileDialog.FileName);
                var source = new BindingSource();
                source.DataSource = listaDeReporducao;
                dataGridView1.DataSource = source;
                reprodutorMusical.PlayList = listaDeReporducao;
                stopwatch.Stop();
                Log.salvarLog(stopwatch.Elapsed.ToString().Remove(0, 6), "abrir lista de reprodução");
                stopwatch.Reset();
            }
        }

        private void limparListaDeReproducaooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listaDeReporducao.Count > 0)
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                salvaELimpaListaReproducao();
                listaDeReporducao.Clear();
                reprodutorMusical.LimpaPlayList();
                stopwatch.Stop();
                Log.salvarLog(stopwatch.Elapsed.ToString().Remove(0, 6), "limpar lista de reprodução");
                stopwatch.Reset();
            }
        }

        private void novaListaDeReproducaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listaDeReporducao.Count > 0)
                salvaELimpaListaReproducao();
        }

        private void pastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listaDeReporducao.Count > 0)
                salvaELimpaListaReproducao();
            abreMusicasDaPasta();
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaDeReporducao = ListaMusica.SortTitle(listaDeReporducao);
            var source = new BindingSource();
            source.DataSource = listaDeReporducao;
            dataGridView1.DataSource = source;
            reprodutorMusical.PlayList = listaDeReporducao;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            reprodutorMusical.Previous();
        }

        private void buttonParar_Click(object sender, EventArgs e)
        {
            reprodutorMusical.Stop();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            reprodutorMusical.Pause();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            reprodutorMusical.Play();
        }

        private void buttonAvancar_Click(object sender, EventArgs e)
        {
            reprodutorMusical.Next();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            List<Musica> resultado = null;
            string compilado = "";
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            if (textBoxPesquisar.Text.Count() > 0 && listaDeReporducao.Count > 0)
            {
                resultado = (List<Musica>)ListaMusica.Pesquisar(textBoxPesquisar.Text.ToLower(), listaDeReporducao);
                foreach(Musica item in resultado)
                {
                    compilado += item.Titulo + "\n";
                }
            }
            if (resultado != null && resultado.Count > 0)
            {
                MessageBox.Show("O resultado de pesquisa foi: \n" + compilado, "Pesquisa de Titulo");
            }
            stopwatch.Stop();
            Log.salvarLog(stopwatch.Elapsed.ToString().Remove(0, 6), "pesquisar música");
            stopwatch.Reset();
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            reprodutorMusical.Volume = trackBarVolume.Value;
        }
    }
}
