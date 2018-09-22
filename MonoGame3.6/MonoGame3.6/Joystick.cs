using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace MonoGame3._6
{
  public class Joystick
  {
    private KeyMapping mapping;
    private Input input;
    private Vector2 joystickPosition;
    private Vector2 button1Position;
    private Vector2 button2Position;
    private Dictionary<JoystickDirection, Texture2D> joystickTextures;
    private Dictionary<ArcadeButtonState, Texture2D> buttonTextures;

    public JoystickDirection Direction { get; private set; }
    public ArcadeButtonState Button1   { get; private set; }
    public ArcadeButtonState Button2   { get; private set; }
    public Vector2 Velocity            { get; private set; }

    public Joystick(Vector2 position, KeyMapping mapping, Input input)
    {
      this.input            = input;
      this.joystickPosition = position;
      this.button1Position  = new Vector2(position.X + 445, position.Y + 190);
      this.button2Position  = new Vector2(position.X + 285, position.Y + 190);      
      this.mapping          = mapping;      
      this.Direction        = JoystickDirection.Center;
      this.Button1          = ArcadeButtonState.Released;
      this.Button2          = ArcadeButtonState.Released;
      this.joystickTextures = new Dictionary<JoystickDirection, Texture2D>();
      this.buttonTextures   = new Dictionary<ArcadeButtonState, Texture2D>();
      this.Velocity         = Vector2.Zero;
    }

    public void LoadContent(ContentManager content)
    {
      joystickTextures.Add(JoystickDirection.Center, content.Load<Texture2D>("Sprites/joystickCenter"));
      joystickTextures.Add(JoystickDirection.Up, content.Load<Texture2D>("Sprites/joystickUp"));
      joystickTextures.Add(JoystickDirection.UpRight, content.Load<Texture2D>("Sprites/joystickUpRight"));
      joystickTextures.Add(JoystickDirection.Right, content.Load<Texture2D>("Sprites/joystickRight"));
      joystickTextures.Add(JoystickDirection.DownRight, content.Load<Texture2D>("Sprites/joystickDownRight"));
      joystickTextures.Add(JoystickDirection.Down, content.Load<Texture2D>("Sprites/joystickDown"));
      joystickTextures.Add(JoystickDirection.DownLeft, content.Load<Texture2D>("Sprites/joystickDownLeft"));
      joystickTextures.Add(JoystickDirection.Left, content.Load<Texture2D>("Sprites/joystickLeft"));
      joystickTextures.Add(JoystickDirection.UpLeft, content.Load<Texture2D>("Sprites/joystickUpLeft"));

      buttonTextures.Add(ArcadeButtonState.Released, content.Load<Texture2D>("Sprites/button_up"));
      buttonTextures.Add(ArcadeButtonState.Pressed, content.Load<Texture2D>("Sprites/button_down"));
    }

    public void Update(GameTime gameTime)
    {
      input.Update(gameTime);

      Vector2 position = Vector2.Zero;

      if (input.IsKeyDown(mapping.Up))
      {
        position.Y = -1;
      }
      else if (input.IsKeyDown(mapping.Down))
      {
        position.Y = 1;
      }

      if (input.IsKeyDown(mapping.Right))
      {
        position.X = 1;
      }
      else if (input.IsKeyDown(mapping.Left))
      {
        position.X = -1;
      }
      
      Velocity  = position;
      Direction = GetDirection(position);
      Button1   = (input.IsKeyDown(mapping.Button1)) ? ArcadeButtonState.Pressed : ArcadeButtonState.Released;
      Button2   = (input.IsKeyDown(mapping.Button2)) ? ArcadeButtonState.Pressed : ArcadeButtonState.Released;
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Draw(joystickTextures[Direction], joystickPosition, Color.White);
      spriteBatch.Draw(buttonTextures[Button1], button1Position, Color.White);
      spriteBatch.Draw(buttonTextures[Button2], button2Position, Color.White);
    }

    #region Private Methods

    private JoystickDirection GetDirection(Vector2 position)
    {
      JoystickDirection direction = JoystickDirection.Center;

      if (position.Y == -1)
      {
        if (position.X == -1)
        {
          direction = JoystickDirection.UpLeft;
        }
        else if (position.X == 1)
        {
          direction = JoystickDirection.UpRight;
        }
        else
        {
          direction = JoystickDirection.Up;
        }
      }
      else if (position.Y == 1)
      {
        if (position.X == -1)
        {
          direction = JoystickDirection.DownLeft;
        }
        else if (position.X == 1)
        {
          direction = JoystickDirection.DownRight;
        }
        else
        {
          direction = JoystickDirection.Down;
        }
      }
      else
      {
        if (position.X == -1)
        {
          direction = JoystickDirection.Left;
        }
        else if (position.X == 1)
        {
          direction = JoystickDirection.Right;
        }
      }

      return direction;
    }

    #endregion
  }
}