using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class Dealer : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? FullName { get; set; }
        public virtual string? Address { get; set; }
        public virtual string? Contact1 { get; set; }
        public virtual string? Contact2 { get; set; }
        public virtual string? Mail1 { get; set; }
        public virtual string? Mail2 { get; set; }
        public virtual string? Mail3 { get; set; }
        public virtual string? TaxNo { get; set; }
        public virtual string? TaxOffice { get; set; }
        public virtual bool? Active { get; set; }
        public virtual DateTime? RecordDateTime { get; set; }
        public virtual string? OnCallServiceNumber { get; set; }
        public virtual byte[]? Logo { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Dealers")]
        public virtual City? City { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Dealers")]
        public virtual Region? Region { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Dealers")]
        public virtual District? District { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Dealers")]
        public virtual MonitoringCenter? MonitoringCenter { get; set; }
        [InverseProperty("ReleatedDealer")]
        public virtual IList<Dealer> SubDealers { get; set; } = new ObservableCollection<Dealer>();
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("SubDealers")]
        public virtual Dealer? ReleatedDealer { get; set; }
        [InverseProperty("Dealer")]
        public virtual IList<DealerAccountType> AccountTypes { get; set; } = new ObservableCollection<DealerAccountType>();
        [InverseProperty("Dealer")]
        public virtual IList<DealerSideNo> SideNumbers { get; set; } = new ObservableCollection<DealerSideNo>();
        [InverseProperty("Dealer")]
        public virtual IList<Side> Sides { get; set; } = new ObservableCollection<Side>();
        [InverseProperty("Installer")]
        public virtual IList<Side> InstalledSides { get; set; } = new ObservableCollection<Side>();
        [InverseProperty("Dealer")]
        public virtual IList<TechnicalPerson> TechnicalPeople { get; set; } = new ObservableCollection<TechnicalPerson>();
        [InverseProperty("ServiceCompany")]
        public virtual IList<SideService> Services { get; set; } = new ObservableCollection<SideService>();
    }
}
