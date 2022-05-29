using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DinossauroCorrante.Entities
{
    public interface ICollidable
    {
        Rectangle CollisionBox { get; }
    }
}
