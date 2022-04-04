using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWCLExemple.Service
{
    public class TradeDAO
    {
        private static List<Trade> trades = new List<Trade>();

        public void add(Trade t)
        {
            TradeDAO.trades.Add(t);
        }

        public Trade findTrade(int tradeId) 
        { 
            var result = TradeDAO.trades.Where(x => x.TradeId == tradeId).First();
            return (Trade) result;
        }
    }
}
