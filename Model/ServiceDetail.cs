using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class ServiceDetail : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Description { get; set; }
        public virtual DateTime? RecordDateTime { get; set; }

        [InverseProperty("Details")]
        public virtual SideService? SideService { get; set; }
    }
}
