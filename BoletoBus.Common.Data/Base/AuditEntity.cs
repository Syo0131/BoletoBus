

namespace BoletoBus.Common.Data.Base
{
    //no es necesaria en todos los casos pero la creo para despues

    
    public abstract class AuditEntity<TType> : BaseEntity<TType>
    {
        public DateTime? FechaCreacion { get; set; }
        
    }

}
