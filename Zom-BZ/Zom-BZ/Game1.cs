using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using ScratchyXna;
namespace Zom_BZ
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : ScratchyXnaGame
    {
        public override void LoadScenes()
        {
            AddScene<TitleScene>();
            AddScene<Level1>();
        }
    }
}

      