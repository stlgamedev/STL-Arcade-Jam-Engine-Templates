# STL Arcade Jam Engine Templates

Example template for games made for the St. Louis Arcade Jam 2018. If you have suggestions feel free to submit issues with those requests or make the changes yourself and submit a pull request. This project is intentionally kept simple so that people do not feel constrained beyond approximately 3-minute long play sessions and a limited pre-defined set of buttons.

### DEFINITELY DO
* Design your game so that a single "credit" or "round" lasts around 3 minutes or less. Arcade designers tried to get quarters out of people, but in our case we just want to make sure all of the venue visitors get a chance to try a few different games instead of waiting around while someone hogs the machine.
* Use a joystick and up to two buttons, and keep their mappings the same as the keys below
* Make sure the "escape" key quits your game immediately (at least in the submitted version of your game)
* Launch full-screen without a resolution picker or other options screen
* Make sure your game outputs as a Windows executable. You can make the game on Mac or Linux, but export a build for Windows
* Keep any important game information away from the edges of the screen. The housing of the monitor cuts off the left and right edges by around a centimeter. 50-100 pixels on each side should be ok.

### DO IF YOU WANT TO
* Use this template at all. You don't need to, you really just need to adhere the principles outlined in the "DEFINITELY DO" section above
* Only use a joystick or only use one button
* Have a score. A lot of players don't care about scores
* Have an in-game title screen
* Support two players. It's fine to support just one player
* Add a Made in St. Louis Spash Screen
* Use one of the technologies from these templates
* Create a similar template in a different technology. More options are always better!

### DEFINITELY DO NOT
* Display the on-screen controls in this demo as-is (we don't want all of the games looking the same)
* Use the fonts, text positions, and text in your game exactly as they appear in this template. Make your game look unique!
* Have an "Options" screen. Arcade games want to get you in the action right away
* Require an installer. We will launch the executable directly

| Player   | Movement      | Button 1   | Button 2   |
|----------|---------------|------------|------------|
| 1        | Arrow Keys    | .          | /          |
| 2        | WASD          | `          | 1          |

| Key           | Action        |
|---------------|---------------|
| ESC           | Back/Home/Quit|
