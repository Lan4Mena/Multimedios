//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_CLIENTE_CORREOS
    {
        public int ID_CLIENTE_CORREO { get; set; }
        public int ID_CLIENTE { get; set; }
        public string CORREO { get; set; }
    
        public virtual TBL_CLIENTES TBL_CLIENTES { get; set; }
        public virtual TBL_CLIENTES TBL_CLIENTES1 { get; set; }
        public virtual TBL_CLIENTES TBL_CLIENTES2 { get; set; }
    }
}
