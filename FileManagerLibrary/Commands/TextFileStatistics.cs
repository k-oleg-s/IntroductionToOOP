using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager;

namespace Commands;

internal class TextFileStatistics : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;
    public override string Description => "Статистика по текстовому файлу: text_stat [file_name]";

    public TextFileStatistics(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        if (args.Length != 2 || string.IsNullOrWhiteSpace(args[1]))
        {
            _UserInterface.WriteLine("Команда Статистика по текстовому файлу: text_stat [file_name]");
            return;
        }

        var directory = _FileManager.CurrentDirectory;

        var file_path = Path.Combine(directory.FullName, args[1]);

        if (!File.Exists(file_path))
        {
            string[] readText = File.ReadAllLines(file_path);
            int lines_number=0;
            int words_number=0;
            foreach (string s in readText)
            {
                lines_number++;
                string[] words = s.Split(' ', ',','.');
                words_number = words.Length + words_number;
            }
            _UserInterface.WriteLine($"файл {file_path} строк:{lines_number}  слов:{words_number}");
        }
        else _UserInterface.WriteLine($"файл {file_path} не существует");
    }
}

