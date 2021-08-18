﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame_CoverShooter.Classes
{
    public interface IShooter
    {
        int AC { get; }
        int HP { get; set; }
        bool InCover { get; }

        void TakeCover();
        void Shoot(Player player);
    }
}
