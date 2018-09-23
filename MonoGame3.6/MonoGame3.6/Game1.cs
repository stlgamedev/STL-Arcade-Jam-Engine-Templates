using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame3._6
{
  /// <summary>
  /// This is the main type for your game.
  /// </summary>
  public class Game1 : Game
  {
    private GraphicsDeviceManager graphics;
    private SpriteBatch spriteBatch;
    private Player player1;
    private Player player2;

    public ScoreBoard ScoreBoard { get; private set; }

    public Game1()
    {
      graphics = new GraphicsDeviceManager(this);
      Content.RootDirectory = "Content";      
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
      graphics.PreferredBackBufferWidth = 1920;
      graphics.PreferredBackBufferHeight = 1080;
      graphics.IsFullScreen = true;
      graphics.ApplyChanges();

      Input input = new Input();

      Joystick player1Joystick = new Joystick(
        new Vector2(230, 630),
        new KeyMapping()
        {
          Up      = Keys.Up,
          Right   = Keys.Right,
          Down    = Keys.Down,
          Left    = Keys.Left,
          Button1 = Keys.OemPeriod,
          Button2 = Keys.OemQuestion
        },
        input
      );

      Joystick player2Joystick = new Joystick(
        new Vector2(1095, 630),
        new KeyMapping()
        {
          Up      = Keys.W,
          Right   = Keys.D,
          Down    = Keys.S,
          Left    = Keys.A,
          Button1 = Keys.OemTilde,
          Button2 = Keys.D1
        },
        input
      );

      player1 = new Player(player1Joystick, Color.SkyBlue)
      {
        Position = new Vector2((graphics.PreferredBackBufferWidth / 4) - 60, (graphics.PreferredBackBufferHeight / 4))
      };

      player2 = new Player(player2Joystick, Color.Coral)
      {
        Position = new Vector2((graphics.PreferredBackBufferWidth / 4) * 3 - 60, (graphics.PreferredBackBufferHeight / 4))
      };

      ScoreBoard = new ScoreBoard(player1, player2);

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

      // TODO: use this.Content to load your game content here

      player1.LoadContent(Content);
      player2.LoadContent(Content);
      
      ScoreBoard.LoadContent(Content);
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
      if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
      {
        Exit();
      }

      // TODO: Add your update logic here
      player1.Update(gameTime);
      player2.Update(gameTime);
      ScoreBoard.Update(gameTime);

      base.Update(gameTime);
    }

    /// <summary>
    /// This is called when the game should draw itself.
    /// </summary>
    /// <param name="gameTime">Provides a snapshot of timing values.</param>
    protected override void Draw(GameTime gameTime)
    {
      GraphicsDevice.Clear(Color.DimGray);

      // TODO: Add your drawing code here
      spriteBatch.Begin();
      player1.Draw(gameTime, spriteBatch);
      player2.Draw(gameTime, spriteBatch);
      ScoreBoard.Draw(gameTime, spriteBatch);
      spriteBatch.End();

      base.Draw(gameTime);
    }
  }
}