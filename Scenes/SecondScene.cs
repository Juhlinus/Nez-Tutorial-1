using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.UI;

namespace Nez_Tutorial_1.Scenes
{
    class SecondScene : BaseScene
    {
        private Table table;

        public override Table Table
        {
            get { return table; }
            set { table = value; }
        }

        public SecondScene() {}

        public override void initialize()
        {
            SetupScene();

            Table.add(new Label("Options Screen").setFontScale(5));

            Table.row().setPadTop(20).setAlign(Align.center);

            Table.add(new Label("This is where we can alter our options!").setFontScale(2));

            Table.row().setPadTop(40).setAlign(Align.center);

            var playButton = Table.add(new TextButton("Next", Skin.createDefaultSkin())).setFillX().setMinHeight(30).getElement<TextButton>();

            playButton.onClicked += PlayButton_onClicked;

            Table.row().setPadTop(40).setAlign(Align.center);

            Table.add(new ProgressBar(0, 1, 0.1f, false, ProgressBarStyle.create(Color.LawnGreen, Color.White)).setValue(0.45f));

            Table.row().setPadTop(40).setAlign(Align.center);

            Table.add(new TextField("A simple Textfield!", Skin.createDefaultSkin()));

            Table.row().setPadTop(40).setAlign(Align.center);

            Table.add(new CheckBox("Is this tutorial great?", Skin.createDefaultSkin()));
        }

        public void PlayButton_onClicked(Button obj)
        {
            var wipeTransition = new TextureWipeTransition(() => new FirstScene())
            {
                transitionTexture = Core.content.Load<Texture2D>("nez/textures/textureWipeTransition/crissCross")
            };

            Core.startSceneTransition(wipeTransition);
        }
    }
}