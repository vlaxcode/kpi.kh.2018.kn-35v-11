namespace MyResume
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=MyMode")
        {
        }

        public virtual DbSet<Response> Response { get; set; }

    }
}
