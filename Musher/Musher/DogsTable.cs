//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Musher
{
    using System;
    using System.Collections.Generic;
    
    public partial class DogsTable
    {
        public long DogChip { get; set; }
        public int LinkedArrival { get; set; }
    
        public virtual Arrivals_Table Arrivals_Table { get; set; }
    }
}