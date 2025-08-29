using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideZone : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual int? ZoneNo { get; set; }
        public virtual string? Event { get; set; }
        public virtual string? Restore { get; set; }
        public virtual int? ZoneType { get; set; }

        [InverseProperty("Zones")]
        public virtual Side? Side { get; set; }
        [InverseProperty("SideZone")]
        public virtual IList<TechnicalWork> TechnicalWorks { get; set; } = new ObservableCollection<TechnicalWork>();
    }
}
