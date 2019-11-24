using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game2
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D rectangleBlock;
        Vector2 position = new Vector2(0, 0);

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.IsFullScreen = true;
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 480;
            graphics.SupportedOrientations = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            //rectangleBlock = Content.Load<Texture2D>("squareNikita");
            // rectangleBlock = new Texture2D(GraphicsDevice, 1, 1);
            // Microsoft.Xna.Framework.Color xnaColorBorder = new Microsoft.Xna.Framework.Color(128, 128, 128); // default color gray 
            // rectangleBlock.SetData(new[] { xnaColorBorder });
            //rectangleBlock = Content.Load<Texture2D>("squareNikita.jpg");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            //spriteBatch.Begin();
            //spriteBatch.Draw(rectTexture, position, Color.White);
            //spriteBatch.End();
            //spriteBatch.Begin();
            //Microsoft.Xna.Framework.Point position = new Microsoft.Xna.Framework.Point(100, 50); // position 
            //Microsoft.Xna.Framework.Point size = new Microsoft.Xna.Framework.Point(30, 20); // size 
            //Rectangle rectangle = new Microsoft.Xna.Framework.Rectangle(position, size);
            //Microsoft.Xna.Framework.Color color = new Microsoft.Xna.Framework.Color(255, 255, 0); // color yellow 
            //spriteBatch.Draw(rectangleBlock, rectangle, color);
           // spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
