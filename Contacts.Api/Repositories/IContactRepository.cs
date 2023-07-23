using Contacts.Api.Models;

namespace Contacts.Api.Repositories
{
	public interface IContactRepository
	{
        public Task<List<Contact>> GetAllAsync();
        public Task<Contact> Store(ContactAddRequest request);
        public Task<Contact?> Update(Guid id, ContactUpdateRequest request);
        public Task<Contact?> Get(Guid id);
        public Task<bool> Delete(Guid id);
    }
}