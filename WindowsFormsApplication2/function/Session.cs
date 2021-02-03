using System;
using System.Configuration;
using System.Timers;

public class Session
{
    private static bool m_sessionalive;
    private static Timer m_usertimer;

    public static bool SessionAlive
    {
        get { return m_sessionalive; }
        set { m_sessionalive = value; }
    }
    public static String CurrentUserId { get; set; }

    public static void BeginTimer()
    {        
        try
        {
            SessionAlive = true;
            //usertimer.Start();
            m_usertimer = new Timer(int.Parse(ConfigurationManager.AppSettings["sessiontime"].ToString()));
            m_usertimer.Enabled = true;
            m_usertimer.AutoReset = false;
            m_usertimer.Elapsed += new ElapsedEventHandler(DisposeSession);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.StackTrace);
            return;
        }
    }

    private static void DisposeSession(object source, ElapsedEventArgs e)
    {
        try
        {
            SessionAlive = false;
        }
        catch (System.Exception ex)
        {
            Console.WriteLine(ex.StackTrace);
            return;
        }
    }

    public static void ResetTimer()
    {
        try
        {
            SessionAlive = true;
            m_usertimer.Stop();
            m_usertimer.Start();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.StackTrace);
            return;
        }
    }
}
