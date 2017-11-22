﻿using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.UI;

namespace Nez_Tutorial_1.Scenes
{
    class FirstScene : BaseScene
    {
        private Table table;

        public override Table Table
        {
            get { return table; }
            set { table = value; }
        }

        public FirstScene() {}

        public override void initialize()
        {
            SetupScene();

            Table.setFillParent(true).top().padLeft(10).padTop(50);

            Table.add(new Label("Main Menu").setFontScale(5));

            Table.row().setPadTop(20).setAlign(Align.center);

            Table.add(new Label("This is our main menu for our game!").setFontScale(2));

            Table.row().setPadTop(40).setAlign(Align.center);

            var playButton = Table.add(new TextButton("Next", Skin.createDefaultSkin())).setFillX().setMinHeight(30).getElement<TextButton>();

            playButton.onClicked += PlayButton_onClicked;
        }

        public void PlayButton_onClicked(Button obj)
        {
            var wipeTransition = new TextureWipeTransition(() => new SecondScene())
            {
                transitionTexture = Core.content.Load<Texture2D>("nez/textures/textureWipeTransition/wink")
            };

            Core.startSceneTransition(wipeTransition);
        }
    }
}
