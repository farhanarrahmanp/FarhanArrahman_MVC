using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FarhanArrahman_MVC.Models;
using System.Data.SqlClient;

namespace FarhanArrahman_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        SqlConnection sqlConnection;

        string connectionString = "Data Source=localhost;" +
            "Initial Catalog=DbAppPresensi;" +
            "User Id=sa;Password=SQL Server 2017;";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // READ
        // GET: /<controller>/
        public IActionResult Pegawai()
        {
            string query = "SELECT Pe.Id, Pe.Nama, Pe.TmptLahir, Pe.TglLahir, " +
                "Pe.Gender, Pe.Agama, Pe.Alamat, Pe.Email, Pe.NoHp, Pe.Foto, " +
                "Po.Nama 'PosisiNama', Ka.Alamat 'KantorAlamat' " +
                "FROM Pegawai Pe " +
                "JOIN Posisi Po ON Pe.PosisiId = Po.Id " +
                "JOIN Kantor Ka ON Pe.KantorId = Ka.Id";

            sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            List<Pegawai> Departments = new List<Pegawai>();

            try
            {
                sqlConnection.Open();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            Pegawai department = new Pegawai();
                            department.Id = Convert.ToString(sqlDataReader[0]);
                            department.Nama = sqlDataReader[1].ToString();
                            department.TmptLahir = sqlDataReader[2].ToString();
                            department.TglLahir = sqlDataReader[3].ToString();
                            department.Gender = Convert.ToChar(sqlDataReader[4]);
                            department.Agama = sqlDataReader[5].ToString();
                            department.Alamat = sqlDataReader[6].ToString();
                            department.Email = sqlDataReader[7].ToString();
                            department.NoHp = sqlDataReader[8].ToString();
                            department.Foto = sqlDataReader[9].ToString();
                            department.PosisiNama = sqlDataReader[10].ToString();
                            department.KantorAlamat = sqlDataReader[11].ToString();
                            Departments.Add(department);
                        }
                    }
                    sqlDataReader.Close();
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            return View(Departments);
        }

        public IActionResult Details(string pegawaiId)
        {
            string query = "SELECT Pe.Id, Pe.Nama, Pe.TmptLahir, Pe.TglLahir, " +
                "Pe.Gender, Pe.Agama, Pe.Alamat, Pe.Email, Pe.NoHp, Pe.Foto, " +
                "Po.Nama 'PosisiNama', Ka.Alamat 'KantorAlamat' " +
                "FROM Pegawai Pe " +
                "JOIN Posisi Po ON Pe.PosisiId = Po.Id " +
                "JOIN Kantor Ka ON Pe.KantorId = Ka.Id";

            sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            List<Pegawai> Departments = new List<Pegawai>();

            try
            {
                sqlConnection.Open();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            Pegawai department = new Pegawai();
                            department.Id = Convert.ToString(sqlDataReader[0]);
                            department.Nama = sqlDataReader[1].ToString();
                            department.TmptLahir = sqlDataReader[2].ToString();
                            department.TglLahir = sqlDataReader[3].ToString();
                            department.Gender = Convert.ToChar(sqlDataReader[4]);
                            department.Agama = sqlDataReader[5].ToString();
                            department.Alamat = sqlDataReader[6].ToString();
                            department.Email = sqlDataReader[7].ToString();
                            department.NoHp = sqlDataReader[8].ToString();
                            department.Foto = sqlDataReader[9].ToString();
                            department.PosisiNama = sqlDataReader[10].ToString();
                            department.KantorAlamat = sqlDataReader[11].ToString();
                            Departments.Add(department);
                        }
                    }
                    sqlDataReader.Close();
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            return View(Departments);
        }

        // CREATE
        // GET
        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pegawai pegawai)
        {
            using (SqlConnection sqlConnection =
                new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlTransaction sqlTransaction =
                    sqlConnection.BeginTransaction();

                using (SqlCommand pegawaiCommand = sqlConnection.CreateCommand())
                {
                    pegawaiCommand.Transaction = sqlTransaction;

                    pegawaiCommand.Parameters.AddRange(new[]
                    {
                        new SqlParameter("@pegawaiid", pegawai.Id),
                        new SqlParameter("@nama", pegawai.Nama),
                        new SqlParameter("@tmptlahir", pegawai.TmptLahir),
                        new SqlParameter("@tgllahir", pegawai.TglLahir),
                        new SqlParameter("@gender", pegawai.Gender),
                        new SqlParameter("@agama", pegawai.Agama),
                        new SqlParameter("@alamat", pegawai.Alamat),
                        new SqlParameter("@email", pegawai.Email),
                        new SqlParameter("@nohp", pegawai.NoHp),
                        new SqlParameter("@foto", pegawai.Foto),
                        new SqlParameter("@posisiid", pegawai.PosisiNama),
                        new SqlParameter("@kantorid", pegawai.KantorAlamat)
                    });

                    try
                    {
                        pegawaiCommand.CommandText = "INSERT INTO Pegawai " +
                            "VALUES (@pegawaiid, @nama, @tmptlahir, @tgllahir, @gender, @agama, @alamat, @email, @nohp, @foto, @posisiid, @kantorid)";
                        pegawaiCommand.ExecuteNonQuery();
                        sqlTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.InnerException);
                    }
                }
                sqlConnection.Close();
            }
            return View();
        }

        // UPDATE
        // GET
        public IActionResult Update()
        {
            string query = "SELECT Pe.Id, Pe.Nama, Pe.TmptLahir, Pe.TglLahir, " +
                "Pe.Gender, Pe.Agama, Pe.Alamat, Pe.Email, Pe.NoHp, Pe.Foto, " +
                "Po.Nama 'PosisiNama', Ka.Alamat 'KantorAlamat' " +
                "FROM Pegawai Pe " +
                "JOIN Posisi Po ON Pe.PosisiId = Po.Id " +
                "JOIN Kantor Ka ON Pe.KantorId = Ka.Id";

            sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            List<Pegawai> Departments = new List<Pegawai>();

            try
            {
                sqlConnection.Open();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            Pegawai department = new Pegawai();
                            department.Id = Convert.ToString(sqlDataReader[0]);
                            department.Nama = sqlDataReader[1].ToString();
                            department.TmptLahir = sqlDataReader[2].ToString();
                            department.TglLahir = sqlDataReader[3].ToString();
                            department.Gender = Convert.ToChar(sqlDataReader[4]);
                            department.Agama = sqlDataReader[5].ToString();
                            department.Alamat = sqlDataReader[6].ToString();
                            department.Email = sqlDataReader[7].ToString();
                            department.NoHp = sqlDataReader[8].ToString();
                            department.Foto = sqlDataReader[9].ToString();
                            department.PosisiNama = sqlDataReader[10].ToString();
                            department.KantorAlamat = sqlDataReader[11].ToString();
                            Departments.Add(department);
                        }
                    }
                    sqlDataReader.Close();
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            return View(Departments);
        }
        // POST
        public IActionResult Update(Pegawai pegawai)
        {
            using (SqlConnection sqlConnection =
                new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlTransaction sqlTransaction =
                    sqlConnection.BeginTransaction();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.Transaction = sqlTransaction;

                sqlCommand.Parameters.AddRange(new[]
                    {
                        new SqlParameter("@pegawaiid", pegawai.Id),
                        new SqlParameter("@nama", pegawai.Nama),
                        new SqlParameter("@tmptlahir", pegawai.TmptLahir),
                        new SqlParameter("@tgllahir", pegawai.TglLahir),
                        new SqlParameter("@gender", pegawai.Gender),
                        new SqlParameter("@agama", pegawai.Agama),
                        new SqlParameter("@alamat", pegawai.Alamat),
                        new SqlParameter("@foto", pegawai.Foto)
                    });

                try
                {
                    sqlCommand.CommandText = "UPDATE Akun SET " +
                        "Nama = @nama, TmptLahir = @tmptlahir, TglLahir = @tgllahir, Gender = @gender, Agama = @agama, Alamat = @alamat, Foto = @foto  " +
                        "WHERE Id = @id";
                    sqlCommand.ExecuteNonQuery();
                    sqlTransaction.Commit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException);
                }
            }
            return View();
        }

        // DELETE
        // GET
        public IActionResult Delete()
        {
            string query = "SELECT Pe.Id, Pe.Nama, Pe.TmptLahir, Pe.TglLahir, " +
                "Pe.Gender, Pe.Agama, Pe.Alamat, Pe.Email, Pe.NoHp, Pe.Foto, " +
                "Po.Nama 'PosisiNama', Ka.Alamat 'KantorAlamat' " +
                "FROM Pegawai Pe " +
                "JOIN Posisi Po ON Pe.PosisiId = Po.Id " +
                "JOIN Kantor Ka ON Pe.KantorId = Ka.Id";

            sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            List<Pegawai> Departments = new List<Pegawai>();

            try
            {
                sqlConnection.Open();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            Pegawai department = new Pegawai();
                            department.Id = Convert.ToString(sqlDataReader[0]);
                            department.Nama = sqlDataReader[1].ToString();
                            department.TmptLahir = sqlDataReader[2].ToString();
                            department.TglLahir = sqlDataReader[3].ToString();
                            department.Gender = Convert.ToChar(sqlDataReader[4]);
                            department.Agama = sqlDataReader[5].ToString();
                            department.Alamat = sqlDataReader[6].ToString();
                            department.Email = sqlDataReader[7].ToString();
                            department.NoHp = sqlDataReader[8].ToString();
                            department.Foto = sqlDataReader[9].ToString();
                            department.PosisiNama = sqlDataReader[10].ToString();
                            department.KantorAlamat = sqlDataReader[11].ToString();
                            Departments.Add(department);
                        }
                    }
                    sqlDataReader.Close();
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            return View(Departments);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string pegawaiId)
        {
            try
            {
                using (SqlConnection sqlConnection =
                                new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM Pegawai WHERE Id = '" + pegawaiId + "'", sqlConnection))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Redirect("/Home/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
