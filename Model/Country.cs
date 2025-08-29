using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class Country : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Code { get; set; }

        [InverseProperty("Country")]
        public virtual IList<City> Cities { get; set; } = new ObservableCollection<City>();
        [InverseProperty("Country")]
        public virtual IList<MonitoringCenter> MonitoringCenters { get; set; } = new ObservableCollection<MonitoringCenter>();
    }
}
