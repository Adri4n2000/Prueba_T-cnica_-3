using Dapper;
using MySql.Data.MySqlClient;
using NetCore6APIMySQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore6APIMySQL.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly MySQLConfiguration _connectionString;
        public UsuarioRepository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }
        public async Task<bool> DeleteUsuario(Usuario usuario)
        {
            var db = dbConnection();

            var sql = @"DELETE FROM usuarios WHERE ID = @ID";

            var result = await db.ExecuteAsync(sql, new { ID = usuario.ID });

            return result > 0;
        }

        public async Task<IEnumerable<Usuario>> GetAllUsuarios()
        {
            var db = dbConnection();

            var sql = @"SELECT ID, Numero_Documento, Primer_Nombre, Segundo_Nombre, Primer_Apellido, Segundo_Apellido, Telefono, Correo, Direccion, Edad, Genero FROM usuarios";

            return await db.QueryAsync<Usuario>(sql, new { });
        }

        public async Task<Usuario> GetDetails(int ID)
        {
            var db = dbConnection();

            var sql = @"SELECT ID, Numero_Documento, Primer_Nombre, Segundo_Nombre, Primer_Apellido, Segundo_Apellido, Telefono, Correo, Direccion, Edad, Genero FROM usuarios WHERE ID = @ID";

            return await db.QueryFirstOrDefaultAsync<Usuario>(sql, new { ID = ID });
        }

        public async Task<bool> InsertUsuario(Usuario usuario)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO usuarios (Numero_Documento, Primer_Nombre, Segundo_Nombre, Primer_Apellido, Segundo_Apellido, Telefono, Correo, Direccion, Edad, Genero) VALUES (@Numero_Documento, @Primer_Nombre, @Segundo_Nombre, @Primer_Apellido, @Segundo_Apellido, @Telefono, @Correo, @Direccion, @Edad, @Genero)";

            var result = await db.ExecuteAsync(sql, new 
            { usuario.Numero_Documento, usuario.Primer_Nombre, usuario.Segundo_Nombre, usuario.Primer_Apellido, usuario.Segundo_Apellido, usuario.Telefono, usuario.Correo, usuario.Direccion, usuario.Genero  });

            return result > 0; 
        }

        public async Task<bool> UpdateUsuario(Usuario usuario)
        {
            var db = dbConnection();

            var sql = @"UPDATE usuarios SET Numero_Documento = @Numero_Documento, Primer_Nombre = @Primer_Nombre, Segundo_Nombre = @Segundo_Nombre, Primer_Apellido = @Primer_Apellido, Segundo_Apellido = @Segundo_Apellido,  Telefono = @Telefono, Correo = @Correo, Direccion = @Direccion, Edad = @Edad, Genero = @Genero WHERE ID = @ID";

            var result = await db.ExecuteAsync(sql, new
            { usuario.Numero_Documento, usuario.Primer_Nombre, usuario.Segundo_Nombre, usuario.Primer_Apellido, usuario.Segundo_Apellido, usuario.Telefono, usuario.Correo, usuario.Direccion, usuario.Genero, usuario.ID });

            return result > 0;
        }
    }
}
