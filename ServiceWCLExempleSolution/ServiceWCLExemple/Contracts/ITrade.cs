using System.ServiceModel;
/**
 * Para falar para o WCF que essa interface é um contrato de serviço
 * Deve-se definir a ServiceContract e As operacoes de contrato OperationContract
 */
namespace ServiceWCFExemple.Contracts
{

    [ServiceContract]
    public interface ITrade
    {
        [OperationContract]
        void add(Trade t);

        [OperationContract]
        Trade findTrade(int tradeId);
    }
}
