//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFA_EF_Kimbilir
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public short Score { get; set; }
        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }

        public virtual Person_Detail Person_Details { get; set; }
    }
}
