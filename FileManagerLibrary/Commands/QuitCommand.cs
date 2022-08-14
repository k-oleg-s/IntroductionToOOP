using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager;

namespace Commands;

public class QuitCommand : FileManagerCommand
{
    private readonly FileManagerLogic _FileManager;

    public override string Description => "Выход";

    public QuitCommand(FileManagerLogic FileManager) => _FileManager = FileManager;

    public override void Execute(string[] args)
    {
        _FileManager.Stop();
    }
}
