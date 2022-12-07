//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderHeader()
        {
            this.OrderRows = new HashSet<OrderRow>();
        }
    
        public int OrderHeaderId { get; set; }
        public Nullable<int> ResellerId { get; set; }
        public string OrderIdAPI { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<int> OrderStatus { get; set; }
        public System.DateTime OrderReceipt { get; set; }
        public Nullable<System.DateTime> ProductionStartDate { get; set; }
        public Nullable<System.DateTime> ProductionEndDate { get; set; }
        public Nullable<int> SalesOrderReference { get; set; }
        public string Note { get; set; }
    
        public virtual OrderState OrderState { get; set; }
        public virtual Reseller Reseller { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderRow> OrderRows { get; set; }
    }
}
