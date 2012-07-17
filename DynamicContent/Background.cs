﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Platformer
{
    public class Background
    {
        public int ID
        {
            get;
            set;
        }

        public Vector2 Velocity
        {
            get;
            set;
        }

        public Vector2 Position
        {
            get;
            set;
        }
    }
}
