using System;
using System.Data.SqlClient;
using System.Text;


public class LoginFunction
{
	public LoginFunction()
	{
	}
    
    public Boolean IdCheck(String id)
    {
        Boolean result = false;
        StringBuilder comString = new StringBuilder();
        comString.Append("SELECT [ID] ");
        comString.Append("FROM [stockManage_member] ");
        comString.Append("WHERE ID='" + id + "'");
        using(SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn))
        {
            using(SqlDataReader r = com.ExecuteReader())
            {
                if (r.Read())
                {
                    result = true;
                }
            }                
        }            
        return result;
    }


    public Boolean PWCheck(String id, String pw)
    {
        Boolean result = false;
        StringBuilder comString = new StringBuilder();
        comString.Append("SELECT [ID],[PW] ");
        comString.Append("FROM [stockManage_member] ");
        comString.Append("WHERE ID='" + id + "' AND PW='" + pw + "'");
        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        try
        {
            r = com.ExecuteReader();

            if (r.Read())
                result = true;
                        
            return result;
        }
        catch (Exception _ex)
        {
            throw _ex;
        }
        finally
        {
            DBConnection.Close(r);
            DBConnection.Dispose(com);
        }
    }
    public Boolean MemberCreate(String id, String pw, String name, String phone, int gender, String email)
    {
        Boolean result = false;
        SqlCommand com = null;
        StringBuilder comString = new StringBuilder();
        comString.Append("INSERT INTO [stockManage_member] ");
        comString.Append(" VALUES (NEXT VALUE FOR [stockManage_member_seq],'" + id + "','" + pw + "','" + name + "','" + phone + "'," + gender + ",'" + email + "')");
        try
        {
            com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
            com.ExecuteNonQuery();
            result = true;
            return result;
        }
        catch (SqlException e)
        {
            throw e;
        }
        finally
        {
            DBConnection.Dispose(com);
        }
    }


    public Boolean PhoneOverlapCheck(String phone)
    {
        Boolean result = false;
        StringBuilder comString = new StringBuilder();
        comString.Append("SELECT [PHONE] ");
        comString.Append("FROM [stockManage_member] ");
        comString.Append("WHERE [PHONE]='" + phone + "'");
        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        try { 
            r = com.ExecuteReader();

            if (r.Read())
                result = true;

            return result;
        }
        catch(Exception _ex){
            throw _ex;
        }
        finally{
            DBConnection.Close(r);
            DBConnection.Dispose(com);
        }
    }

    public Boolean EmailOverlapCheck(String email)
    {
        Boolean result = false;
        StringBuilder comString = new StringBuilder();
        comString.Append("SELECT [EMAIL] ");
        comString.Append("FROM [stockManage_member] ");
        comString.Append("WHERE PHONE='" + email + "'");
        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        try
        {

             r = com.ExecuteReader();

            if (r.Read())
                result = true;

            return result;
        }
        catch (Exception _ex)
        {
            throw _ex;
        }
        finally
        {
            DBConnection.Close(r);
            DBConnection.Dispose(com);
        }
    }

}
