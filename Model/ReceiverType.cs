using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class ReceiverType : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }

        [InverseProperty("ReceiverTypes")]
        public virtual IList<Receiver> Receivers { get; set; } = new ObservableCollection<Receiver>();
    }
}
