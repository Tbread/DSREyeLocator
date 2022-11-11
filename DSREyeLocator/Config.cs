using Dalamud.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSREyeLocator
{
    internal class Config : IPluginConfiguration
    {
        public int Version { get; set; } = 1;

        public bool EyeEnabled = true;
        public uint MapEventOpcode = 0x2E0;
        public int VerticalOffset = 100;
        public int HorizontalOffset = 0;
        public float Scale = 1f;
        public bool EnableTether = true;
        public float Thickness = 5f;
        public uint Color = 0xC8FF0E00;
        public bool EnableBanner = true;
        public bool BannerBlink = true;
        [NonSerialized] internal bool Test = false;
        public bool Delay = true;
        public int SanctityDelay = 11000;
        public int DeathDelay = 25000;

        public bool ChainEnabled = false;
        public float ChainThickness = 2f;
        public uint ChainColor = 0xC80000FF;

        public bool WrothFlamesOperational = false;
        public bool WrothFlames = false;
        public bool FlamesOnlySelf = false;
        public string FlamesSelfSpread = "/mk attack <me>";
        public string FlamesSelfStack = "/mk bind <me>";
        public string FlamesSelfNone = "/mk Stop <me>";
        public bool FlamesEmulateDelay = true;
        public bool MarkSpreads = true;
        public bool MarkStacks = true;
        public bool MarkNones = true;
        public bool UseCustomCommands = false;
        public string CustomCommandsSpread = "/mk attack1\n/mk attack2\n/mk attack3\n/mk attack4";
        public string CustomCommandsStack = "/mk bind1\n/mk bind2";
        public string CustomCommandsNone = "/mk Stop1\n/mk Stop2";

        public int ChangelogWindowVer = 0;

        public bool MapEffectDbg = false;
        public List<(uint TerritoryType, List<(byte[] header, FFXIVIpcMapEffect st)> structs)> MapEffectLog = new();
    }
}
