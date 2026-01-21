using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totem_bar_project
{

    public enum TipoCategoria { BevandeFredde, Dolci, Panini, Snack, BevandeCalde };
    public enum TipoIngredienti { Pane, Carne, Insalata, Formaggio, Pomodoro, Prosciutto, Zucchine, Bufala, Pesto, Melanzane };
    public enum Allergeni { glutine, crostacei, uova, pesce, arachidi, soia, latte, guscio, sedano, senape, sesamo, solfiti, molluschi };
    internal class Categorie
    {
        private string nome;
        private int prezzo;
        private TipoCategoria categoria;
        private List<TipoIngredienti> ingredienti = new List<TipoIngredienti>();
        private string descrizione;
        private List<Allergeni> allergeni = new List<Allergeni>();

        public Categorie(string nome, int prezzo, TipoCategoria categoria, string descrizione, List<Allergeni> allergeni, List<TipoIngredienti> ingredienti)
        {
            this.nome = nome;
            this.prezzo = prezzo;
            this.categoria = categoria;
            this.descrizione = descrizione;
            this.allergeni = allergeni;
            this.ingredienti = ingredienti;
        }
        public List<Allergeni> GetAllergeni()
        {
            return allergeni;
        }

        public string GetNome()
        {
            return nome;
        }
        public string GetDescrizione()
        {
            return descrizione;
        }
        public void SetDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
        }

        public int GetPrezzo()
        {
            return prezzo;
        }
        public void SetCategoria(TipoCategoria categoria)
        {
            this.categoria = categoria;
        }
        public TipoCategoria GetCategoria()
        {
            return categoria;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetPrezzo(int prezzo)
        {
            this.prezzo = prezzo;
        }
        public void CambiaCategoria(TipoCategoria nuovaCategoria)
        {
            categoria = nuovaCategoria;
        }
        public int CalcolaPrezzoConIva()
        {
            return prezzo + (prezzo * 10 / 100);
        }

    }
}
