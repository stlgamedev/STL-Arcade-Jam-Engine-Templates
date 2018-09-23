using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MonoGame3._6
{
  public class Input
  {
    private KeyboardState previousState;
    private KeyboardState currentState;

    public void Update(GameTime gameTime)
    {
      previousState = currentState;
      currentState  = Keyboard.GetState();
    }

    public bool IsKeyPressed(Keys key)
    {
      return currentState.IsKeyDown(key) && previousState.IsKeyUp(key);
    }

    public bool IsKeyDown(Keys key)
    {
      return currentState.IsKeyDown(key) && previousState.IsKeyDown(key);
    }

    public bool IsKeyReleased(Keys key)
    {
      return currentState.IsKeyUp(key) && previousState.IsKeyDown(key);
    }
  }
}