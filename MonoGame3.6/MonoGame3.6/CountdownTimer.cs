using Microsoft.Xna.Framework;
using System;

namespace MonoGame3._6
{
  public class CountdownTimer
  {
    public TimeSpan Value { get; private set; }

    public CountdownTimer(TimeSpan time)
    {
      this.Value = time;
    }

    public void Update(GameTime gameTime)
    {
      if (Value != TimeSpan.MinValue)
      {
        Value = Value.Subtract(new TimeSpan(gameTime.ElapsedGameTime.Ticks));

        if (Value.TotalSeconds < 0)
        {
          Value = TimeSpan.MinValue;
        }
      }
    }
  }
}