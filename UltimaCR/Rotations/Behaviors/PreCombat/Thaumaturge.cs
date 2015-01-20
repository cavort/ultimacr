﻿using System.Threading.Tasks;

namespace UltimaCR.Rotations
{
    public sealed partial class Thaumaturge
    {
        public override async Task<bool> PreCombatBuffLvL1()
        {
            return await Ultima.SummonChocobo();
        }

        public override async Task<bool> PreCombatBuffLvL2()
        {
            return await PreCombatBuffLvL1();
        }

        public override async Task<bool> PreCombatBuffLvL4()
        {
            if (await Transpose()) return true;
            return await Ultima.SummonChocobo();
        }

        public override async Task<bool> PreCombatBuffLvL6()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL8()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL10()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL12()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL14()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL15()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL16()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL18()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL20()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL22()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL24()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL26()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL28()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL30()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL32()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL34()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL36()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL38()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL40()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL42()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL44()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL46()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL48()
        {
            return await PreCombatBuffLvL4();
        }

        public override async Task<bool> PreCombatBuffLvL50()
        {
            return await PreCombatBuffLvL4();
        }
    }
}