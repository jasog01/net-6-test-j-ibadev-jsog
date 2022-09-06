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
    public partial class Form
    {
        public int IdForm { get; set; }
        public int IdTypeForm { get; set; }
        public string Title { get; set; } = null!;
        public bool? StateDisabled { get; set; }
        public bool? StatePublished { get; set; }
        //public TypeForm TypeForm {get; set;}

        //public virtual TypeForm IdTypeFormNavigation { get; set; } = null!;
    }
}


