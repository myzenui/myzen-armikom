using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SmsSetting : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? SmsUser { get; set; }
        public virtual string? SmsPassword { get; set; }
        public virtual string? SmsPrefix { get; set; }
        public virtual string? SmsOrg { get; set; }
        public virtual int? Provider { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("SmsSettings")]
        public virtual MonitoringCenter? MonitoringCenter { get; set; }
    }
}
