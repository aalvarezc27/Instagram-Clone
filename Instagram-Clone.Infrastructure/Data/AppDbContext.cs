using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instagram_Clone.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Instagram_Clone.Infrastructure.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Follower> Followers { get; set; }
        public DbSet<PostComments> PostComments { get; set; }
        public DbSet<PostLikes> PostLikes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=C:\\sqlite\\instagram-clone.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<UserProfile>()
                .HasOne(up => up.User)
                .WithOne(u => u.UserProfile)
                .HasForeignKey<UserProfile>(u => u.UserId);

            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Follower>()
                .HasKey(f => new { f.FollowerId, f.FollowedId });

            modelBuilder.Entity<Follower>()
                .HasOne(f => f.FollowerUser)
                .WithMany(u => u.Following)
                .HasForeignKey(f => f.FollowerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Follower>()
                .HasOne(f => f.FollowedUser)
                .WithMany(u => u.Followers)
                .HasForeignKey(f => f.FollowedId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PostLikes>()
                .HasKey(p => new { p.UserId, p.PostId });

            modelBuilder.Entity<PostLikes>()
                .HasOne(p => p.Post)
                .WithMany(pl => pl.PostLikes)
                .HasForeignKey(p => p.PostId);

            modelBuilder.Entity<PostLikes>()
                .HasOne(pl => pl.User)
                .WithMany(u => u.PostLikes)
                .HasForeignKey(pl => pl.UserId);

            modelBuilder.Entity<PostComments>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<PostComments>()
                .HasOne(p => p.Post)
                .WithMany(pl => pl.PostComments)
                .HasForeignKey(p => p.PostId);

            modelBuilder.Entity<PostComments>()
                .HasOne(p => p.User)
                .WithMany(u => u.PostCommnets)
                .HasForeignKey(p => p.UserId);
        }
    }
}
