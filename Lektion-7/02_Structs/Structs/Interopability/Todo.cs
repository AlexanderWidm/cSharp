using System.Runtime.InteropServices;

namespace _02_Structs.Structs.Interopability;

[StructLayout(LayoutKind.Sequential)]
public struct Todo
{
    public int userId;
    public int id;
    public string title;
    public bool completed;
}
