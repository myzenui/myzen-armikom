using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class AlarmCategory : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual int? Type { get; set; }

        [InverseProperty("AlarmCategory")]
        public virtual IList<SideMail> Mails { get; set; } = new ObservableCollection<SideMail>();
        [InverseProperty("AlarmCategory")]
        public virtual IList<SideMobile> Mobiles { get; set; } = new ObservableCollection<SideMobile>();
        [InverseProperty("AlarmCategory")]
        public virtual IList<SideSms> SmsMessages { get; set; } = new ObservableCollection<SideSms>();
        [InverseProperty("AlarmCategory")]
        public virtual IList<Signal> Signals { get; set; } = new ObservableCollection<Signal>();
        [InverseProperty("AlarmCategory")]
        public virtual IList<SideNote> Notes { get; set; } = new ObservableCollection<SideNote>();
    }
}
