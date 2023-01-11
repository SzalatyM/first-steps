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
    }
}
