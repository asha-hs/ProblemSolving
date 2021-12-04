using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinyUrlAPI.Domains
{
    public class URLData
    {
        public int Id { get; set; }
        public string LongUrl { get; set; }
        public string  ShortUrl { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime ExpiresAt { get; set; }

    }
}
