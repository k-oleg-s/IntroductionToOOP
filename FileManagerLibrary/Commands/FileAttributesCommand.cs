using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager;

namespace Commands;

internal class FileAttributesCommand : FileManagerCommand
{
    private readonly IUserInterface _UserInterface;
    private readonly FileManagerLogic _FileManager;
    public override string Description => "Для просмотра атрибутов команда: attr show [file_name], Для установки атрибута команда: attr set [attr_name] [value] file [file_name]";

    public FileAttributesCommand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        //Просмотр аттрибутов
        if (args.Length == 3 || string.IsNullOrWhiteSpace(args[1]))
        {
            var to_show = args[1];
            var file = args[2];

            DirectoryInfo? directory;
            FileInfo fileInfo;
            directory = _FileManager.CurrentDirectory;
            var file_path = Path.Combine(directory.FullName, file);

            if (File.Exists(file_path) && to_show == "show")
            {
                fileInfo = new FileInfo(file_path);
                //var attributes = File.GetAttributes(file_path);

                _UserInterface.WriteLine($" Аттрибут файла Name: {fileInfo.Name}");
                _UserInterface.WriteLine($" Аттрибут файла Extension: {fileInfo.Extension}");
                _UserInterface.WriteLine($" Аттрибут файла Attributes: {fileInfo.Attributes.ToString()}");
                _UserInterface.WriteLine($" Аттрибут файла Length: {fileInfo.Length.ToString()}");
                _UserInterface.WriteLine($" Аттрибут файла IsReadOnly: {fileInfo.IsReadOnly.ToString()}");
            }
            else
            {
                _UserInterface.WriteLine("Для просмотра атрибутов команда: attr show [file_name]");
                return;
            }

        }


        //Установка атрибутов
        if (args.Length == 6 || string.IsNullOrWhiteSpace(args[1]))
        {
            var to_set = args[1];
            var attr_name = args[2];
            var attr_val = args[3];
            var to_file = args[4];
            var file = args[5];


            DirectoryInfo? directory;
            directory = _FileManager.CurrentDirectory;
            FileInfo fileInfo;
            var file_path = Path.Combine(directory.FullName, file);

            if (File.Exists(file_path) && to_set == "set" && to_file == "file")
            {
                fileInfo = new FileInfo(file_path);
                if (attr_name == "IsReadOnly")
                {
                    if (Boolean.TryParse(attr_val, out bool result))
                    {
                        fileInfo.IsReadOnly = result;
                    }
                    else {  _UserInterface.WriteLine($"Указан неверное значение атрибута"); return; }
                }
                _UserInterface.WriteLine($"Установлен аттрибут {attr_name}: {attr_val}");
            }
            else
            {
                _UserInterface.WriteLine("Для установки атрибута команда: attr set [attr_name] [value] file [file_name]");
                return;
            }

        }
    }
}
