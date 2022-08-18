using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager;

namespace Commands;

internal class CopyCommand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;
    public override string Description => "Копирование файла: copy [from_file] [to_file]";

    public CopyCommand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        if (args.Length != 3 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.WriteLine("Команда копирование файла: copy [from_file] [to_file]");
            return;
        }

        var directory = _FileManager.CurrentDirectory;

        var from_path = Path.Combine(directory.FullName, args[1]);
        var to_path = Path.Combine(directory.FullName, args[2]);

        if (!File.Exists(from_path))
        {
            var from_f = new FileInfo(from_path);
            from_f.CopyTo(to_path);
            _UserInterface.WriteLine($"файл {from_path} скопирован в {to_path}");
        }
        else _UserInterface.WriteLine($" {from_path} не существует");
    }
}