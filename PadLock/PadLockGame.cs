﻿using PadLock.constants;
using PadLock.src.parameters;
using Microsoft.Xna.Framework;
using pigeon.console;
using pigeon.core;
using pigeon.data;
using System.Reflection;
using PadLock.src.worlds;
using pigeon;
using pigeon.gfx;
using pigeon.tools.anim;

namespace PadLock {
    internal class PadLockGame : Pigeon {
        public override DisplayParams DisplayParams => new DisplayParams(Display.ScreenWidth, Display.ScreenHeight, Display.InitialScale, Display.FrameRate);

        protected override string WindowTitle => "PadLock";
        protected override string Version => Assembly.GetExecutingAssembly().GetName().Version.ToString();
        protected override bool StartMouseVisible => true;
        protected override int FrameRate => Display.FrameRate;
        protected override Color DefaultBkgdColor => Palette.White;
        protected override string SaveFolderName => "PadLock";
        protected override TextureTemplateProcessor TemplateProcessor => null;
        protected override World InitialWorld => new PadDisplay();

        protected override ConsoleOptions ConsoleOptions => new ConsoleOptions();

        protected override void LoadGame() {
            PauseWhenInactive = false;
        }

        protected override void InitializeGame() {
        }
    }
}
