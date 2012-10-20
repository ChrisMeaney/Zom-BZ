using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScratchyXna;
using Microsoft.Xna.Framework;



namespace Zom_BZ
{
    class StartButton:Sprite
    {
        public override void Load()
        {
            AddCostume("startbutton");
            Scale = 0.4f;
        }

        public override void Update(GameTime gameTime)
        {
            
        }

    }
}
