//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSMateriales.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reporte
    {
        public int idReport { get; set; }
        public Nullable<int> id_Material { get; set; }
        public Nullable<System.DateTime> fecha_report { get; set; }
        public string admin_proyecto { get; set; }
        public string nombre_proyecto { get; set; }
        public string descripcion_proyecto { get; set; }
    }
}
