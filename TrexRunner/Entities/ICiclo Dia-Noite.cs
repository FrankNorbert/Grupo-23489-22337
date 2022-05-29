using Microsoft.Xna.Framework;

namespace DinossauroCorrante.Entities
{
    public interface IDayNightCycle
    {
        int NightCount { get; }
        bool IsNight { get; }

        Color ClearColor { get; }

    }
}
