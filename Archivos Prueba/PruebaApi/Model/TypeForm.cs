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

namespace PruebaApi.Model
{
    public partial class TypeForm
    {
        // public TypeForm()
        // {
        //     Forms = new HashSet<Form>();
        // }

        public int IdTypeForm { get; set; }
        public string DescriptionType { get; set; } = null!;

        //public virtual ICollection<Form> Forms { get; set; }
    }
}
