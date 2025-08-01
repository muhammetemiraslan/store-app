using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Models;

public class DataContext : DbContext
{
    //constructor
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Slider> Sliders { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Slider>().HasData(
            new List<Slider> {
                new Slider { Id = 1, Title = "Slider 1", Description ="Slider 1 Desc",Image="slider-1.jpeg",IsActive=true, Index=0},
                new Slider { Id = 2, Title = "Slider 2", Description ="Slider 2 Desc",Image="slider-2.jpeg",IsActive=true, Index=1},
                new Slider { Id = 3, Title = "Slider 3", Description ="Slider 3 Desc",Image="slider-3.jpeg",IsActive=true, Index=2},
            }
        );

        modelBuilder.Entity<Category>().HasData(
            new List<Category>
            {
                new Category { Id = 1, CategoryName="Telefon", Url="telefon"},
                new Category { Id = 2, CategoryName="Elektronik", Url="Elektronik"},
                new Category { Id = 3, CategoryName="Beyaz Eşya", Url="beyaz-esya"},
                new Category { Id = 4, CategoryName="Giyim", Url="giyim"},
                new Category { Id = 5, CategoryName="Kozmetik", Url="kozmetik"},
                new Category { Id = 6, CategoryName="Saat", Url="saat"},
                new Category { Id = 7, CategoryName="Hoperlör", Url="Hoperlor"},
                new Category { Id = 8, CategoryName="Kulaklık", Url="kulaklik"},
                new Category { Id = 9, CategoryName="Bileşen", Url="bilesen"},
                new Category { Id = 10, CategoryName="Hobi", Url="hobi"},
            }
        );

        modelBuilder.Entity<Product>().HasData(
            new List<Product>()
            {
                new Product() {Id = 1, ProductName="Apple Watch 7", Price=10000, IsActive=false, Image="1.jpeg", IsHome=true, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", CategoryId = 1},
                new Product() {Id = 2, ProductName="Apple Watch 8", Price=20000, IsActive=true, Image="2.jpeg", IsHome=true, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", CategoryId = 2},
                new Product() {Id = 3, ProductName="Apple Watch 9", Price=30000, IsActive=false , Image="3.jpeg", IsHome=true, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", CategoryId = 2},
                new Product() {Id = 4, ProductName="Apple Watch 10", Price=40000, IsActive=true, Image="4.jpeg", IsHome=false, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", CategoryId = 3},
                new Product() {Id = 5, ProductName="Apple Watch 11", Price=50000, IsActive=true, Image="5.jpeg", IsHome=true, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", CategoryId = 3},
                new Product() {Id = 6, ProductName="Apple Watch 12", Price=60000, IsActive=false , Image="6.jpeg", IsHome=false, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", CategoryId = 2},
                new Product() {Id = 7, ProductName="Apple Watch 13", Price=70000, IsActive=true , Image="7.jpeg", IsHome=true, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", CategoryId = 1},
                new Product() {Id = 8, ProductName="Apple Watch 14", Price=80000, IsActive=false , Image="8.jpeg", IsHome=false, Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin faucibus a turpis ac porta. In feugiat eget arcu vel pulvinar. Nunc aliquam nisl a lacus semper, suscipit pharetra arcu elementum. Aenean commodo ipsum tortor, vel pellentesque eros hendrerit a. Morbi pulvinar vehicula urna, eu fringilla ipsum tincidunt at. Donec a sapien molestie, posuere libero nec, laoreet nisl. Duis pellentesque nunc eget dui viverra, pretium vehicula enim congue. Ut id quam eget arcu ullamcorper convallis nec ut ex. Duis auctor, lectus nec placerat bibendum, nibh purus rhoncus ex, id sollicitudin metus lectus aliquam ex. Donec et est et risus mattis vestibulum. Nulla sit amet mauris velit. Ut non lobortis ligula, non tincidunt ex. Suspendisse at ultricies nibh, sed interdum ipsum.", CategoryId = 4},
            }
        );
    }
}