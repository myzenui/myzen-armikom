using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class EmergencyPhone : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Phone1 { get; set; }
        public virtual string? Phone2 { get; set; }
        public virtual string? Phone3 { get; set; }
        public virtual string? Email { get; set; }
    }
}
