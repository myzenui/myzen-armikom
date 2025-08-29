using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class Customer : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Address { get; set; }
        public virtual string? Phone1 { get; set; }
        public virtual string? Phone2 { get; set; }
        public virtual string? Email1 { get; set; }
        public virtual string? Email2 { get; set; }
        public virtual string? TaxOffice { get; set; }
        public virtual string? TaxNo { get; set; }
        public virtual string? Latitude { get; set; }
        public virtual string? Longitude { get; set; }
        public virtual string? UserName { get; set; }
        public virtual string? UserPassword { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Customers")]
        public virtual City? City { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Customers")]
        public virtual District? District { get; set; }
        [InverseProperty("Customer")]
        public virtual IList<Side> Sides { get; set; } = new ObservableCollection<Side>();
    }
}
