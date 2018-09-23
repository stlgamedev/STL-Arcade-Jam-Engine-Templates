using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame3._6
{
  public class Player
  {
    private Joystick joystick;
    private Texture2D texture;
    private Color color;
    private float speed = 5;
    private bool was1Pressed = false;
    private bool was2Pressed = false;

    public Vector2 Position { get; set; }
    public int Score        { get; set; }

    public Player(Joystick joystick, Color color)
    {
      this.joystick = joystick;
      this.Position = Vector2.Zero;
      this.color    = color;
    }

    public void LoadContent(ContentManager content)
    {
      texture = content.Load<Texture2D>("Sprites/whiteBoxCharacter");
      joystick.LoadContent(content);
    }

    public void Update(GameTime gameTime)
    {
      joystick.Update(gameTime);
      Position += joystick.Velocity * speed;

      if (was1Pressed == false && joystick.Button1 == ArcadeButtonState.Pressed)
      {
        ++Score;
        was1Pressed = true;
      }
      else if (joystick.Button1 == ArcadeButtonState.Released)
      {
        was1Pressed = false;
      }

      if (was2Pressed == false && joystick.Button2 == ArcadeButtonState.Pressed)
      {
        was2Pressed = true;

        if (Score > 0)
        {
          --Score;
        }
      }
      else if (joystick.Button2 == ArcadeButtonState.Released)
      {
        was2Pressed = false;
      }
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Draw(texture, Position, color);
      joystick.Draw(gameTime, spriteBatch);
    }
  }
}