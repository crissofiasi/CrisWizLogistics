// Decompiled with JetBrains decompiler
// Type: WizLogistics.RouteConfig
// Assembly: WizLogistics2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9944E73C-68D5-4BC1-954E-5CC5CE300CD2
// Assembly location: \\10.10.10.26\wwwroot\cris\bin\WizLogistics2.dll

using Microsoft.AspNet.FriendlyUrls;
using System.Web.Routing;

namespace WizLogistics
{
  public static class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.EnableFriendlyUrls();
    }
  }
}
