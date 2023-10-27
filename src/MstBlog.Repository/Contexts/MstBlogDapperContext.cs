using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using MstBlog.Core.Domain;

namespace MstBlog.Repository.Contexts;

public class MstBlogDapperContext
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public MstBlogDapperContext(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString(SettingNames.ConnectionString);
    }
    
    public IDbConnection CreateConnection()
        => new SqlConnection(_connectionString);
    
}