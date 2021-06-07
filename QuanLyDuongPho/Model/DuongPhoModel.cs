using System.Collections.Generic;
using MySql.Data.MySqlClient;
using QuanLyDuongPho.entity;
using QuanLyDuongPho.entity;
using QuanLyDuongPho.Helper;

namespace QuanLyDuongPho.Model
{
    public class DuongPhoModel
    {
        public bool Save(DuongPho duongPho)
        {
            var connection = ConectionHelper.GetConnection();
            connection.Open();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"INSERT INTO duongphos (Ma,Ten,MoTa,NgaySuDung,LichSu,TenQuan,TrangThai) " +
                                       $"VALUES ('{duongPho.Ma}', '{duongPho.Ten}', '{duongPho.MoTa}', '{duongPho.NgaySuDung}','{duongPho.Lichsu}', '{duongPho.TenQuan}', {duongPho.TrangThai});";
            var result = mySqlCommand.ExecuteNonQuery();
            connection.Close();
            if (result == 1)
            {
                return true;
            }

            return false;
        }

        public List<DuongPho> FindAll()
        {
            var listDuongPho = new List<DuongPho>();
            var connection = ConectionHelper.GetConnection();
            connection.Open();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"select * from duongphos";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                var ma = mySqlDataReader.GetString("Ma");
                var ten = mySqlDataReader.GetString("Ten");
                var moTa = mySqlDataReader.GetString("MoTa");
                var ngaySuDung = mySqlDataReader.GetDateTime("NgaySuDung");
                var lichSu = mySqlDataReader.GetString("LichSu");
                var tenQuan = mySqlDataReader.GetString("TenQuan");
                var trangThai = mySqlDataReader.GetInt32("TrangThai");
                DuongPho duongPho = new DuongPho();
                duongPho.Ma = ma;
                duongPho.Ten = ten;
                duongPho.MoTa = moTa;
                duongPho.NgaySuDung = ngaySuDung;
                duongPho.Lichsu = lichSu;
                duongPho.TenQuan = tenQuan;
                duongPho.TrangThai = trangThai;
                listDuongPho.Add(duongPho);
            }

            mySqlDataReader.Close();
            return listDuongPho;
        }

        public DuongPho FindById(string id)
        {
            DuongPho duongPho = null;
            var connection = ConectionHelper.GetConnection();
            connection.Open();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"select * from duongphos where Ma = '{id}'";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            if (mySqlDataReader.Read())
            {
                var ma = mySqlDataReader.GetString("Ma");
                var ten = mySqlDataReader.GetString("Ten");
                var moTa = mySqlDataReader.GetString("MoTa");
                var ngaySuDung = mySqlDataReader.GetDateTime("NgaySuDung");
                var lichSu = mySqlDataReader.GetString("LichSu");
                var tenQuan = mySqlDataReader.GetString("TenQuan");
                var trangThai = mySqlDataReader.GetInt32("TrangThai");
                duongPho = new DuongPho();
                duongPho.Ma = ma;
                duongPho.Ten = ten;
                duongPho.MoTa = moTa;
                duongPho.NgaySuDung = ngaySuDung;
                duongPho.Lichsu = lichSu;
                duongPho.TenQuan = tenQuan;
                duongPho.TrangThai = trangThai;
            }

            mySqlDataReader.Close();
            return duongPho;
        }

        public bool Update(string id, DuongPho updateDuongPho)
        {
            DuongPho duongPho = FindById(id);
            if (duongPho == null)
            {
                return false;
            }

            duongPho.Ten = updateDuongPho.Ten;
            duongPho.MoTa = updateDuongPho.MoTa;
            duongPho.NgaySuDung = updateDuongPho.NgaySuDung;
            duongPho.Lichsu = updateDuongPho.Lichsu;
            duongPho.TenQuan = updateDuongPho.TenQuan;
            duongPho.TrangThai = updateDuongPho.TrangThai;
            var connection = ConectionHelper.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText =
                $"update duongphos set Ten = '{duongPho.Ten}', MoTa = '{duongPho.MoTa}', NgaySuDung = '{duongPho.NgaySuDung}', LichSu = '{duongPho.Lichsu}', TenQuan = '{duongPho.TenQuan}', TrangThai = {duongPho.TrangThai} ";
            var result = mySqlCommand.ExecuteNonQuery();
            if (result == 1)
            {
                return true;
            }

            return false;
        }

        public bool Delete(string id)
        {
            DuongPho duongPho = FindById(id);
            if (duongPho == null)
            {
                return false;
            }

            var connection = ConectionHelper.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"delete from duongphos where Ma = '{id}'";
            int result = mySqlCommand.ExecuteNonQuery();
            if (result == 1)
            {
                return true;
            }

            return false;
        }
    }

}