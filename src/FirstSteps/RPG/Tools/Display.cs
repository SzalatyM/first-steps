using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG.Tools
{
    static class Display
    {
        public static void DefaultText(string _default)
        {
            AnsiConsole.MarkupLine($"[green] {_default} [/] ");
        }
        public static void WarningText(string _warning)
        {
            AnsiConsole.MarkupLine($"[yellow] {_warning} [/] ");
        }
        public static void ErrorText(string _error)
        {
            AnsiConsole.MarkupLine($"[red] {_error} [/] ");
        }
        // i make this only for folder "Adventure" and im waiting for tips like you write on messenger. WarningText added to the "command"
    }
}
