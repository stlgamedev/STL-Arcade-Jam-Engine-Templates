using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace MonoGame3._6
{
  public class ScoreBoard
  {
    private Player player1;
    private Player player2;
    private SpriteFont font;
    private Vector2 text1Position;
    private Vector2 text2Position;
    private Vector2 score1Position;
    private Vector2 score2Position;
    private Vector2 highScorePosition;
    private Vector2 timePosition;
    private int highScore;
    private CountdownTimer timer;

    private const int MARGIN       = 30;
    private const int LINE_SPACING = 10;
    private const int SCREEN_WIDTH = 1920;
    private const string TEXT1     = "1UP";
    private const string TEXT2     = "2UP";
    private const string HI_TEXT   = "HI-";

    public ScoreBoard(Player player1, Player player2)
    {
      this.player1   = player1;
      this.player2   = player2;
      this.highScore = 0;
      this.timer     = new CountdownTimer(new TimeSpan(0, 3, 1));
    }

    public void LoadContent(ContentManager content)
    {
      font = content.Load<SpriteFont>("Fonts/freaky-fonts_emulogic/emulogic");

      Vector2 text1Size = font.MeasureString(TEXT1);
      text1Position     = new Vector2(MARGIN, MARGIN);
      score1Position    = new Vector2(MARGIN, MARGIN + text1Size.Y);

      Vector2 text2Size  = font.MeasureString(TEXT2);
      text2Position      = new Vector2(SCREEN_WIDTH - MARGIN - text2Size.X, MARGIN);
    }

    public void Update(GameTime gameTime)
    {
      timer.Update(gameTime);

      if (highScore < player1.Score)
      {
        highScore = player1.Score;
      }

      if (highScore < player2.Score)
      {
        highScore = player2.Score;
      }
    }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      string player2ScoreText = FormatScore(player2.Score);
      string highScoreText    = HI_TEXT + FormatScore(highScore);
      string timeText         = FormatTime(timer.Value);

      Vector2 text2Size     = font.MeasureString(TEXT2);
      Vector2 score2Size    = font.MeasureString(player2ScoreText);
      Vector2 highScoreSize = font.MeasureString(highScoreText);
      Vector2 timeSize      = font.MeasureString(timeText);
      score2Position        = new Vector2(SCREEN_WIDTH - MARGIN - score2Size.X, MARGIN + text2Size.Y);
      highScorePosition     = new Vector2((SCREEN_WIDTH / 2) - (highScoreSize.X / 2), MARGIN);
      timePosition          = new Vector2((SCREEN_WIDTH / 2) - (timeSize.X / 2), MARGIN + highScoreSize.Y);

      spriteBatch.DrawString(font, TEXT1, text1Position, Color.White);
      spriteBatch.DrawString(font, FormatScore(player1.Score), score1Position, Color.White);

      spriteBatch.DrawString(font, TEXT2, text2Position, Color.White);
      spriteBatch.DrawString(font, player2ScoreText, score2Position, Color.White);

      spriteBatch.DrawString(font, highScoreText, highScorePosition, Color.White);
      spriteBatch.DrawString(font, timeText, timePosition, Color.White);
    }

    #region Private Method

    private string FormatScore(int score)
    {
      return $"{score:D6}";
    }

    private string FormatTime(TimeSpan time)
    {
      return $"{time.Minutes}:{time.Seconds:D2}";
    }

    #endregion
  }
}