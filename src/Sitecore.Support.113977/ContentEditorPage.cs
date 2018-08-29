

namespace Sitecore.Support.Shell.Applications.ContentManager
{
  using Sitecore.Web.UI.HtmlControls;
  using System;
  using System.Text;
  public class ContentEditorPage : Sitecore.Shell.Applications.ContentManager.ContentEditorPage
  {
    // Methods
    protected override void OnPreRender(EventArgs e)
    {
      string str2 = "";
      Registry.SetString("/Current_User/Content Editor/Galleries/Size", "?BAA0A8C5B2B4746B29A82CCCCD6F7CD7E_frame=400pxq250px");
      string[] strArray = Registry.GetString("/Current_User/RecentIcons").Split(new char[] { '|' });
      StringBuilder builder = new StringBuilder();
      foreach (string str in strArray)
      {
        if (!str.Contains("temp/iconcache") && !str.Equals(""))
        {
          builder.Append(str + "|");
        }
      }
      if (builder.ToString().Length > 0)
      {
        str2 = builder.ToString().Remove(builder.ToString().Length - 1);
      }

      Registry.SetString("/Current_User/RecentIcons", str2);
      base.OnPreRender(e);
    }
  }

}
