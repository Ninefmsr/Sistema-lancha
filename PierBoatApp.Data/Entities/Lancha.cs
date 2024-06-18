using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierBoatApp.Data.Entities
{
    public class Lancha
    {
        private Guid _id;
        private string? _nome;
        private string? _telefone;
        private DateTime _data;
        private int _periodo;
        private string? _observacao;

        public Guid Id { get => _id; set => _id = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public int Periodo { get => _periodo; set => _periodo = value; }
        public string? Observacao { get => _observacao; set => _observacao = value; }
        public string? Telefone { get => _telefone; set => _telefone = value; }
    }
}
