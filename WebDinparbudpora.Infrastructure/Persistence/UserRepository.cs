using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Npgsql;
using WebDinparbudpora.Application.Common.Interfaces;
using WebDinparbudpora.Domain.Entities;

namespace WebDinparbudpora.Infrastructure.Persistance;

public class UserRepository : IUserRepository
{
    private readonly string _dbConnection;

    // Menambahkan(mengambil konfigurasi) koneksi kedatabase
    public UserRepository(IConfiguration configuration)
    {
        _dbConnection = configuration.GetConnectionString("DefaultConnection")
        ?? throw new ArgumentException("Koneksi Database tidak ada");
    }

    // public Task<User?> GetByPassword(string password)
    // {
    //     throw new NotImplementedException();
    // }

    // public Task<User?> GetByUsername(string username)
    // {
    //     throw new NotImplementedException();
    // }

    // Mengambil data dari UserInterface
    public async Task<User?> GetByUsernameAsync(string username)
    {
        await using var connection = new NpgsqlConnection(_dbConnection);
        await connection.OpenAsync();

        var query ="SELECT id, username, password FROM users";

        await using var command = new NpgsqlCommand(query,connection);
        command.Parameters.AddWithValue("User",username);

        await using var reader = await command.ExecuteReaderAsync();

        if(await reader.ReadAsync())
        {
            return new User
            {
              id = reader.GetInt32(0),
              username = reader.GetString(1),
              password = reader.GetString(2)  
            };
        }
        return null;
    }
}   