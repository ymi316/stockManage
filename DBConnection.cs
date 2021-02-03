using System;
using System.Data.SqlClient;

public class DBConnection
{
	public DBConnection()
	{
	}
    public static SqlConnection getConnection()
    {
        conn = new SqlConnection();
        con.Open();
        try { 
        conn.ConnectionString = "Server=DESKTOP-O8EDJ6L\\SQLEXPRESS;database=Exercise;Integrated Security=true";
        conn.Open();
        }catch(Exception e)
        {
            e.StackTrace;
        }
        return conn;
    }

    public static void close(SqlConnection conn)
    {
        try{
            conn.close();
        }catch(Exception e){
            e.StackTrace;
        }
    }

    public static void close(ExecuteReader ex)
    {
        try{
            ex.close();
        }
        catch (Exception e){
            e.StackTrace;
        }
    }
}
