//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detalle_Salida_Almacen
    {
        public int Id { get; set; }
        public int Articulo_id { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public System.DateTime fecha { get; set; }
        public int Salida_id { get; set; }
    
        public virtual Articulos Articulos { get; set; }
        public virtual Salida_Almacen Salida_Almacen { get; set; }
    }
}
