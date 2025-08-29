using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class ActiveCategory : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual bool? CategoryActive { get; set; }
        public virtual string? Comment { get; set; }

        [InverseProperty("ActiveCategory")]
        public virtual IList<SideReason> Reasons { get; set; } = new ObservableCollection<SideReason>();
    }
}
