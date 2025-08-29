using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideMail : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? MailTo { get; set; }
        public virtual string? MailText { get; set; }
        public virtual DateTime? RecordDate { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Mails")]
        public virtual Side? Side { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Mails")]
        public virtual AlarmCategory? AlarmCategory { get; set; }
    }
}
