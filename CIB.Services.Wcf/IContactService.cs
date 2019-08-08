using System.ServiceModel;
using CIB.PhoneBook.BL.Interfaces;
using CIB.PhoneBook.DAL.Dtos;

namespace CIB.Services.Wcf
{
    [ServiceContract(Namespace = "CIB.Services.Wcf", Name = "ContactService", SessionMode = SessionMode.NotAllowed)]
    [ServiceKnownType(typeof(ContactDto))]
    public interface IContactService : IBaseService<ContactDto>
    {
    }
    
}
