using System.ComponentModel;

namespace WebAPI.Common.Enums;

public enum Status
{
    [Description("禁用")]
    Forbidden = 0,
    
    [Description("正常")]
    Normal = 1
}
