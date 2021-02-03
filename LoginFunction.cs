using System;
using static DBConnection;
using System.Data.SqlClient;
using System.Configuration;

public class LoginFunction
{
    public LoginFunction()
    {
    }

    public String connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
    public Boolean IdCheck(String id)
    {
        Boolean result = false;
        SqlConnection con = getConnection();
        SqlCommand com = new SqlCommand("SELECT [ID] FROM [stockManage_member] where ID='" + id + "'", con);
        SqlDataReader r = com.ExecuteReader();

        if (r.Read())
        {
            result = true;
        }
        close(r);
        close(con);

        return result;
    }


    public Boolean PWCheck(String id, String pw)
    {
        Boolean result = false;
        SqlConnection con = getConnection();
        SqlCommand com = new SqlCommand("SELECT [ID],[PW] FROM [stockManage_member] where ID='" + id + "' AND PW='" + pw + "'", con);
        SqlDataReader r = com.ExecuteReader();

        if (r.Read())
            result = true;

        close(r);
        close(con);

        return result;
    }

    public Boolean MemberCreate(String id, String pw, String name, String phone, int gender, String email)
    {
        Boolean result = false;
        SqlConnection con = getConnection();
        try
        {
            //insert into [stockManage_member] 
            //values (NEXT VALUE FOR [stockManage_member_seq],'id','pw','name','phone',0,'email' )
            SqlCommand com = new SqlCommand("insert into [stockManage_member] values "
                + "(NEXT VALUE FOR [stockManage_member_seq],'" + id + "','" + pw + "','" + name + "','" + phone + "'," + gender + ",'" + email + "')", con);
            com.ExecuteNonQuery();
            result = true;
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.StackTrace);
        }
        close(con);
        return result;
    }

    public Boolean PhoneOverlapCheck(String phone)
    {
        Boolean result = false;
        SqlConnection con = getConnection();
        SqlCommand com = new SqlCommand("SELECT [PHONE] FROM [stockManage_member] where PHONE='" + phone + "'", con);
        SqlDataReader r = com.ExecuteReader();

        if (r.Read())
            result = true;

        close(r);
        close(con);

        return result;
    }

    public Boolean EmailOverlapCheck(String email)
    {
        Boolean result = false;
        SqlConnection con = getConnection();
        SqlCommand com = new SqlCommand("SELECT [EMAIL] FROM [stockManage_member] where PHONE='" + email + "'", con);
        SqlDataReader r = com.ExecuteReader();

        if (r.Read())
            result = true;

        close(r);
        close(con);

        return result;
    }

}
