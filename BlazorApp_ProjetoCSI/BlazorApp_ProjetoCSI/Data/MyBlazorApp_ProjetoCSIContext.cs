using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp_ProjetoCSI.Models;

namespace BlazorApp_ProjetoCSI.Data
{
    public class MyBlazorApp_ProjetoCSIContext : DbContext
    {
        public MyBlazorApp_ProjetoCSIContext (DbContextOptions<MyBlazorApp_ProjetoCSIContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp_ProjetoCSI.Models.Tarefas> Tarefas { get; set; } = default!;
        public DbSet<BlazorApp_ProjetoCSI.Models.Usuarios> Usuarios { get; set; } = default!;
    }
}
