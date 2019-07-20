using JapanesePractise.Core.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapanesePractise.Repositories
{
    public class JapanesePractiseContext : DbContext
    {
        public JapanesePractiseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Word> Words { get; set; }
        public DbSet<Noun> Nouns { get; set; }
        public DbSet<Verb> Verbs { get; set; }
        public DbSet<Adjective> Adjectives { get; set; }
        public DbSet<Adverb> Adverbs { get; set; }

    }
}
