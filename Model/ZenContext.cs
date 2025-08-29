using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Model
{
    public class ZenContext : DbContext
    {
        public ZenContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ActiveCategory> ActiveCategories { get; set; }
        public DbSet<AlarmCategory> AlarmCategories { get; set; }
        public DbSet<AnonymousPacket> AnonymousPackets { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<DeviceRegex> DeviceRegexs { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<EmergencyPhone> EmergencyPhones { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<FileData> FileDatas { get; set; }
        public DbSet<Holiday> Holidaies { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<MonitoringCenter> MonitoringCenters { get; set; }
        public DbSet<AccountItem> AccountItems { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<MailSetting> MailSettings { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Protocol> Protocols { get; set; }
        public DbSet<Receiver> Receivers { get; set; }
        public DbSet<EventRaw> EventRaws { get; set; }
        public DbSet<ReceiverLine> ReceiverLines { get; set; }
        public DbSet<ReceiverType> ReceiverTypes { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<DealerAccountType> DealerAccountTypes { get; set; }
        public DbSet<DealerSideNo> DealerSideNos { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<SideAlarm> SideAlarms { get; set; }
        public DbSet<SideType> SideTypes { get; set; }
        public DbSet<Side> Sides { get; set; }
        public DbSet<ClosingDelay> ClosingDelaies { get; set; }
        public DbSet<MobileMessage> MobileMessages { get; set; }
        public DbSet<SideAgreement> SideAgreements { get; set; }
        public DbSet<SideCall> SideCalls { get; set; }
        public DbSet<SideContact> SideContacts { get; set; }
        public DbSet<SideDocument> SideDocuments { get; set; }
        public DbSet<SideHoliday> SideHolidaies { get; set; }
        public DbSet<SideInvoice> SideInvoices { get; set; }
        public DbSet<SideMail> SideMails { get; set; }
        public DbSet<SideMobile> SideMobiles { get; set; }
        public DbSet<SideProduct> SideProducts { get; set; }
        public DbSet<SideReason> SideReasons { get; set; }
        public DbSet<SideSms> SideSmses { get; set; }
        public DbSet<SideUser> SideUsers { get; set; }
        public DbSet<SideZone> SideZones { get; set; }
        public DbSet<Signal> Signals { get; set; }
        public DbSet<NoteType> NoteTypes { get; set; }
        public DbSet<PassiveSignal> PassiveSignals { get; set; }
        public DbSet<SideControl> SideControls { get; set; }
        public DbSet<SideNote> SideNotes { get; set; }
        public DbSet<SignalBloke> SignalBlokes { get; set; }
        public DbSet<SignalEvent> SignalEvents { get; set; }
        public DbSet<AlarmEvent> AlarmEvents { get; set; }
        public DbSet<SignalExplanations> SignalExplanationses { get; set; }
        public DbSet<SmsSetting> SmsSettings { get; set; }
        public DbSet<TechnicalPerson> TechnicalPersons { get; set; }
        public DbSet<SideService> SideServices { get; set; }
        public DbSet<ServiceDetail> ServiceDetails { get; set; }
        public DbSet<TechnicalWork> TechnicalWorks { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }
        public DbSet<WaitingEvent> WaitingEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                             .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }
        }
    }
}
