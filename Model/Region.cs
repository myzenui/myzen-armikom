using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class Region : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }

        [InverseProperty("Region")]
        public virtual IList<Dealer> Dealers { get; set; } = new ObservableCollection<Dealer>();
        [InverseProperty("Region")]
        public virtual IList<Side> Sides { get; set; } = new ObservableCollection<Side>();
    }
}
