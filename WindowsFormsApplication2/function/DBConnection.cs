using System;
using System.Data.SqlClient;

//이런식으로 연결하고 끊는건 웹방식인것 같다
//시스템은 DB연결후에 끊기지 않도록 하나봐
public class DBConnection
{
    static SqlConnection conn = null;

    public DBConnection()
	{
	}

    public static SqlConnection M_Conn { get; set; } = null;

    public static SqlConnection GetConnection()
    {
        conn = new SqlConnection();
        try { 
            conn.ConnectionString = "Server=DESKTOP-O8EDJ6L\\SQLEXPRESS;database=Exercise;Integrated Security=true";
            conn.Open();

            M_Conn = conn;
        }
        catch(SqlException e)
        {
            Console.WriteLine(e.StackTrace);
        }
        return conn;
    }

    public static void Close(SqlConnection conn)
    {
        try{
            if (conn == null)
            {
                return;
            }
            conn.Close();
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.StackTrace);
        }
    }
    public static void Close(SqlDataReader r)
    {
        try
        {
            if (r == null)
            {
                return;
            }
            r.Close();
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.StackTrace);
        }
    }

    public static void Close()
    {
        try
        {
            if (M_Conn == null)
            {
                return;
            }

            M_Conn.Close();
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.StackTrace);
        }
    }
    public static void Dispose(SqlCommand com)
    {
        try
        {
            if (com == null)
            {
                return;
            }

            com.Dispose();
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.StackTrace);
        }

    }

    public static void Rollback(SqlConnection conn)
    {
        try
        {
            if (conn != null)
            {
                SqlTransaction tran = conn.BeginTransaction();
                tran.Rollback();
            }
        }catch (SqlException e)
        {
            Console.WriteLine(e.StackTrace);
        }
    }    
}
