﻿using EmptyKeys.UserInterface;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using TibiaMobileDemo.UI;
using TMFormat;
using TMFormat.Framework.Inputs;
using TMFormat.Framework.Maps;
using TMFormat.Framework.Resolution;

namespace TibiaMobileDemo
{

    public class GameMain : Game
    {
        #region variables
        [DllImport("SDL2.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SDL_MaximizeWindow(IntPtr window);

        [DllImport("SDL2.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDL_ShowSimpleMessageBox(uint flags, string title, string message, IntPtr window);


        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;
        IResolution _resolution;
        int ScreenX = 800;
        int ScreenY = 600;
        public static GameMain Instance { private set; get; }

        #endregion


        public GameMain()
        {
            Instance = this;
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferWidth = ScreenX;
            _graphics.PreferredBackBufferHeight = ScreenY;

            _graphics.DeviceCreated += graphics_DeviceCreated;
            _graphics.PreparingDeviceSettings += graphics_PreparingDeviceSettings;
            Window.ClientSizeChanged += new EventHandler<EventArgs>(OnResize);

        }

        /// <summary>
        /// OnResize
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnResize(object sender, EventArgs e)
        {
            Viewport viewPort = GraphicsDevice.Viewport;

            if (ScreenManager.Current != null)
            {
                if (viewPort.Width >= ScreenX && viewPort.Height >= ScreenY)
                {
                    _graphics.PreferredBackBufferWidth = viewPort.Width;
                    _graphics.PreferredBackBufferHeight = viewPort.Height;
                    _graphics.ApplyChanges();
                    ScreenManager.Current.Resize(viewPort.Width, viewPort.Height);
                    _resolution.Resize(viewPort.Width, viewPort.Height);
                }
                else
                {
                    _graphics.PreferredBackBufferWidth = ScreenX;
                    _graphics.PreferredBackBufferHeight = ScreenY;
                    _graphics.ApplyChanges();
                }
            }
        }

        /// <summary>
        /// PreparingDeviceSettings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void graphics_PreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {
            
            //_graphics.PreferMultiSampling = true;
            //_graphics.GraphicsProfile = GraphicsProfile.HiDef;
            //_graphics.SynchronizeWithVerticalRetrace = true; //Vsync
           // _graphics.PreferredDepthStencilFormat = DepthFormat.Depth24Stencil8;
            //e.GraphicsDeviceInformation.PresentationParameters.MultiSampleCount = 8;
            
        }

        /// <summary>
        /// DeviceCreated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void graphics_DeviceCreated(object sender, EventArgs e)
        {
            _resolution = new ResolutionComponent(this, _graphics, new Point(ScreenX, ScreenY), new Point(ScreenX, ScreenY), false, false, true);
            Engine engine = new MonoGameEngine(GraphicsDevice, ScreenX, ScreenY);
        }

        protected override void Initialize()
        {
            this.IsFixedTimeStep = true;
            this.TargetElapsedTime = TimeSpan.FromSeconds(1.0 / 60.0);

            // TODO: Add your initialization logic here
            this.Window.Title = "TibiaMobile - Desktop DEMO";
            this.Window.AllowUserResizing = true;

            base.Initialize();

        }

        protected override async void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            bool loaded = await TMInstance.InitGame(GraphicsDevice, Content, true);
            Debug.WriteLine($"[GAME] {loaded} - {TMInstance.Map.MapBase.Items.Count} items.");

            if(!loaded)
            {
                SDL_ShowSimpleMessageBox(0x10, "Error", "Error al cargar los items del juego.", IntPtr.Zero);
                Environment.Exit(0); // <- Cierra el juego
                return;
            }

            bool maploaded = TMInstance.InitWorld();
            Debug.WriteLine($"[MAP] {maploaded}");

            if (!maploaded)
            {
                SDL_ShowSimpleMessageBox(0x10, "Error", "Error al cargar el mapa del juego.", IntPtr.Zero);
                Environment.Exit(0); // <- Cierra el juego
                return;
            }

            ScreenManager.Init();

            //Actualizamos el inicio de la ventana
            _resolution.Resize(ScreenX, ScreenY);

            //Maximizamos la ventana
            Window.Position = new Point(0, 0);
            SDL_MaximizeWindow(Window.Handle);

            //Generamos el personaje
            TMInstance.Map.onPlayerSpawn();
        }

        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here

            if (ScreenManager.Current != null)
            {
                ScreenManager.Current?.UpdateInput(gameTime.ElapsedGameTime.TotalMilliseconds);
                ScreenManager.Current?.UpdateLayout(gameTime.ElapsedGameTime.TotalMilliseconds);
            }

            TMInstance.Map.Update(gameTime);

            if (KeyboardManager.IsKeyDown(Keys.Up))
            {
                KeyboardManager.Move(TMFormat.Framework.Enums.PlayerDir.North);
            }
            else if (KeyboardManager.IsKeyDown(Keys.Left))
            {
                KeyboardManager.Move(TMFormat.Framework.Enums.PlayerDir.West);
            }
            else if (KeyboardManager.IsKeyDown(Keys.Down))
            {
                KeyboardManager.Move(TMFormat.Framework.Enums.PlayerDir.South);
            }
            else if (KeyboardManager.IsKeyDown(Keys.Right))
            {
                KeyboardManager.Move(TMFormat.Framework.Enums.PlayerDir.East);
            }

            if (KeyboardManager.IsKeyPressed(Keys.Escape))
            {
                Debug.WriteLine($"[SPACE] {DateTime.Now.ToString("hh:mm:ss")}");
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            // TODO: Add your drawing code here

            GraphicsDevice.Clear(Color.CornflowerBlue);

            TMInstance.Map.Draw(gameTime);

            if (ScreenManager.Current != null)
            {
                ScreenManager.Current.Draw(gameTime.ElapsedGameTime.TotalMilliseconds);
            }

            base.Draw(gameTime);
        }
    }
}
