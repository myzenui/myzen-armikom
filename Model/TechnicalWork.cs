using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class TechnicalWork : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? TechnicianName { get; set; }
        public virtual DateTime? EndDate { get; set; }

        [InverseProperty("TechnicalWorks")]
        public virtual Side? Side { get; set; }
        [InverseProperty("TechnicalWorks")]
        public virtual SideZone? SideZone { get; set; }
        [InverseProperty("TechnicalWorks")]
        public virtual MonitoringCenter? MonitoringCenter { get; set; }
    }
}
