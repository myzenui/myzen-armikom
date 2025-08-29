using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideCall : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Extention { get; set; }
        public virtual DateTime? CallDateTime { get; set; }
        public virtual string? Phone { get; set; }
        public virtual string? Channel { get; set; }
        public virtual string? DstChannel { get; set; }
        public virtual int? Duration { get; set; }
        public virtual int? CallDuration { get; set; }
        public virtual string? CallState { get; set; }
        public virtual string? UniqueId { get; set; }
        public virtual string? RecordingFile { get; set; }
        public virtual string? Dcontext { get; set; }
        public virtual int? CallType { get; set; }
        public virtual DateTime? AlarmTime { get; set; }
        public virtual bool? IsPostponed { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Calls")]
        public virtual Side? Side { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Calls")]
        public virtual FileData? Recording { get; set; }
    }
}
