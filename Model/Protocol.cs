using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class Protocol : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual int? ProtocolType { get; set; }

        [InverseProperty("Protocols")]
        public virtual IList<Model> Models { get; set; } = new ObservableCollection<Model>();
        [InverseProperty("Protocol")]
        public virtual IList<Side> Sides { get; set; } = new ObservableCollection<Side>();
        [InverseProperty("Protocol")]
        public virtual IList<Signal> Signals { get; set; } = new ObservableCollection<Signal>();
    }
}
