using System;
using System.Collections.Generic;

#nullable disable

namespace GameStoreT2.Models.DB
{
    public partial class VidG
    {
        public string VidKey { get; set; }
        public string VideoGameName { get; set; }
        public string Ratings { get; set; }
        public string Developer { get; set; }
        public decimal? Price { get; set; }
    }
}
