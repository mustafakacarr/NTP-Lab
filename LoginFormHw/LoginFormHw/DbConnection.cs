using System;
using Npgsql;
namespace Db { 
public class DbConnection
{

    public NpgsqlConnection connect()
    {
        String connStr = "Host=localmac;Username=postgres;Password=6124358;Database=ntp_loginform;Port=4358;SSL Mode=prefer;";
        var con = new NpgsqlConnection(connStr);
        con.Open();
        return con;
    }

}
}
