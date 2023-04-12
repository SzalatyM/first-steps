using Spectre.Console;
namespace FirstSteps.RPG.Tools
{
    static class Display
    {
        public static void DefaultText(string defaultText)
        {
            AnsiConsole.MarkupLine($"[green]{defaultText}[/]");
        }
        public static void WarningText(string warningText)
        {
            AnsiConsole.MarkupLine($"[yellow]{warningText}[/]");
        }
        public static void ErrorText(string errorText)
        {
            AnsiConsole.MarkupLine($"[red]{errorText}[/]");
        }       
        public static void ItemText(string itemText)
        {
            AnsiConsole.MarkupLine($"[blue]{itemText}[/]");
        }
        public static void ClassicText(string classicText)
        {
            AnsiConsole.MarkupLine(classicText);
        }
       
    }
}
