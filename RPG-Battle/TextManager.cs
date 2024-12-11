namespace RPG_Battle
{
    public class TextManager
    {
        public static void center_text(string text, ConsoleColor? color = null)
        {
            if (color.HasValue)
            {
                Console.ForegroundColor = color.Value;
            }

            int x = (Console.BufferWidth - text.Length) / 2;
            Console.SetCursorPosition(x, Console.CursorTop);
            Console.WriteLine(text);

        }
    }
}
