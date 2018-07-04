using System.Collections.Generic;
using System.ServiceModel;

[ServiceContract]
public interface IService
{
    [OperationContract]
    decimal CalculateTotals(Dictionary<string, int> items);
}
