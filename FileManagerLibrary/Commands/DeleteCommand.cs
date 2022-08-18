using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager;

namespace Commands;

class DeleteCommand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;
    public override string Description => "Удаление директории/файла: delete [file_name]/[dir_name] ";

    public DeleteCommand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        if (args.Length != 2 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.WriteLine("Команда удаления файла: delete [file_name] ");
            return;
        }

        var directory = _FileManager.CurrentDirectory;
        var new_path = Path.Combine(directory.FullName, args[1]);

        if (!Directory.Exists(new_path))
        {
            var d = new DirectoryInfo(new_path);
            d.Delete(true);
            _UserInterface.WriteLine($"директория {new_path} удалена");
        }
        else
        if (!File.Exists(new_path))
        {
            var f = new FileInfo(new_path);
            f.Delete();
            _UserInterface.WriteLine($"файл {new_path} удален");
        }
        else _UserInterface.WriteLine($" {new_path} не существует");

    }
}