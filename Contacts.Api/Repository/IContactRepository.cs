using Contacts.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Api.Repository
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