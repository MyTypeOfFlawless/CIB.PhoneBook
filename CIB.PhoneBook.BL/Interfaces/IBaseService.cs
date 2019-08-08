using System.Collections.Generic;
using System.ServiceModel;

namespace CIB.PhoneBook.BL.Interfaces
{
    [ServiceContract(Namespace = "MotovateOnTheMove.Services.Wcf")]
    public interface IBaseService<T>
    {
        [OperationContract]
        T Create(T item);

        [OperationContract]
        T Delete(T item);

        [OperationContract]
        T Update(T item);

        [OperationContract]
        List<T> GetAll();

        [OperationContract]
        T GetById(int id);

    }
}