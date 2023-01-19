namespace BracketsChecker.Core
{
    public static class BracketsChecker
    {
        public static bool Check(string input)
        {
            Stack<char> lastOpen = new();
            foreach (var c in input)
            {
                switch (c)
                {
                    case '}':
                        if (lastOpen.Count == 0 || lastOpen.Pop() != '{') return false;
                        break;
                    case '{': lastOpen.Push(c); break;
                }
            }
            if (lastOpen.Count == 0) return true;
            else return false;
        }
    }
}
