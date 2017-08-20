using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices
{
    public partial class IncidentDatabaseEntities
    {
        private IncidentDatabaseEntities(string connectionString)
        : base(connectionString)
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public static IncidentDatabaseEntities Create()
        {
            return new IncidentDatabaseEntities("name=IncidentDatabaseEntities");
        }
    }
}
