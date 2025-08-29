using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class Product : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? FullName { get; set; }
        public virtual string? Comment { get; set; }

        [InverseProperty("Product")]
        public virtual IList<SideProduct> Sides { get; set; } = new ObservableCollection<SideProduct>();
    }
}
