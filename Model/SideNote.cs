using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideNote : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Not { get; set; }
        public virtual DateTime? RecordDate { get; set; }
        public virtual DateTime? ValidDate { get; set; }
        public virtual string? FontColor { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Notes")]
        public virtual Side? Side { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Notes")]
        public virtual NoteType? NoteType { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Notes")]
        public virtual AlarmCategory? AlarmCategory { get; set; }
    }
}
