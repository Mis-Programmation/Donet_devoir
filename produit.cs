//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamDoNet
{
    using System;
    using System.Collections.Generic;
    
    public partial class produit
    {
        public int idProduit { get; set; }
        public string denominationProduit { get; set; }
        public int categorieProduit { get; set; }
        public float quantiteProduit { get; set; }
        public int PUProduit { get; set; }
    
        public virtual categorie categorie { get; set; }
    }
}
