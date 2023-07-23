using System.ComponentModel.DataAnnotations;
using Contacts.Api.Requests;
using Contacts.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Api.Controllers;

[ApiController]
[Route("api/contacts")]
public class ContactController : ControllerBase
{
    private readonly IContactRepository contactRepository;

    public ContactController(IContactRepository contactRepository)
    {
        this.contactRepository = contactRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var contacts = await contactRepository.GetAll();

            return new JsonResult(contacts);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Add(ContactAddRequest request)
    {
        try
        {
            var contact = await contactRepository.Store(request);

            return new JsonResult(contact);
        }
        catch (ValidationException ex)
        {
            return BadRequest(ex.ValidationResult);
        }
    }

    [HttpPut]
    [Route("{id:guid}")]
    public async Task<IActionResult> update([FromRoute] Guid id, ContactUpdateRequest request)
    {
        try
        {
            var contact = await contactRepository.Update(id, request);

            if (contact != null)
            {
                return new JsonResult(contact);
            }

            return new NotFoundResult();
        }
        catch (ValidationException ex)
        {
            return BadRequest(ex.ValidationResult);
        }
    }

    [HttpGet]
    [Route("{id:guid}")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        try
        {
            var contact = await contactRepository.Get(id);
            if (contact != null)
            {
                return new JsonResult(contact);
            }

            return new NotFoundResult();
        }
        catch (ValidationException ex)
        {
            return BadRequest(ex.ValidationResult);
        }
    }

    [HttpDelete]
    [Route("{id:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        try
        {
            var contact = await contactRepository.Delete(id);

            if (contact)
            {
                return new JsonResult("Contact was deleted.");
            }

            return new NotFoundResult();
        }
        catch (ValidationException ex)
        {
            return BadRequest(ex.ValidationResult);
        }
    }
}