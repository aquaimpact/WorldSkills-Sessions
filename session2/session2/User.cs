//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace session2
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public string userId { get; set; }
        public string userName { get; set; }
        public string userPw { get; set; }
        public int userTypeIdFK { get; set; }
    
        public virtual User_Type User_Type { get; set; }
    }
}