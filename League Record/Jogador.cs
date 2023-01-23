using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_Record
{
    class Jogador
    {
        public int Id { get; set; }
        public int IdTime { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Numero { get; set; }
        public string Posicao { get; set; }
        public override string ToString()
        {
            return $"#{Numero} - {Nome} - {Posicao} - {Idade}";
        }
    }
}
