using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class EventRaw : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual DateTime? RecordDateTime { get; set; }
        public virtual string? RawData { get; set; }

        [InverseProperty("EventRaws")]
        public virtual Receiver? Receiver { get; set; }
        [InverseProperty("EventRaw")]
        public virtual IList<SignalEvent> SignalEvents { get; set; } = new ObservableCollection<SignalEvent>();
    }
}
