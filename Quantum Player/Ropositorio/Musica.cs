using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ropositorio
{
    [Serializable]
    public class Musica
    {
        #region Atributos
        private string _titulo;
        private string _album;
        private string _artista;
        private int _numero;
        private string _genero;
        private int _duracaoSegundos;
        private string _duracao;
        private string _caminho;
        #endregion

        #region Construtores
        /* Construtor da Classe Musica
         * Recebe um FileStream e trata-o para retirar os metadados
         **/
        public Musica(FileStream musica)
        {
            // Recebe o arquivo e o le em binario
            BinaryReader leitor = new BinaryReader(musica);

            // Leitura e decodificação do Titulo da musica
            leitor.BaseStream.Seek(-125, SeekOrigin.End);
            _titulo = System.Text.Encoding.UTF8.GetString(leitor.ReadBytes(30));

            // Leitura e decodificação do Artista da musica
            leitor.BaseStream.Seek(-95, SeekOrigin.End);
            _artista = System.Text.Encoding.UTF8.GetString(leitor.ReadBytes(30));

            // Leitura e decodificação do Album da musica
            leitor.BaseStream.Seek(-65, SeekOrigin.End);
            _album = System.Text.Encoding.UTF8.GetString(leitor.ReadBytes(30));

            // Leitura e decodificação do Número da musica
            leitor.BaseStream.Seek(-2, SeekOrigin.End);
            _numero = int.Parse(leitor.ReadByte().ToString());

            // Leitura e decodificação do Genero da musica
            leitor.BaseStream.Seek(-1, SeekOrigin.End);
            //Desserializa o aruivo que contem a lista de generos e passa para um array de genros
            string[] generos = Serializavel.genero();
            // pega o byte de genero convete para um INT e pega no array de generos a posiçao referente
            //fazer um if para o 255
            int posicao = Int32.Parse(leitor.ReadByte().ToString());
            if (posicao < 193)
            {
                _genero = generos[posicao];
            }
            else
            {
                _genero = "Nenhum";
            }
            leitor.Dispose();

            //pega o caminho do arquivo
            _caminho = musica.Name;
            TagLib.File arquivo = TagLib.File.Create(_caminho);
            //Duração em segundos e minutos da música
            _duracao = arquivo.Properties.Duration.Minutes + ":" + arquivo.Properties.Duration.Seconds;
            _duracaoSegundos = Convert.ToInt32(arquivo.Properties.Duration.TotalSeconds);
        }

        /* Construtor da Classe Musica
         * Recebe os dados necessarios para criar um objeto musica
         **/
        public Musica(string titulo, string album, string artista, int numero, string genero, int duracaoSegundos, string duracao)
        {
            _titulo = titulo;
            _album = album;
            _artista = artista;
            _numero = numero;
            _genero = genero;
            _duracaoSegundos = duracaoSegundos;
            _duracao = duracao;
        }
        #endregion

        #region Retornos
        public string Titulo { get => _titulo; }
        public string Album { get => _album; }
        public string Artista { get => _artista; }
        public int Numero { get => _numero; }
        public string Genero { get => _genero; }
        public int DuracaoSegundos { get => _duracaoSegundos; }
        public string Duracao { get => _duracao; }
        public string Caminho { get => _caminho; }
        #endregion

        #region ToString()
        override
        public string ToString()
        {
            return _titulo;
        }
        #endregion
    }
}
