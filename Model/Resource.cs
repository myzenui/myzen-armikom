using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class Resource : BaseEntity
    {
        public virtual Guid? Key { get; set; }
        public virtual string? Caption { get; set; }
        public virtual int? Color_Int { get; set; }

        [InverseProperty("Resources")]
        public virtual IList<Event> Events { get; set; } = new ObservableCollection<Event>();
    }
}
