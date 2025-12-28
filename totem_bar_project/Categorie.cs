using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totem_bar_project
{

    public enum TipoCategoria { Bevande, Panini, Snack, BevandeCalde };
    internal class Categorie
    {
        private string nome;
        private int prezzo;
        private TipoCategoria categoria;
        private string descrizione;
        private int Iva;
        private List<string> allergeni = new List<string>();

        public Categorie(string nome, int prezzo, TipoCategoria categoria, string descrizione, int Iva, List<string> allergeni)
        {
            this.nome = nome;
            this.prezzo = prezzo;
            this.categoria = categoria;
            this.descrizione = descrizione;
            this.Iva = Iva;
            this.allergeni = allergeni;
        }


        public List<string> GetAllergeni()
        { 
            return allergeni; 
        }

        public string GetNome()
        {
            return nome;
        }
        public int GetIva()
        {
            return Iva;
        }
        public string GetDescrizione()
        {
            return descrizione;
        }
        public void SetDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
        }

        public void SetIva(int iva)
        {
            Iva = iva;
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
        public void AggiungiAllergene(string allergene)
        {
            if (!allergeni.Contains(allergene))
                allergeni.Add(allergene);
        }
        public bool ContieneAllergene(string allergene)
        {
            return allergeni.Contains(allergene);
        }
        public void CambiaCategoria(TipoCategoria nuovaCategoria)
        {
            categoria = nuovaCategoria;
        }
        public int CalcolaPrezzoConIva()
        {
            return prezzo + (prezzo * Iva / 100);
        }

    }
}
