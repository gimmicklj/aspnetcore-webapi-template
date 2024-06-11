using System.Reflection;

namespace WebAPI.Extensions;

public static class AssemblyExtensions
{
    public static Assembly GetExecutingAssembly(this AppDomain domain)
    {
        return Assembly.GetExecutingAssembly();
    }
    
    public static Assembly[] GetAllAssemblies(this AppDomain domain)
    {
        return AppDomain.CurrentDomain.GetAssemblies();
    }
    
    public static List<Assembly> GetReferenceAssemblies(this AppDomain domain)
    {
        var list = new List<Assembly>();
        domain.GetAssemblies().ToList().ForEach(i =>
        {
            GetReferenceAssemblies(i, list);
        });
        return list;
    }
    
    static void GetReferenceAssemblies(Assembly assembly, List<Assembly> list)
    {
        assembly.GetReferencedAssemblies().ToList().ForEach(i =>
        {
            var ass = Assembly.Load(i);
            if (!list.Contains(ass))
            {
                list.Add(ass);
                GetReferenceAssemblies(ass, list);
            }
        });
    }
}