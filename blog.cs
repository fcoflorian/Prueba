
///// Models

 public class BlogPost
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }
        [Required]
        public string Contenido { get; set; }
        [StringLength(100)]
        public string Autor { get; set; }
        public DateTime Publicacion { get; set; }
        public List<Comentario> Comentarios { get; set; }
    }



    //// Models

    public class Comentario
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public string Autor { get; set; }
        public int BlogPostId { get; set; }
        [ForeignKey("BlogPostId")]
        public BlogPost BlogPosts { get; set; }
    }


    ///Context

    public class BlogContext : DbContext
    {
        public BlogContext() : base("DefaultConnection")
        {

        }

        public DbSet<BlogPost> Blogposts { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

    }


///// connectionString

<connectionStrings>
    <add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=BlogPostDB;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\BlogPostDB.mdf" providerName="System.Data.SqlClient" />
  </connectionStrings>

  //fgwr