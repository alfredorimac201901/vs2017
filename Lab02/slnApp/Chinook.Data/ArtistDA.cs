using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chinook.Entities;

namespace Chinook.Data
{
    public class ArtistDA:BaseConection
    {
        public int getCount()
        {
            var result = 0;
            var sql = "select count (1) from Artist";
            using (IDbConnection cn = new SqlConnection(getConection()))
            {
                cn.Open();
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                result = (int)cmd.ExecuteScalar();

            }

            return result;
        }

        public IEnumerable<Artist> Gets()
        {
            var result = new List<Artist>();
            var sql = "select ArtistId,Name from Artist";
            using (IDbConnection cn = new SqlConnection(getConection()))
            {
                cn.Open();
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var entity = new Artist();
                    indice = reader.GetOrdinal("ArtistId");
                    entity.ArtistId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Name");
                    entity.Name = reader.GetString(indice);
                    result.Add(entity);

                }

            }
            return result;


        }
        
        public IEnumerable<Artist> GetsWithParam(string nombre)
        {
            var result = new List<Artist>();
            var sql = "select ArtistId,Name from Artist where name like @filtropornombre";
            using (IDbConnection cn = new SqlConnection(getConection()))
            {
                cn.Open();
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cmd.Parameters.Add(new SqlParameter("@filtropornombre", nombre));
                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var entity = new Artist();
                    indice = reader.GetOrdinal("ArtistId");
                    entity.ArtistId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Name");
                    entity.Name = reader.GetString(indice);
                    result.Add(entity);

                }

            }
            return result;


        }

        public IEnumerable<Artist> GetsWithParam2(string nombre)
        {
            var result = new List<Artist>();
            var sql = "usp_GetArtistis";
            using (IDbConnection cn = new SqlConnection(getConection()))
            {
                cn.Open();
                IDbCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.Add(new SqlParameter("@FiltroPorNombre", nombre));
                var reader = cmd.ExecuteReader();
                var indice = 0;
                while (reader.Read())
                {
                    var entity = new Artist();
                    indice = reader.GetOrdinal("ArtistId");
                    entity.ArtistId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Name");
                    entity.Name = reader.GetString(indice);
                    result.Add(entity);

                }

            }
            return result;


        }

        public int  InsertArtist(Artist entity)
        {
            var result = 0;
            var sql = "usp_InsertArtist";
            using (IDbConnection cn = new SqlConnection(getConection()))
            {
                cn.Open();
                IDbCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.Add(new SqlParameter("@Nombre", entity.Name));

                result = Convert.ToInt32(cmd.ExecuteScalar());
           

            }
            return result;


        }
    }
}
