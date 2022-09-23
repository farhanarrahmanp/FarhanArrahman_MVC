using System;
namespace FarhanArrahman_MVC.Models
{
    public class Pegawai
    {
        public string Id { get; set; }
        public string Nama { get; set; }
        public string TmptLahir { get; set; }
        public string TglLahir { get; set; }
        public char Gender { get; set; }
        public string Agama { get; set; }
        public string Alamat { get; set; }
        public string Email { get; set; }
        public string NoHp { get; set; }
        public string Foto { get; set; }
        public string PosisiNama { get; set; }
        public string KantorAlamat { get; set; }

        public Pegawai()
        {
        }
    }
}
