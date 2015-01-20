﻿using ff14bot;
using ff14bot.Helpers;
using System.Threading.Tasks;
using System.Windows.Media;
using ff14bot.Managers;
using ff14bot.Navigation;

namespace UltimaCR.Rotations
{
    public sealed partial class Summoner
    {
        public override async Task<bool> Rest()
        {
            if (Core.Player.CurrentHealthPercent < 70 ||
                Core.Player.CurrentManaPercent < 50)
            {
                if (MovementManager.IsMoving)
                {
                    Navigator.PlayerMover.MoveStop();
                }
                Logging.Write(Colors.Yellow, @"[Ultima] Resting...");
                return true;
            }
            return false;
        }
    }
}