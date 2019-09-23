// Decompiled with JetBrains decompiler
// Type: WizLogistics.Settings
// Assembly: WizLogistics2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9944E73C-68D5-4BC1-954E-5CC5CE300CD2
// Assembly location: \\10.10.10.26\wwwroot\cris\bin\WizLogistics2.dll

using System.Web;
using CrisWizLogistics.WizLogisticsDataSetTableAdapters;

namespace CrisWizLogistics
{
  public static class Settings
  {
    private static ProceduresAdapter procAdapter = new ProceduresAdapter();

    public static string GetValue(string code, string defaultValue)
    {
      string str = string.Empty;
      HttpContext current = HttpContext.Current;
      if (current.Session["UserID"] == null)
      {
        current.Response.Redirect("Login");
      }
      else
      {
        try
        {
          int settingValue = (int) Settings.procAdapter.GetSettingValue(code, new int?((int) current.Session["UserID"]), ref str);
        }
        catch
        {
        }
      }
      if (str.Length == 0)
        str = defaultValue;
      return str;
    }
  }
}
