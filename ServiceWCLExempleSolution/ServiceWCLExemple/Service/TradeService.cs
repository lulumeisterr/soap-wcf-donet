using ServiceWCFExemple.Contracts;
using System.Collections.Generic;
using System.Linq;


namespace ServiceWCFExemple.Service
{
    public class TradeService : ITrade
    {
        private static List<Trade> trades = new List<Trade>();

        public void add(Trade t)
        {
            TradeDAO tradeDAO = new TradeDAO();
            tradeDAO.add(t);
        }

        public Trade findTrade(int tradeId) 
        {
            TradeDAO tradeDAO = new TradeDAO();
            return tradeDAO.findTrade(tradeId); 
        }
    }
}
