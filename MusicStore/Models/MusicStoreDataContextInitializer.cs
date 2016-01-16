using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class MusicStoreDataContextInitializer : DropCreateDatabaseAlways<MusicStoreDataContext>
    {
        protected override void Seed(MusicStoreDataContext context)
        {
            Artist artist = new Artist() { Name = "First artist" };
            context.Artists.Add(artist);
            context.Albums.Add(new Album() {Artist = artist, Title = "first Album" });
            context.Albums.Add(new Album() { Artist = artist, Title = "second Album" });

            context.Albums.Add(new Album()
            {
                Artist = context.Artists.Add(new Artist(){
                    Name ="Tupac"
                }),
                Title = "All Eyes on Me"
            });



            context.Artists.Add(new Artist() { Name="Second artist"});


            context.Artists.Add(new SoloArtist()
            {

                Name = "Solo Artis ",
                Instrument  = "Guitar and Piano"
            });
            context.SaveChanges();
          
        }
    }
}