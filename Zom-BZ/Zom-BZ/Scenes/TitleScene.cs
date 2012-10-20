using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScratchyXna;
using Microsoft.Xna.Framework;



namespace Zom_BZ
{
    class TitleScene:Scene
    {
        StartButton startbutton;

        public override void Load()
        {
            this.BackgroundColor = Color.DarkRed;
            AddSprite(new TitleSprite());
            startbutton = new StartButton();
            AddSprite(startbutton);
            startbutton.X = 120f;
            LoadFont("QuartzMS");
        }

        public override void Update(GameTime gameTime)
        {
            if (startbutton.IsTouching(Mouse.Position))
            {
                if (Mouse.Button1Pressed())
                {
                    ShowScene("Level1");
                }
            }
        }

    }
}
