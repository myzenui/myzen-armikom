using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class Signal : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual bool? Alert { get; set; }
        public virtual int? Priority { get; set; }
        public virtual string? BackColor { get; set; }
        public virtual string? FrontColor { get; set; }
        public virtual string? Notes { get; set; }
        public virtual string? NotificationText { get; set; }
        public virtual string? SignalCode { get; set; }
        public virtual string? EventCode { get; set; }
        public virtual string? UserCode { get; set; }
        public virtual string? UserNo { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Signals")]
        public virtual AlarmCategory? AlarmCategory { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Signals")]
        public virtual Protocol? Protocol { get; set; }
        [InverseProperty("Signal")]
        public virtual IList<NoteType> NoteTypes { get; set; } = new ObservableCollection<NoteType>();
        [InverseProperty("Signal")]
        public virtual IList<PassiveSignal> PassiveSignals { get; set; } = new ObservableCollection<PassiveSignal>();
        [InverseProperty("Signal")]
        public virtual IList<SideControl> SideControls { get; set; } = new ObservableCollection<SideControl>();
        [InverseProperty("ControlSignal")]
        public virtual IList<SideControl> ControlForSignals { get; set; } = new ObservableCollection<SideControl>();
        [InverseProperty("Signal")]
        public virtual IList<SignalBloke> Blokes { get; set; } = new ObservableCollection<SignalBloke>();
        [InverseProperty("Signal")]
        public virtual IList<SignalEvent> Events { get; set; } = new ObservableCollection<SignalEvent>();
    }
}
