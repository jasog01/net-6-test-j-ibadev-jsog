/*-----------------------------------------------------------------------------
- Creator: Jose Sogamoso
- Creation date: 5 Ago 2022
- Project: EERP El Sol
- Epic: EP001 Epic text
- UH: UH002 UH text
-------------------------------------------------------------------------------
*/


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaApi.Model;
using PruebaApi.Services;

namespace PruebaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FormController : ControllerBase
{
  
    
    private readonly ApiFormContext _context;

    public FormController(ApiFormContext context)
    {
        _context = context;
    }

    //creacion de endpoint

    [HttpGet]
     public async Task<IActionResult> Get()
    {
        return Ok(await _context.Forms.ToListAsync() );
    }

    
    [HttpGet("id")]
     public async Task<IActionResult> GetbyId(int id)
    {
        var formulario = _context.Forms.Where(x => x.IdForm == id).FirstOrDefault();
        return Ok(formulario);
    }
    
    [HttpPost]
     public async Task<IActionResult> Create(Form form)
    {
        _context.Add(form);
        await _context.SaveChangesAsync();
        return Ok(form);
    }
    
    [HttpPut]
     public async Task<IActionResult> Update(Form form)
    {
        var formulario = _context.Forms.Where(x => x.IdForm == form.IdForm).FirstOrDefault();
        if(formulario is null){
            return NotFound("formulario no existe");
        }
            formulario.IdTypeForm = form.IdTypeForm;
            formulario.Title = form.Title;
            formulario.StateDisabled = form.StateDisabled;
            formulario.StatePublished = form.StatePublished;

         _context.Update(formulario);
         _context.SaveChanges();
        return Ok(formulario);
    }
    

}
