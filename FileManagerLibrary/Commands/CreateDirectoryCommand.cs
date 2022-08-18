
using FileManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands;

internal class CreateDirectoryCommand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;

    public CreateDirectoryCommand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override string Description => "Создание директории";

    public override void Execute(string[] args)
    {
        if (args.Length != 2 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.WriteLine("Для команды создания каталога необходимо указать один параметр - новый каталог");
            return;
        }

        var directory = _FileManager.CurrentDirectory;
        var new_path =  Path.Combine(directory.FullName, args[1]);

        if (!Directory.Exists(new_path))
        {
            Directory.CreateDirectory(new_path);
            _UserInterface.WriteLine($"Создана директория {new_path}");
        }
        else
        {
            _UserInterface.WriteLine($"Директория {new_path} уже существует");
            return;
        }        

    }
}
