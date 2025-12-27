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
        string nome;
        int prezzo;
        private TipoCategoria categoria;

        public Categorie(string nome, int prezzo, TipoCategoria categoria)
        {
            this.nome = nome;
            this.prezzo = prezzo;
            this.categoria = categoria;
        }
        
        public string GetNome()
        {
            return nome;
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
    }
}
