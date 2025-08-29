using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class AnonymousPacket : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Product { get; set; }
        public virtual string? Receiver { get; set; }
        public virtual string? Event { get; set; }
        public virtual DateTime? CreateDateTime { get; set; }
        public virtual bool? IsError { get; set; }
    }
}
