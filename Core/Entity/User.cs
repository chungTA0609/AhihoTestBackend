using System;

namespace Core.Entity
{
    public class User : BaseEntity
    {
        public string username { get; set; }
        public bool gender  { get; set; }
        public Geo_Location geo_location { get; set; }
        public int geo_location_id { get; set; }
        public DateTime birthday { get; set; }
        public DateTime last_active { get; set; }
    }
}