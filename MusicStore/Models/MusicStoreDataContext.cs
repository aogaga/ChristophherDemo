﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class MusicStoreDataContext:DbContext
    {
        public MusicStoreDataContext()
            : base("DefaultConnection")
        {

        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<SoloArtist> SoloArtists { get; set; }

    }
}