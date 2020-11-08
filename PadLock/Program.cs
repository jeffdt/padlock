using System;

namespace PadLock {
    public static class Program {
        [STAThread]
        static void Main() {
            using var game = new PadLockGame();
            game.Run();
        }
    }
}
