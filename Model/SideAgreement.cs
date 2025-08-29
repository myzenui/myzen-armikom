using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideAgreement : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual decimal? Amount { get; set; }
        public virtual int? PaymentPeriod { get; set; }
        public virtual DateTime? EndDate { get; set; }

        [InverseProperty("Agreements")]
        public virtual Side? Side { get; set; }
        [InverseProperty("Agreements")]
        public virtual AccountItem? AccountItem { get; set; }
        [InverseProperty("SideAgreement")]
        public virtual IList<SideInvoice> Invoices { get; set; } = new ObservableCollection<SideInvoice>();
    }
}
