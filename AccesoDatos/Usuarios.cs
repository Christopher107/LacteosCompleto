//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        public int Id { get; set; }
        public Nullable<int> Usuario { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }
        public Nullable<int> Seccion { get; set; }
    
        public virtual Seccion Seccion1 { get; set; }
    }
}