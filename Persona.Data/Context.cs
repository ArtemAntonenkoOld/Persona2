using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Data
{
    public class Context:DbContext, IDisposable
    {
        public Context()
            :base("name=PersonaConnectionString") {
            Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
        }
        DbSet<User> Users { get; set; }
        DbSet<Article> Article { get; set; }
        DbSet<Tag> Tag { get; set; }
        DbSet<ArticleEventTag> ArticleEventTag { get; set; }
        DbSet<Event> Event { get; set; }
        DbSet<UserEvent> UserEvent { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
        }
    }

}
