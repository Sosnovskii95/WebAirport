using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAirport.Data
{
    public class AirportContextInitializer : CreateDatabaseIfNotExists<AirportContext>
    {
        protected override void Seed(AirportContext context)
        {
            DbInit.Initialize(context);
        }
    }
}