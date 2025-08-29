using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class Brand : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }

        [InverseProperty("Brand")]
        public virtual IList<Model> Models { get; set; } = new ObservableCollection<Model>();
        [InverseProperty("Brand")]
        public virtual IList<Side> Sides { get; set; } = new ObservableCollection<Side>();
    }
}
