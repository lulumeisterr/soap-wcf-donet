using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServiceWCFExemple
{
    [DataContract]
    public class Trade
    {
        [DataMember]
        private int tradeId;
        [DataMember]
        private string category;
        [DataMember]
        private string participant;
  
        public Trade() { }

        public Trade(int tradeId, string category, string participant)
        {
            this.tradeId = tradeId;
            this.category = category;
            this.participant = participant;
    
        }

        public int TradeId
        {
            get => tradeId;
            set => tradeId = value;
        }

        public string Category
        {
            get => category;
            set => category = value;
        }

        public string Participant
        {
            get => participant;
            set => participant = value;
        }

        public override String ToString()
        {
            return $"TradeId {tradeId} Categoria e participante {category}-{participant}";
        }
    }
}
