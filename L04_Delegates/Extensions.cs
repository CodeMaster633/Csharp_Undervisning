using System.Runtime.CompilerServices;

static class Extensions
{

    public static bool Lang(this string s, int n) {
        if (s.Length > n) return true;
        else return false;
    }

}