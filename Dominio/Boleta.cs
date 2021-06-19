using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Boleta
    {
        public Guid BoletaId {get;set;}
        public ICollection<ItemBoleta> ListaItems {get;set;}
        public DateTime? FechaCreacion {get;set;}
    }
}