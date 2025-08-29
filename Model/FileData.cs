using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class FileData : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual int? Size { get; set; }
        public virtual string? FileName { get; set; }
        public virtual byte[]? Content { get; set; }

        [InverseProperty("Recording")]
        public virtual IList<SideCall> Calls { get; set; } = new ObservableCollection<SideCall>();
        [InverseProperty("File")]
        public virtual IList<SideDocument> Documents { get; set; } = new ObservableCollection<SideDocument>();
    }
}
