using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideDocument : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual DateTime? RecordDate { get; set; }
        public virtual byte[]? Path { get; set; }
        public virtual string? DocumentName { get; set; }

        [InverseProperty("Documents")]
        public virtual Side? Side { get; set; }
        [InverseProperty("Documents")]
        public virtual FileData? File { get; set; }
    }
}
