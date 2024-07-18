using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1_15_7.Models
{
    public class SanPham
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public double Gia { get; set; }
        public string HoatDong { get; set; }

        public SanPham(int id,string ten, string moTa, double gia, string hoatDong)
        {
            Id = id;
            Ten = ten;
            MoTa = moTa;
            Gia = gia;
            HoatDong = hoatDong;
        }
        public class ApplicationDbContext : DbContext
        {
            public DbSet<SanPham> SanPhams { get; set; }
        }
    }
}