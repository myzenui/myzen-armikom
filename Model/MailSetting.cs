using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class MailSetting : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? MailUser { get; set; }
        public virtual string? MailPassword { get; set; }
        public virtual string? MailHost { get; set; }
        public virtual int? MailPort { get; set; }
        public virtual string? MailSender { get; set; }

        [InverseProperty("MailSettings")]
        public virtual MonitoringCenter? MonitoringCenter { get; set; }
    }
}
