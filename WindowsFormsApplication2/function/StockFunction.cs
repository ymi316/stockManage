using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Collections;
using System.Text;
//price 와 product 테이블 관련 함수
public class StockFunction
{
    public StockFunction(){}
    
    public static int SelectCountStock()
    {
        int result = 0;
        SqlCommand com = new SqlCommand("SELECT COUNT(1) FROM [stockManage_product]", DBConnection.M_Conn);
        Console.WriteLine(com.CommandText);
        try
        {
            //r = com.ExecuteReader();
            //if(r.Read()) result = Convert.ToInt32(r[1].ToString());
            result = Convert.ToInt32(com.ExecuteScalar());
            return result;
        }
        catch (Exception _ex)
        {
            throw _ex;
        }
        finally
        {
            DBConnection.Dispose(com);
        }
    }
    public static List<ProductVO> StockList()
    {
        List<ProductVO> list = null;

        StringBuilder comString = new StringBuilder();
        comString.Append(" SELECT [CODE],[NAME],[NUM],[GRP]  ");
        comString.Append(" FROM [stockManage_product] ");
        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        Console.WriteLine(com.CommandText);
        try
        {
            list = new List<ProductVO>();
            r = com.ExecuteReader();

            while (r.Read())
            {
                ProductVO vo = new ProductVO();
                vo.Code = r["CODE"].ToString();
                vo.Name = r["NAME"].ToString();
                vo.Num = r["NUM"].ToString();
                vo.Grp = r["GRP"].ToString();
                list.Add(vo);                
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            DBConnection.Close(r);
            DBConnection.Dispose(com);
        };
        return list;
    }
    public static ProductVO SelectOneStock(String CODE)
    {
        ProductVO vo = new ProductVO();

        StringBuilder comString = new StringBuilder();
        comString.Append(" SELECT [CODE],[NAME],[NUM],[GRP]  ");
        comString.Append(" FROM [stockManage_product] ");
        comString.Append(" WHERE CODE='" + CODE + "'");
        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        Console.WriteLine(com.CommandText);
        try
        {
            r = com.ExecuteReader();
            if (r.Read())
            {
                vo.Code = r["CODE"].ToString();
                vo.Name = r["NAME"].ToString();
                vo.Num = r["NUM"].ToString();
                vo.Grp = r["GRP"].ToString();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            DBConnection.Close(r);
            DBConnection.Dispose(com);
        };
        return vo;
    }
    public static Boolean InsertStock(String name, int num, String grp)
    {
        Boolean result = false;
        StringBuilder comString = new StringBuilder();
        comString.Append(" INSERT INTO [stockManage_product] ");
        comString.Append(" ( ");
        comString.Append("      CODE,   NAME,   NUM,    GRP ");
        comString.Append(" ) ");
        comString.Append(" VALUES(");
        comString.Append(" ("
                            +" SELECT Top 1 CONCAT(LEFT([CODE],1),lastCode) "
                            +" FROM [stockManage_product],"
                                +" ("
                                    +" SELECT (CONCAT((REPLICATE('0', 4 - LEN(MAX(CONVERT(INT, RIGHT([CODE], 4))) + 1))), (MAX(CONVERT(INT, RIGHT([CODE], 4))) + 1))) as lastCode"
                                    +" FROM [stockManage_product] "
                                    +" WHERE GRP = '" + grp + "'"
                                +" ) as codetable2"
                            +" WHERE GRP = '" + grp + "'"
                          +" )");
        comString.Append(",'" + name + "'," + num + ",'" + grp + "')");
        
        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        Console.WriteLine(com.CommandText);
        try
        {
            com.ExecuteNonQuery();
            result = true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            DBConnection.Dispose(com);
        };
        return result;
    }

    public static Boolean InsertPrice( String date, int price, String note, String grp)
    {
        Boolean result = false;
        StringBuilder comString = new StringBuilder();
        comString.Append(" INSERT INTO [stockManage_price] (CODE,DATE,PRICE,NOTE) ");
        comString.Append(" VALUES(");
        comString.Append(" ("
                            + " SELECT Top 1 CONCAT(LEFT([CODE],1),lastCode) "
                            + " FROM [stockManage_product],"
                                + " ("
                                    + " SELECT (CONCAT((REPLICATE('0', 4 - LEN(MAX(CONVERT(INT, RIGHT([CODE], 4)))))), (MAX(CONVERT(INT, RIGHT([CODE], 4))) +))) as lastCode"
                                    + " FROM [stockManage_product] "
                                    + " WHERE GRP = '" + grp + "'"
                                + " ) as codetable2"
                            + " WHERE GRP = '" + grp + "'"
                          + " )");
        comString.Append(" ,'" + date+ "'," + price + ",'" + note + "')");
        
        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        Console.WriteLine(com.CommandText);
        try
        {
            com.ExecuteNonQuery();
            result = true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            DBConnection.Dispose(com);
        };
        return result;
    }

    public static Boolean insertStockPrice(String grp, String name, int num, String date, int price, String note)
    {
        Boolean result = false;
        String code = "";
        try
        {
            //code = SelectLastCODE(grp);
            InsertStock(name, num, grp);
            InsertPrice( date, price, note, grp);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return result;
    }

    private static String CovertGrp(String grp)
    {
        String result = "";
        switch (grp)
        {
            case "전자기기/부품":
                result = "A";
                break;
            case "식료품":
                result = "B";
                break;
            case "섬유/의류":
                result = "C";
                break;
            case "가구/목재":
                result = "D";
                break;
            case "의료기기":
                result = "E";
                break;
            default:
                result = "Z";
                break;
        }
        return result;
    }

    public static String SelectLastCODE(String grp)
    {
        String result = "";
        StringBuilder comString = new StringBuilder();
        comString.Append(" SELECT [CODE] ");
        comString.Append(" FROM [stockManage_product]");
        comString.Append(" WHERE GRP ='" + grp + "' order by CODE desc");
        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        Console.WriteLine(com.CommandText);
        try
        {
            if (r.Read())
            {
                String num = com.ExecuteScalar().ToString();
                num = num.Substring(1, num.Length - 1);
                result = (Convert.ToInt32(num) + 1).ToString();
                for (int i = result.Length; i < 4; i++)
                {
                    result = "0" + result;
                }
            }
            else result = "0001";
            DBConnection.Close(r);
            result = CovertGrp(grp) + result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            DBConnection.Close(r);
            DBConnection.Dispose(com);
        }
        return result;
    }

    
    public static List<ProducViewVO> StockViewList()
    {
        List<ProducViewVO> list = null;

        StringBuilder comString = new StringBuilder();
        comString.Append(" SELECT [CODE],[GRP],[NAME],[NUM],[PRICE],[DATE],[NOTE] ");
        comString.Append(" FROM [view_stockManageProductDet]");
        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        Console.WriteLine(com.CommandText);
        try
        {
            list = new List<ProducViewVO>();
            r = com.ExecuteReader();

            while (r.Read())
            {
                ProducViewVO vo = new ProducViewVO();
                vo.Code = r["CODE"].ToString();
                vo.Grp = r["GRP"].ToString();
                vo.Name = r["NAME"].ToString();
                vo.Num = r["NUM"].ToString();
                vo.Price = Convert.ToInt32((r["PRICE"]));
                vo.Date = r["DATE"].ToString();
                vo.Note = r["NOTE"].ToString();
                list.Add(vo);
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            DBConnection.Close(r);
            DBConnection.Dispose(com);
        };
        return list;
    }

    public static Boolean UpdateStock(String code, int num)
    {
        Boolean result = false;

        StringBuilder comString = new StringBuilder();
        comString.Append(" UPDATE [stockManage_product] ");
        comString.Append(" SET NUM= " + num );
        comString.Append(" WHERE CODE='" + code + "'");
        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        Console.WriteLine(com.CommandText);
        try
        {
            com.ExecuteNonQuery();
            result = true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            DBConnection.Close(r);
            DBConnection.Dispose(com);
        };
        return result;
    }
    public static Boolean UpdatePrice(String code, String date, int price, String note)
    {
        Boolean result = false;

        StringBuilder comString = new StringBuilder();
        comString.Append(" UPDATE [stockManage_price] ");
        comString.Append("    SET DATE      = '" + date + "',");
        comString.Append("        PRICE     = '" + price + "',");
        comString.Append("        NOTE      = '" + note + "'");
        comString.Append("  WHERE CODE      = '" + code + "'");
        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        Console.WriteLine(com.CommandText);
        try
        {
            com.ExecuteNonQuery();
            result = true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            DBConnection.Close(r);
            DBConnection.Dispose(com);
        };
        return result;
    }
    public static Boolean updateStockPrice(String code, int num, String date, int price, String note)
    {
        Boolean result = false;
        try
        {
            UpdateStock(code, num);
            UpdatePrice(code, date, price, note);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return result;
    }
    public static Boolean DeleteStockPrice(String code)
    {
        Boolean result = false;
        try
        {
            DeleteStock(code);
            DeletePrice(code);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return result;
    }
    public static Boolean DeleteStock(String code)
    {
        Boolean result = false;

        SqlCommand com = new SqlCommand("DELETE [stockManage_product] WHERE CODE='" + code + "'", DBConnection.M_Conn);
        SqlDataReader r = null;
        Console.WriteLine(com.CommandText);
        try
        {
            com.ExecuteNonQuery();
            result = true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            DBConnection.Close(r);
            DBConnection.Dispose(com);
        };
        return result;
    }
    public static Boolean DeletePrice(String code)
    {
        Boolean result = false;

        SqlCommand com = new SqlCommand("DELETE [stockManage_price] WHERE CODE='" + code + "'", DBConnection.M_Conn);
        SqlDataReader r = null;
        Console.WriteLine(com.CommandText);
        try
        {
            com.ExecuteNonQuery();
            result = true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            DBConnection.Close(r);
            DBConnection.Dispose(com);
        };
        return result;
    }


    /*
    public static ProductVO[] StockProductVO()
    {
        ProductVO[] vo = new ProductVO[7];
        //ProductVO[] vo = new ProductVO[SelectCountStock()];

        SqlCommand com = new SqlCommand("SELECT * FROM [stockManage_product]", DBConnection.M_Conn);
        SqlDataReader r = null;
        try
        {
            r = com.ExecuteReader();

            int i = 0;
            while (r.Read())
            {
                vo[i].Code = r["CODE"].ToString();
                vo[i].Name = r["NAME"].ToString();
                vo[i].Num = r["NUM"].ToString();
                vo[i].Grp = r["GRP"].ToString();
                i++;
            }
            return vo;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            DBConnection.Close(r);
            DBConnection.Dispose(com);
        };       
    }*/

}
