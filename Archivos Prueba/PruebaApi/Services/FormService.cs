/*-----------------------------------------------------------------------------
- Creator: Jose Sogamoso
- Creation date: 5 Ago 2022
- Project: EERP El Sol
- Epic: EP001 Epic text
- UH: UH002 UH text
-------------------------------------------------------------------------------
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaApi.Model;

namespace PruebaApi.Services
{

    public interface IFormService 
    {
        public Task<List<Form>> GetForms();
    }


    public class FormService : IFormService
    {
         ApiFormContext context;

        public FormService(ApiFormContext dbcontext)
        {
            context = dbcontext;
        }

        public async Task<List<Form>> GetForms()
        {
             return await context.Forms.ToListAsync();
        }

    }
}