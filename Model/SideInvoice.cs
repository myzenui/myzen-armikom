using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideInvoice : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual decimal? Amount { get; set; }
        public virtual DateTime? Date { get; set; }
        public virtual bool? Paid { get; set; }

        [InverseProperty("Invoices")]
        public virtual SideAgreement? SideAgreement { get; set; }
    }
}
