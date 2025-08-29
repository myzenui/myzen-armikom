using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class NoteType : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("NoteTypes")]
        public virtual Signal? Signal { get; set; }
        [InverseProperty("NoteType")]
        public virtual IList<SideNote> Notes { get; set; } = new ObservableCollection<SideNote>();
    }
}
