using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.EFCore.Configuration
{
    public class ConfigEnums
    {
        public Guid department1 { get; private set; }
        public Guid department2 { get; private set; }
        public Guid appointment1 { get; private set; }
        public Guid appointment2 { get; private set; }
        public Guid medicalTest1 { get; private set; }
        public Guid medicalTest2 { get; private set; }
        public Guid ward1 { get; private set; }
        public Guid ward2 { get; private set; }


        public ConfigEnums()
        {
            department1 = Guid.NewGuid();
            department2 = Guid.NewGuid();
            appointment1 = Guid.NewGuid();
            appointment2 = Guid.NewGuid();
            medicalTest1 = Guid.NewGuid();
            medicalTest2 = Guid.NewGuid();
            ward1 = Guid.NewGuid();
            ward2 = Guid.NewGuid();
        }
    }
}
