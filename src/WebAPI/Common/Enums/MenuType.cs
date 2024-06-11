using System.ComponentModel;

namespace WebAPI.Common.Enums;

public enum MenuType
{
    [Description("目录")]
    Directory = 0,

    [Description("菜单")]
    Menu = 1,
    
    [Description("按钮")]
    Button = 2
}
