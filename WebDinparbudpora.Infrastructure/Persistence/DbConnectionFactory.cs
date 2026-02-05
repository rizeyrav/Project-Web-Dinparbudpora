// DbConnectionFactory : Berfungsi sebagai Koneksi kedatabase
using System.Data;
using Microsoft.Extensions.Configuration;
using Npgsql;

public class DbConnectionFactory
{
    private readonly IConfiguration _configuration;

    public DbConnectionFactory(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IDbConnection Create()
    {
        return new NpgsqlConnection( _configuration.GetConnectionString("DefaultConnection"));
    }
}