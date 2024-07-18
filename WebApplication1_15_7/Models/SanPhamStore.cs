using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1_15_7.Models
{
    public static class SanPhamStore
    {
        private static List<SanPham> _sanPhams = new List<SanPham>();

        public static List<SanPham> GetSanPhams()
        {
            return _sanPhams;
        }

        public static void AddSanPham(SanPham sanPham)
        {
            // Set Id for new product
            if (_sanPhams.Count > 0)
            {
                sanPham.Id = _sanPhams.Max(s => s.Id) + 1;
            }
            else
            {
                sanPham.Id = 1;
            }
            _sanPhams.Add(sanPham);
        }

        public static void UpdateSanPham(SanPham sanPham)
        {
            var existingSanPham = _sanPhams.FirstOrDefault(s => s.Id == sanPham.Id);
            if (existingSanPham != null)
            {
                existingSanPham.Ten = sanPham.Ten;
                existingSanPham.Gia = sanPham.Gia;
                existingSanPham.MoTa = sanPham.MoTa;
                existingSanPham.HoatDong = sanPham.HoatDong;
            }
        }

        public static void RemoveSanPham(int id)
        {
            var sanPham = _sanPhams.FirstOrDefault(s => s.Id == id);
            if (sanPham != null)
            {
                _sanPhams.Remove(sanPham);
            }
        }
    }
}