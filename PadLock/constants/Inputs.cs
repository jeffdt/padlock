using Microsoft.Xna.Framework.Input;

namespace PadLock.resources {
    public static class Inputs {
        public const int Up = 0;
        public const int Right = 1;
        public const int Down = 2;
        public const int Left = 3;

        public const int Start = 4;
        public const int Select = 5;

        public const int A = 6;
        public const int B = 7;
        public const int X = 8;
        public const int Y = 9;
        public const int L = 10;
        public const int R = 11;

        public static readonly int[] SkipDialog = { A, B, Start };
        public static readonly int[] MenuConfirm = { A, Start };

        public static Buttons[] GamepadMappings {
            get {
                var buttonMappings = new Buttons[8];

                buttonMappings[Up] = Buttons.DPadUp;
                buttonMappings[Right] = Buttons.DPadRight;
                buttonMappings[Down] = Buttons.DPadDown;
                buttonMappings[Left] = Buttons.DPadLeft;
                buttonMappings[Start] = Buttons.Start;
                buttonMappings[Select] = Buttons.Back;
                buttonMappings[A] = Buttons.A;
                buttonMappings[B] = Buttons.X;

                return buttonMappings;
            }
        }

        public static Keys[] PrimaryKeyboardMap {
            get {
                var keyMap = new Keys[8];

                keyMap[Up] = Keys.Up;
                keyMap[Right] = Keys.Right;
                keyMap[Down] = Keys.Down;
                keyMap[Left] = Keys.Left;
                keyMap[Start] = Keys.Enter;
                keyMap[Select] = Keys.Escape;
                keyMap[A] = Keys.M;
                keyMap[B] = Keys.N;

                return keyMap;
            }
        }

        public static Keys[] AltKeyboardMap {
            get {
                var keyMap = new Keys[8];

                keyMap[Up] = Keys.W;
                keyMap[Right] = Keys.D;
                keyMap[Down] = Keys.S;
                keyMap[Left] = Keys.A;
                keyMap[Start] = Keys.Enter;
                keyMap[Select] = Keys.Escape;
                keyMap[A] = Keys.X;
                keyMap[B] = Keys.Z;

                return keyMap;
            }
        }
    }
}
