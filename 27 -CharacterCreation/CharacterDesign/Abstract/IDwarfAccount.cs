﻿using CharacterDesign.Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDesign.Abstract
{
    public interface IDwarfAccount
    {
        Dwarf CreateCharacte(IAlliance alliance);
    }
}
