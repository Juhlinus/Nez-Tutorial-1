using Nez;

namespace Nez_Tutorial_1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Core
    {
        public Game1() { }

        protected override void Initialize()
        {
            base.Initialize();

            var firstScene = Scene.createWithDefaultRenderer();

            scene = new Scenes.FirstScene();
        }

    }
}
