using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using TMFormat;
using TMFormat.Formats;
using TMFormat.Framework.Resolution;

namespace TibiaMobileDemo
{
    public class GameMain : Game
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;
        IResolution _resolution;

        public GameMain()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight= 600;

            _graphics.PreparingDeviceSettings += graphics_PreparingDeviceSettings;
            _graphics.DeviceCreated += graphics_DeviceCreated;
            Window.ClientSizeChanged += new EventHandler<EventArgs>(OnResize);

        }

        void OnResize(object sender, EventArgs e)
        {
            _graphics.PreferredBackBufferWidth = Window.ClientBounds.Width;
            _graphics.PreferredBackBufferHeight = Window.ClientBounds.Height;
            _graphics.ApplyChanges();
            Debug.WriteLine($"[OnResize] {Window.ClientBounds.Width} x {Window.ClientBounds.Height}");
        }


        void graphics_PreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {/*
            _graphics.PreferMultiSampling = true;
            _graphics.GraphicsProfile = GraphicsProfile.HiDef;
            _graphics.SynchronizeWithVerticalRetrace = true; //Vsync
            _graphics.PreferredDepthStencilFormat = DepthFormat.Depth24Stencil8;
            e.GraphicsDeviceInformation.PresentationParameters.MultiSampleCount = 8;*/
        }

        void graphics_DeviceCreated(object sender, EventArgs e)
        {
            _resolution = new ResolutionComponent(this, _graphics, new Point(800, 600), new Point(_graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight), false, false);
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.Window.Title = "TibiaMobile - Desktop DEMO";
            this.Window.AllowUserResizing = true;
            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            bool loaded = TMInstance.InitGame(GraphicsDevice, Content, "");

            Debug.WriteLine($"[GAME] {loaded}");

            bool maploaded = TMInstance.InitWorld();

            Debug.WriteLine($"[MAP] {maploaded}");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            TMInstance.Map.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            TMInstance.Map.Draw(gameTime);
            base.Draw(gameTime);
        }
    }
}
