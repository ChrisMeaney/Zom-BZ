using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScratchyXna;
using Microsoft.Xna.Framework;



namespace Zom_BZ
{
    class TitleSprite:Sprite
    {
        public override void Load()
        {
            AddCostume("intro");
            Scale = 0.5f;
            
        }

        public override void Update(GameTime gameTime)
        {
            
        }

    }
}
