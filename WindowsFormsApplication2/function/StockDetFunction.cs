using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
//export 와 import 테이블 관련 함수
public class StockDetFunction
{
    public StockDetFunction()
    {
    }

    public static Boolean InsertimportDetail(String code, String unit, int unitnum, int importnum, int onePrice,String id, String note)
    {
         
        Boolean result = false;
        SqlCommand com = null;
        StringBuilder comString = new StringBuilder();
        comString.Append(" INSERT INTO [stockManage_importDetail] ");
        comString.Append(" ([DATENO],[CODE],[UNIT],[UNITNUM],[IMPORTNUM],[ONEPRICE],[ID],[NOTE]) ");
        comString.Append(" VALUES");
        comString.Append(" ( CONCAT('" + DateTime.Now.ToString("yyMMdd") + "','0000') ");
        comString.Append("  + IIF("
                                    +"("
                                        +" SELECT count(*) "
                                        +" FROM [stockManage_import] "
                                        +" WHERE DATENO like '" + DateTime.Now.ToString("yyMMdd") + "%'"
                                    +")=0,1, "
                                    +"("
                                        +" SELECT RIGHT(MAX(CONVERT(INT,DATENO)) + 1,4) "
                                        + " FROM [stockManage_import] "
                                        + " WHERE DATENO like '" + DateTime.Now.ToString("yyMMdd") + "%'"
                                    +")"
                                +")"); //DATENO
        comString.Append(",'" + code + "', '" + unit + "', " + unitnum + ", " + importnum + ", " + onePrice + ", '" + id + "', '" + note + "' ) ");
        try
        {
            com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
            Console.WriteLine(com.CommandText);
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
    
    public static Boolean Insertimport(String date, int num, int price, String sellername)
    {
        Boolean result = false;
        SqlCommand com = null;
        StringBuilder comString = new StringBuilder();
        comString.Append("INSERT INTO [stockManage_import] ");
        comString.Append("([DATENO],[DATE],[NUM],[PRICE],[SELLERNAME])");
        comString.Append("VALUES");
        comString.Append("('" + DateTime.Now.ToString("yyMMdd") + "0000' "
                            +"+ IIF("
                                    + "("
                                    + " SELECT count(*) "
                                    + " FROM [stockManage_import] "
                                    + " WHERE DATENO like '" + DateTime.Now.ToString("yyMMdd") + "%')=0,1, "
                                        + "("
                                            + " SELECT RIGHT(MAX(CONVERT(INT,DATENO)) + 1,4) "
                                            + " FROM [stockManage_import] "
                                            + " WHERE DATENO like '" + DateTime.Now.ToString("yyMMdd") + "%'"
                                        + ")"
                                + ") ");//DATENO
        comString.Append(",'" + date + "', " + num + ", " + price + ", '" + sellername + "')");
        try
        {
            com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
            Console.WriteLine(com.CommandText);
            com.ExecuteNonQuery();
            result = true;
            return result;
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.StackTrace);
            throw e;
        }
        finally
        {
            DBConnection.Dispose(com);
        }
    }

    public static List<ProducViewVO> SearchStockListForName(String name)
    {
        List<ProducViewVO> list = null;

        StringBuilder comString = new StringBuilder();
        comString.Append(" SELECT [CODE],[GRP],[NAME],[NUM],[PRICE],[DATE],[NOTE] ");
        comString.Append(" FROM [view_stockManageProductDet] ");
        comString.Append(" WHERE  NAME like '%" + name + "%' ");
        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        try
        {
            Console.WriteLine(com.CommandText);
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
            return list;
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
    }
    public static List<ProducViewVO> SearchStockListForCode(String code)
    {
        List<ProducViewVO> list = null;

        StringBuilder comString = new StringBuilder();
        comString.Append(" SELECT [CODE],[GRP],[NAME],[NUM],[PRICE],[DATE],[NOTE] ");
        comString.Append(" FROM [view_stockManageProductDet]");
        comString.Append(" WHERE  CODE like '%" + code + "%'");
        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        try
        {
            Console.WriteLine(com.CommandText);
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
            return list;
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
    }


    public static Boolean InsertExportDetail(String code, int num, int onePrice,String note)
    {
        Boolean result = false;
        SqlCommand com = null;
        StringBuilder comString = new StringBuilder();
        comString.Append(" INSERT INTO [stockManage_exportDetail] ");
        comString.Append(" ([DATENO],[CODE],[NUM],[ONEPRICE],[NOTE]) ");
        comString.Append(" VALUES(");
        comString.Append("  CONCAT('" + DateTime.Now.ToString("yyMMdd") + "','0000')"
                        +" + IIF("
                                + "("
                                    +" SELECT count(*) "
                                    +" FROM [stockManage_export] "
                                    +" WHERE [DATENO] like '" + DateTime.Now.ToString("yyMMdd") + "%'"
                                + ")=0" 
                                + ",1,"
                                + " ("
                                    +" SELECT RIGHT(MAX(CONVERT(INT,DATENO)) + 1,4)"
                                    +" FROM [stockManage_export] "
                                    +" WHERE [DATENO] like '" + DateTime.Now.ToString("yyMMdd") + "%'"
                                + " )"
                        + " )"); //dateno
        comString.Append(",'" + code + "', " + num + ", " + onePrice + ",'" + note + "')");
        try
        {
            com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
            Console.WriteLine(com.CommandText);
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

    public static Boolean InsertExport(String date, int num, int price, String id, int payWay)
    {
        Boolean result = false;
        SqlCommand com = null;
        StringBuilder comString = new StringBuilder();
        comString.Append(" INSERT INTO [stockManage_export] ");
        comString.Append(" ([DATENO],[DATE],[NUM],[PRICE],[ID],[PURCHASEWAY])");
        comString.Append(" VALUES(");
        comString.Append(" '" + DateTime.Now.ToString("yyMMdd") + "0000' + "
                            + "IIF("
                                + "("
                                    +" SELECT count(*) "
                                    + " FROM [stockManage_export] "
                                    + " WHERE [DATENO] like '" + DateTime.Now.ToString("yyMMdd") + "%'"
                                + ")=0,1,("
                                    + " SELECT RIGHT(MAX(CONVERT(INT,DATENO)) + 1,4) "
                                    + " FROM [stockManage_export] "
                                    + " WHERE [DATENO] like '" + DateTime.Now.ToString("yyMMdd") + "%'"
                                + " )"
                            + " )");        
        comString.Append(" ,'" + date + "', " + num + ", " + price + ", '" + id + "', " + payWay + ")");
        try
        {
            com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
            Console.WriteLine(com.CommandText);
            com.ExecuteNonQuery();
            result = true;
            return result;
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.StackTrace);
            throw e;
        }
        finally
        {
            DBConnection.Dispose(com);
        }
    }
    public static List<ImportViewVO> ImportViewList(String where)
    {
        List<ImportViewVO> list = null;
        StringBuilder comString = new StringBuilder();
        comString.Append(" SELECT DET.[DATENO], [CODE],[GRP],[NAME],[DATE],[UNIT],[UNITNUM],[IMPORTNUM],[ONEPRICE],[ID],[SELLERNAME],[NOTE] ");
        comString.Append(" FROM [stockManage_import],");
        comString.Append(" ("
                               +" select [DATENO],[GRP], A.[CODE],[NAME],[UNIT],[UNITNUM],[IMPORTNUM],[ONEPRICE],[ID],[NOTE] "
                               +" from "
                               +" [stockManage_importDetail] A LEFT OUTER JOIN [stockManage_product] B "
                               +" on A.CODE = B.CODE"
                         +" ) DET ");
        comString.Append(" WHERE [stockManage_import].[DATENO]=DET.[DATENO] ");

        if (where != String.Empty)
        {
            comString.Append(" AND " + where);
        } 
        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        try
        {
            Console.WriteLine(com.CommandText);
            list = new List<ImportViewVO>();
            r = com.ExecuteReader();

            while (r.Read())
            {
                ImportViewVO vo = new ImportViewVO();
                vo.DateNO = r["DATENO"].ToString();
                vo.Code = r["CODE"].ToString();
                vo.Grp = r["GRP"].ToString();
                vo.Name = r["NAME"].ToString();
                vo.Date = r["DATE"].ToString();
                vo.Unit = r["UNIT"].ToString();
                vo.UnitNum = Convert.ToInt32(r["UNITNUM"]);
                vo.ImportNum = Convert.ToInt32(r["IMPORTNUM"]);
                vo.OnePrice = Convert.ToInt32(r["ONEPRICE"]);
                vo.id = r["ID"].ToString(); 
                vo.company = r["SELLERNAME"].ToString();
                vo.Note = r["NOTE"].ToString();
                list.Add(vo);
            }
            return list;
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
    }

    public static List<ExportViewVO> ExportViewList(String where)
    {
        List<ExportViewVO> list = null;
        StringBuilder comString = new StringBuilder();
        comString.Append(" SELECT DET.[DATENO], [CODE],[GRP],[NAME],[DATE],DET.[NUM],[ONEPRICE],[stockManage_export].[ID],[NOTE],[PURCHASEWAY]  ");
        comString.Append(" FROM [stockManage_export], ");
        comString.Append(" ("
                                +" SELECT [GRP],[NAME],[DATENO],[DETAILNO], A.[CODE], A.[NUM],[ONEPRICE],[NOTE] "
                                +" FROM "
                                +" [stockManage_exportDetail] A LEFT OUTER JOIN [stockManage_product] B on A.CODE = B.CODE"
                         +" ) DET ");
        comString.Append(" WHERE [stockManage_export].[DATENO] = DET.[DATENO]");
        if (where != String.Empty)
        {
            comString.Append(" AND " + where);
        }
        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        try
        {
            Console.WriteLine(com.CommandText);
            list = new List<ExportViewVO>();
            r = com.ExecuteReader();

            while (r.Read())
            {
                ExportViewVO vo = new ExportViewVO();
                vo.DateNO = r["DATENO"].ToString();
                vo.Code = r["CODE"].ToString();
                vo.Grp = r["GRP"].ToString();
                vo.Name = r["NAME"].ToString();
                vo.Date = r["DATE"].ToString();
                vo.Num = Convert.ToInt32(r["NUM"]);
                vo.OnePrice = Convert.ToInt32(r["ONEPRICE"]);
                vo.id = r["ID"].ToString();
                vo.Note = r["NOTE"].ToString();
                vo.payWay = Convert.ToInt32(r["PURCHASEWAY"]);
                list.Add(vo);
            }
            return list;
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
    }

    public static Boolean UpdateImport(String dateno, String date, int num, int price, String sellername)
    {
        Boolean result = false;
        StringBuilder comString = new StringBuilder();
        comString.Append(" UPDATE [stockManage_import] ");
        comString.Append(" SET [DATE]= '" + date + "',[NUM]=" + num + ",[PRICE]=" + price + ",[SELLERNAME]='"+ sellername + "' ");
        comString.Append(" WHERE [DATENO]='" + dateno + "'");

        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        try
        {
            Console.WriteLine(com.CommandText);
            com.ExecuteNonQuery();
            result = true;
            return result;
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
    }
    public static Boolean UpdateImportDet(String dateno, String unit, int unitnum, int importnum,int oneprice ,String note)
    {
        Boolean result = false;
        StringBuilder comString = new StringBuilder();
        comString.Append(" UPDATE [stockManage_importDetail] ");
        comString.Append(" SET [UNIT]= '" + unit + "',[UNITNUM]=" + unitnum + ",[IMPORTNUM]=" + importnum + ",[ONEPRICE]=" + oneprice + ",NOTE='" + note + "' ");
        comString.Append(" WHERE [DATENO]='" + dateno + "'");

        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        try
        {
            Console.WriteLine(com.CommandText);
            com.ExecuteNonQuery();
            result = true;
            return result;
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
    }   
    public static Boolean updateImportData(String dateno, String unit, int unitnum, int importnum, int oneprice, String note, String date, int num, int price, String sellername)
    {
        Boolean result = false;
        try
        {
            UpdateImport(dateno,date,num, price, sellername);
            UpdateImportDet(dateno,unit,unitnum,importnum, oneprice, note);
            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static Boolean UpdateExport(String dateno, String date, int num, int price, int pway)
    {
        Boolean result = false;
        StringBuilder comString = new StringBuilder();
        comString.Append(" UPDATE [stockManage_export]");
        comString.Append(" SET [DATE]= '" + date + "',[NUM]=" + num + ",[PRICE]=" + price + ",[PURCHASEWAY]="+ pway);
        comString.Append(" WHERE [DATENO]='" + dateno + "'");

        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        try
        {
            Console.WriteLine(com.CommandText);
            com.ExecuteNonQuery();
            result = true;
            return result;
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
    }
    public static Boolean UpdateExportDet(String dateno, int num, int oneprice, String note)
    {
        Boolean result = false;
        StringBuilder comString = new StringBuilder();
        comString.Append(" UPDATE [stockManage_exportDetail]");
        comString.Append(" SET [NUM]= " + num + ",[ONEPRICE]=" + oneprice + ",NOTE='" + note+ "'");
        comString.Append(" WHERE [DATENO]='" + dateno + "'");

        SqlCommand com = new SqlCommand(comString.ToString(), DBConnection.M_Conn);
        SqlDataReader r = null;
        try
        {
            Console.WriteLine(com.CommandText);
            com.ExecuteNonQuery();
            result = true;
            return result;
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
    }
    public static Boolean UpdateExportData(String dateno, String date, int num, int price, int pway, String note)
    {
        Boolean result = false;
        try
        {
            UpdateExport(dateno,date, num, price, pway);
            UpdateExportDet(dateno, num, price, note);
            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static Boolean DeleteExport(String dateno)
    {
        Boolean result = false;
        SqlCommand com = new SqlCommand("DELETE [stockManage_export]  WHERE [DATENO]='" + dateno + "'", DBConnection.M_Conn);
        SqlDataReader r = null;
        try
        {
            Console.WriteLine(com.CommandText);
            com.ExecuteNonQuery();
            result = true;
            return result;
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
    }
    public static Boolean DeleteExportDet(String dateno)
    {
        Boolean result = false;
        SqlCommand com = new SqlCommand("DELETE [stockManage_exportDetail]  WHERE [DATENO]='" + dateno + "'", DBConnection.M_Conn);
        SqlDataReader r = null;
        try
        {
            Console.WriteLine(com.CommandText);
            com.ExecuteNonQuery();
            result = true;
            return result;
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
    }
    public static Boolean DeleteExportData(String dateno)
    {
        Boolean result = false;
        try
        {
            DeleteExport(dateno);
            DeleteExportDet(dateno);
            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static Boolean DeleteImport(String dateno)
    {
        Boolean result = false;
        SqlCommand com = new SqlCommand("DELETE [stockManage_import]  WHERE [DATENO]='" + dateno + "'", DBConnection.M_Conn);
        SqlDataReader r = null;
        try
        {
            Console.WriteLine(com.CommandText);
            com.ExecuteNonQuery();
            result = true;
            return result;
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
    }
    public static Boolean DeleteImportDet(String dateno)
    {
        Boolean result = false;
        SqlCommand com = new SqlCommand("DELETE [stockManage_importDetail]  WHERE [DATENO]='" + dateno + "'", DBConnection.M_Conn);
        SqlDataReader r = null;
        try
        {
            Console.WriteLine(com.CommandText);
            com.ExecuteNonQuery();
            result = true;
            return result;
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
    }
    public static Boolean DeleteImportData(String dateno)
    {
        Boolean result = false;
        try
        {
            DeleteImport(dateno);
            DeleteImportDet(dateno);
            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
