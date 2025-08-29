using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class Model : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Comment { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Models")]
        public virtual Brand? Brand { get; set; }
        [InverseProperty("Models")]
        public virtual IList<Protocol> Protocols { get; set; } = new ObservableCollection<Protocol>();
        [InverseProperty("Model")]
        public virtual IList<Side> Sides { get; set; } = new ObservableCollection<Side>();
    }
}
