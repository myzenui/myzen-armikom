using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class ServiceType : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }

        [InverseProperty("ServiceType")]
        public virtual IList<SideService> Services { get; set; } = new ObservableCollection<SideService>();
    }
}
