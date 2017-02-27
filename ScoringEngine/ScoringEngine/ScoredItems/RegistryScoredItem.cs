﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoringEngine
{
    public class RegistryScoredItem : ScoredItem
    {
        public RegistryKey RegistryPath { get; protected set; }
        public object Value { get; protected set; }
    }
}
