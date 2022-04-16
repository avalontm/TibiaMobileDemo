using EmptyKeys.UserInterface;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using TibiaMobileDemo.UI;
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

        public static GameMain Instance { private set; get;}

        public GameMain()
        {
            Instance = this;
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
            if (ScreenManager.Current != null)
            {
                Viewport viewPort = GraphicsDevice.Viewport;
                ScreenManager.Current.Resize(viewPort.Width, viewPort.Height);
            }
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
            int w = 800;
            int h = 600;
            _resolution = new ResolutionComponent(this, _graphics, new Point(w, h), new Point(_graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight), false, false);
            Engine engine = new MonoGameEngine(GraphicsDevice, w, h);

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

            ScreenManager.Init();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (ScreenManager.Current != null)
            {
                ScreenManager.Current?.UpdateInput(gameTime.ElapsedGameTime.TotalMilliseconds);
                ScreenManager.Current?.UpdateLayout(gameTime.ElapsedGameTime.TotalMilliseconds);
            }

            // TODO: Add your update logic here
            TMInstance.Map.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            TMInstance.Map.Draw(gameTime);

            if (ScreenManager.Current != null)
            {
                ScreenManager.Current.Draw(gameTime.ElapsedGameTime.TotalMilliseconds);
            }

            base.Draw(gameTime);
        }
    }
}
