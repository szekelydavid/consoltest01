using System;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RogueTutorial
{
    class GameLoop
    {

        public const int Width = 80;
        public const int Height = 25;

        public int fee;
        public static MapScreen _mapscreen;
        private static Player _player { get; set; }

        static void Main(string[] args)
        {
            // Setup the engine and create the main window.
            SadConsole.Game.Create(Width, Height);

            // Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;

            // Hook the update event that happens each frame so we can trap keys and respond.
            SadConsole.Game.OnUpdate = Update;

            // Start the game.
            SadConsole.Game.Instance.Run();

            //
            // Code here will not run until the game window closes.
            //

            SadConsole.Game.Instance.Dispose();
        }

        private static void Update(GameTime time)
        {
            // Called each logic update.

            // As an example, we'll use the F5 key to make the game full screen
            if (SadConsole.Global.KeyboardState.IsKeyReleased(Microsoft.Xna.Framework.Input.Keys.F5))
            {
                SadConsole.Settings.ToggleFullScreen();
            }

            // Keyboard movement for Player character: Up arrow
            // Decrement player's Y coordinate by 1
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up))
            {
                _player.Position += new Point(0, -1);
            }

            // Keyboard movement for Player character: Down arrow
            // Increment player's Y coordinate by 1
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down))
            {
                _player.Position += new Point(0, 1);
            }

            // Keyboard movement for Player character: Left arrow
            // Decrement player's X coordinate by 1
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Left))
            {
                _player.Position += new Point(-1, 0);
            }

            // Keyboard movement for Player character: Right arrow
            // Increment player's X coordinate by 1
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Right))
            {
                _player.Position += new Point(1, 0);
                _player.Animation.CurrentFrame[0].Glyph = '7';
            }
        }

        private static void Init()
        {
            // Any custom loading and prep. We will use a sample console for now
            //var fontMaster = SadConsole.Global.LoadFont("fonts/monochrome.font");
            //SadConsole.Global.FontDefault = Global.LoadFont("fonts/sprites.font");
            var fontMaster = SadConsole.Global.LoadFont("Fonts/chess.font");
            // Font normalSizedFont;
            //this.Font = normalSizedFont;
            var normalSizedFont = fontMaster.GetFont(Font.FontSizes.Four);

            //var normalSizedFont = fontMaster.GetFont(SadConsole.Font.FontSizes.One);
            
            
            Cell cell = new Cell(Color.AliceBlue,Color.Brown);

            Console startingConsole = new Console(Width, Height, normalSizedFont);
            startingConsole.SetGlyph(5, 5, 4);
            startingConsole.SetGlyph(7, 7, 9);
            _mapscreen = new MapScreen();
            startingConsole.Children.Add(_mapscreen);

            //SadConsole.Global.FontDefault.Master.GetFont(Font.FontSizes.Two)
            //startingConsole.FillWithRandomGarbage();
            //startingConsole.Fill(new Rectangle(3, 3, 27, 5), null, Color.Black, 0, SpriteEffects.None);
            //startingConsole.Print(6, 5, "Hello from SadConsole!@", ColorAnsi.CyanBright);
            //var fontMaster = SadConsole.Global.LoadFont("fonts/IBM.font");
            //startingConsole.Font = fontMaster.GetFont(SadConsole.Font.FontSizes.Four);
            // Set our new console as the thing to render and process
            SadConsole.Global.CurrentScreen = startingConsole;
            var fontMasterPL = SadConsole.Global.LoadFont("Fonts/chess.font");
            var normalSizedFontPL = fontMasterPL.GetFont(Font.FontSizes.Four);
            //váltoZÁS
            // create an instance of player
            _player = new Player();
            _player.Font = normalSizedFontPL;
            _player.Position = new Point(5, 8);
            _player.pGlyph = 13;
            _player.Animation.CurrentFrame[0].Foreground = Color.Green;
            // add the player Entity to our only console
            // so it will display on screen
            startingConsole.Children.Add(_player);
        }

        // Create a player using SadConsole's Entity class
        private static Player CreatePlayer()
        {
            //var fontMaster = Global.LoadFont("Fonts/chess.font");
            //Font normalSizedFont;
            //normalSizedFont = fontMaster.GetFont(Font.FontSizes.One);
            //var fontMaster = SadConsole.Global.LoadFont("Fonts/chess.font");
            //var normalSizedFont = fontMaster.GetFont(Font.FontSizes.Four);
            Player player = new Player();
                //= new SadConsole.Entities.Entity(Microsoft.Xna.Framework.Color.Pink, Microsoft.Xna.Framework.Color.Brown,5);
            //player.Font = normalSizedFont;
            // player.Animation.CurrentFrame[0].Glyph = '7';
            //player.Animation.CurrentFrame[0].Foreground = Color.CornflowerBlue;
            player.Position = new Point(5, 5);
            return player;
        }


    }
}
