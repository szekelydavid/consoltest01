using System;
using System.Linq;
using System.Collections.Generic;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SadConsole.Themes;

namespace RogueTutorial
{
    public class Player : SadConsole.Entities.Entity
    {
        public Player() : base(Microsoft.Xna.Framework.Color.Pink, Microsoft.Xna.Framework.Color.Brown, 5) {
            Animation.CurrentFrame[0].Glyph = '!';
            Animation.CurrentFrame[0].Foreground = Color.BlueViolet;
            
        }
        public int pGlyph { get { return Animation.CurrentFrame[0].Glyph; } set { Animation.CurrentFrame[0].Glyph = value; } }
        Point Position { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        /*
        public void DrawStats(Console statConsole)
        {
            statConsole.CellData.Print(1, 1, $"Name:    {Name}", Color.White);
            statConsole.CellData.Print(1, 3, $"Health:  {Health}/{MaxHealth}", Color.White);
            statConsole.CellData.Print(1, 5, $"Attack:  {Attack} ({AttackChance}%)", Color.White);
            statConsole.CellData.Print(1, 7, $"Defense: {Defense} ({DefenseChance}%)", Color.White);
            statConsole.CellData.Print(1, 9, $"Gold:    {Gold}", Color.Yellow);
        }
        */
    }
}
