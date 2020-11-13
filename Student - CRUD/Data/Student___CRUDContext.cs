using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student___CRUD.Models;

namespace Student___CRUD.Data
{
    public class Student___CRUDContext : DbContext
    {
        public Student___CRUDContext (DbContextOptions<Student___CRUDContext> options)
            : base(options)
        {
        }

        public DbSet<Student___CRUD.Models.Student> Student { get; set; }
    }
}
