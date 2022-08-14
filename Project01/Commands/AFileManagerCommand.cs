﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands;

public abstract class FileManagerCommand
{
    public abstract string Description { get; }

    public abstract void Execute(string[] args);
}
