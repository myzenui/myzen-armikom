using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class TechnicalPerson : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Phone1 { get; set; }
        public virtual string? Phone2 { get; set; }
        public virtual string? Phone3 { get; set; }
        public virtual string? Mail { get; set; }
        public virtual string? Password { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("TechnicalPeople")]
        public virtual Dealer? Dealer { get; set; }
        [InverseProperty("ServicePerson")]
        public virtual IList<SideService> Services { get; set; } = new ObservableCollection<SideService>();
    }
}
