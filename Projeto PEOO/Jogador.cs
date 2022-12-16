using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PEOO
{
    class Jogador
    {
        
        private string Nome;
        private string Camisa;
        private int Gols;

        public void SetNome(string n1)
        {
            Nome = n1;
        }
        public void SetCamisa(string c1)
        {
            Camisa = c1;
        }
        public void SetGols(int g1)
        {
            Gols = g1;
        }

        public string GetNome()
        {
            return Nome;
        }
        public string GetCamisa()
        {
            return Camisa;
        }
        public int GetGols()
        {
            return Gols;
        }
        public Jogador(string n, string c, int g)
        {
            Nome = n;
            Camisa = c;
            Gols = g;
        }
        public override string ToString()
        {
            return $"Nome: {Nome} - Camisa: {Camisa} - Quantidade de Gols: {Gols}";
        }
    }
}
