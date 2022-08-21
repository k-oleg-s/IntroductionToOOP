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
    public override string Description => "Для просмотра атрибутов команда: attr show [file_name], Для установки атрибута команда: attr set [attr_name: Hidden/ReadOnly/System] [value: true/false] file [file_name]";

    public FileAttributesCommand(IUserInterface UserInterface, FileManagerLogic FileManager)
    {
        _UserInterface = UserInterface;
        _FileManager = FileManager;
    }

    public override void Execute(string[] args)
    {
        FileAttributes attributes;


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
                attributes = File.GetAttributes(file_path);

                string allAttributes="";
                if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden) allAttributes = allAttributes + " Hidden";
                if ((attributes & FileAttributes.Compressed) == FileAttributes.Compressed) allAttributes = allAttributes + " Compressed";
                if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly) allAttributes = allAttributes + " ReadOnly";
                if ((attributes & FileAttributes.System) == FileAttributes.System) allAttributes = allAttributes + " System";

                _UserInterface.WriteLine(($"Атрибуты файла {file_path} : {allAttributes}"));

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
            //FileInfo fileInfo;
            var file_path = Path.Combine(directory.FullName, file);


            if (File.Exists(file_path) && to_set == "set" && to_file == "file")
            {
                //fileInfo = new FileInfo(file_path);

                if (attr_name == "Hidden")
                {
                    if (Boolean.TryParse(attr_val, out bool result))
                    {
                        attributes = File.GetAttributes(file_path);

                        if (result)
                        {
                            File.SetAttributes(file_path, attributes | FileAttributes.Hidden);
                        }
                        else
                        {
                            attributes = RemoveAttribute(attributes, FileAttributes.Hidden);
                            File.SetAttributes(file_path, attributes);
                        };
                    }
                    else { _UserInterface.WriteLine($"Указано неверное значение атрибута, должно быть true или false "); return; }

                    attributes = File.GetAttributes(file_path);
                    _UserInterface.WriteLine($"Установлен аттрибут {attr_name}: {attr_val}");
                }
                else
                if (attr_name == "ReadOnly")
                {
                    if (Boolean.TryParse(attr_val, out bool result))
                    {
                        attributes = File.GetAttributes(file_path);

                        if (result)
                        {
                            File.SetAttributes(file_path, attributes | FileAttributes.ReadOnly);
                        }
                        else
                        {
                            attributes = RemoveAttribute(attributes, FileAttributes.ReadOnly);
                            File.SetAttributes(file_path, attributes);
                        };
                    }
                    else { _UserInterface.WriteLine($"Указано неверное значение атрибута, должно быть true или false "); return; }

                    attributes = File.GetAttributes(file_path);
                    _UserInterface.WriteLine($"Установлен аттрибут {attr_name}: {attr_val}");
                }
                else
                if (attr_name == "System")
                {
                    if (Boolean.TryParse(attr_val, out bool result))
                    {
                        attributes = File.GetAttributes(file_path);

                        if (result)
                        {
                            File.SetAttributes(file_path, attributes | FileAttributes.System);
                        }
                        else
                        {
                            attributes = RemoveAttribute(attributes, FileAttributes.System);
                            File.SetAttributes(file_path, attributes);
                        };
                    }
                    else { _UserInterface.WriteLine($"Указано неверное значение атрибута, должно быть true или false "); return; }

                    attributes = File.GetAttributes(file_path);
                    _UserInterface.WriteLine($"Установлен аттрибут {attr_name}: {attr_val}");
                }

                else _UserInterface.WriteLine($"Аттрибут {attr_name} не обрабатывается");              

            }
            else
            {
                _UserInterface.WriteLine(Description);
                return;
            }

        }
    }

    private  FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
    {
        return attributes & ~attributesToRemove;
    }
}
