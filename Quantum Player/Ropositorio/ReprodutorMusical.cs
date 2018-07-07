using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Ropositorio
{
    public class ReprodutorMusical
    {
        #region Atributos
        IWMPPlaylist playlist;
        IWMPMedia media;
        WindowsMediaPlayer wplayer;
        ListaMusica playList_LM;
        #endregion

        #region Construtores

        // O construtor somente inicializa atributos
        public ReprodutorMusical()
        {
            string nome_lista = "lista de reprodução";
            wplayer = new WindowsMediaPlayer();
            playlist = wplayer.playlistCollection.newPlaylist(nome_lista);
            playList_LM = new ListaMusica();
            wplayer.currentPlaylist.name = nome_lista;
            wplayer.settings.autoStart = false;
        }

        #endregion

        #region PlayList
        /* Método recebe um objeto do tipo ListaMusica e 
         * cria uma playList por meio dele
         */
        public ListaMusica PlayList
        {
            set
            {
                playlist.clear();
                wplayer.currentPlaylist = playlist;
                if (value.Count > 0)
                {
                    // Adiciona as musicas na playList
                    foreach (Musica mus in value)
                    {
                        media = wplayer.newMedia(mus.Caminho);
                        playlist.appendItem(media);
                    }
                    wplayer.currentPlaylist = playlist;
                    playList_LM = value;
                }
            }

        }
        #endregion

        #region Nome
        public string Nome
        {
            get { return wplayer.currentPlaylist.name; }
            set
            {
                //playList_LM.Nome = value;
                wplayer.currentPlaylist.name = value;
            }
        }
        #endregion

        #region Play
        // Método que da play na lista de música
        public void Play()
        {
            if (wplayer.playState.ToString().Equals(WMPPlayState.wmppsUndefined.ToString()))
            {
                // Verifica se a lista não está vazia
                if (wplayer.currentPlaylist.count > 0)
                {
                    wplayer.controls.play();
                }
                else
                {
                    MessageBox.Show("Lista de Reprodução não contem músicas");
                }
            }
            else
            {
                wplayer.controls.play();
            }

        }
        #endregion

        #region Pause
        // Método que pausa a lista de músicas
        public void Pause()
        {
            wplayer.controls.pause();
        }
        #endregion

        #region Next
        // Método que avança uma música
        public void Next()
        {
            wplayer.controls.next();
        }
        #endregion

        #region Stop
        //Método que para a música
        public void Stop()
        {
            wplayer.controls.stop();
        }
        #endregion

        #region Previous
        // Método que retrocede uma música
        public void Previous()
        {
            wplayer.controls.previous();
        }
        #endregion

        #region Limpa PlayList
        public void LimpaPlayList()
        {
            playlist.clear();
            wplayer.currentPlaylist = playlist;
        }
        #endregion

        #region Musica
        public Musica Musica
        {
            set
            {
                media = wplayer.newMedia(value.Caminho);
                wplayer.currentPlaylist.appendItem(media);
                playList_LM.Add(value);
            }
        }
        #endregion

        #region Volume
        public int Volume
        {
            get
            {
                return wplayer.settings.volume;
            }
            set
            {
                wplayer.settings.volume = value;
            }
        }
        #endregion        

    }
}
