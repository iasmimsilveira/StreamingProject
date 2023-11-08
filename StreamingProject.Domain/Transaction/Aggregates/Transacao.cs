using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StreamingProject.Domain.Transaction.ValueObject;

namespace StreamingProject.Domain.Transaction.Aggregates
{
    public class Transacao
    {
        public Guid Id { get; set; }
        public DateTime DtTransacao { get; set; }
        public Decimal Valor { get; set; }
        public Merchant Merchant { get; set; }
        public String Descricao { get; set; }
    }
}
