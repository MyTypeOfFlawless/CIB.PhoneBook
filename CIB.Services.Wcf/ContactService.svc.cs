using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using CIB.PhoneBook.BL.Logic;
using CIB.PhoneBook.DAL.Dtos;
using CIB.Services.Wcf.ErrorHandling;

namespace CIB.Services.Wcf
{
    [GlobalErrorBehavior(typeof(GlobalErrorHandler))]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ContactService : IContactService
    {
        private ContactLogic Logic { get; } = new ContactLogic();

        public ContactDto Create(ContactDto item)
        {
            return Logic.Create(item);
        }

        public ContactDto Delete(ContactDto item)
        {
            return Logic.Delete(item);
        }

        public ContactDto Update(ContactDto item)
        {
            return Logic.Update(item);
        }

        public List<ContactDto> GetAll()
        {
            return Logic.GetAll()?.ToList();
        }

        public ContactDto GetById(int id)
        {
            return Logic.GetById(id);
        }
    }
}
