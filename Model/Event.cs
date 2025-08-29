using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class Event : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Subject { get; set; }
        public virtual string? Description { get; set; }
        public virtual DateTime? StartOn { get; set; }
        public virtual DateTime? EndOn { get; set; }
        public virtual bool? AllDay { get; set; }
        public virtual string? Location { get; set; }
        public virtual int? Label { get; set; }
        public virtual int? Status { get; set; }
        public virtual int? Type { get; set; }
        public virtual string? RecurrenceInfoXml { get; set; }
        public virtual string? ReminderInfoXml { get; set; }
        public virtual TimeSpan? RemindIn { get; set; }
        public virtual DateTime? AlarmTime { get; set; }
        public virtual bool? IsPostponed { get; set; }

        [InverseProperty("RecurrencePattern")]
        public virtual IList<Event> RecurrenceEvents { get; set; } = new ObservableCollection<Event>();
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("RecurrenceEvents")]
        public virtual Event? RecurrencePattern { get; set; }
        [InverseProperty("Events")]
        public virtual IList<Resource> Resources { get; set; } = new ObservableCollection<Resource>();
    }
}
