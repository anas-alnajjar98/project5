//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_5_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int ID { get; set; }
        public string NationalNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string ElectionArea { get; set; }
        public string Governorate { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Gender { get; set; }
        public Nullable<bool> LocalElections { get; set; }
        public Nullable<bool> PartyElections { get; set; }
        public Nullable<bool> whitePaperLocalElections { get; set; }
        public Nullable<bool> whitePaperPartyElections { get; set; }
    }
}