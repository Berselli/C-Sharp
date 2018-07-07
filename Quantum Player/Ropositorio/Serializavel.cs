using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Ropositorio
{
    public class Serializavel
    {
        #region Genero
        /* Método que deserializa dados de um arquivo contendo os generos de musicas
         * Retorna um array de generos do tipo string
         */
        public static string[] genero()
        {
            FileStream fs = new FileStream("generos.data", FileMode.Open);
            // Cria um objeto BinaryFormatter para realizar a dessarialização
            BinaryFormatter bf = new BinaryFormatter();
            string[] generos;
            generos = (string[])bf.Deserialize(fs);
            // fecha o arquivo
            fs.Close();
            return generos;
        }
        #endregion

        #region Salvar PlayList
        /* Método que serializa em um arquivo uma lista de reprodução de musicas
         */
        public static void salvaPlayList(object playList, string nome)
        {
            string caminho = nome;
            FileStream fs = new FileStream(caminho, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, playList);
            fs.Close();
        }
        #endregion

        #region Abrir PlayList
        /* Método deserializa os dados de um arquivo .playList para um Objeto do tipo ListaMusica
         */
        public static object abrePlayList(string nome)
        {
            FileStream fs = new FileStream(nome, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            object playList = bf.Deserialize(fs);
            fs.Close();
            return playList;
        }
        #endregion
    }
}
