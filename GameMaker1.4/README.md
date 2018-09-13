## STL Arcade Jam 
# GameMaker Studio 1.4 Template

This is an example template for games made with GameMaker Studio 1.4 for the St. Louis Arcade Jam 2018. If you have suggestions feel free to submit issues with those requests or make the changes yourself and submit a pull request.
\
Below are items that should stay unchanged in your project to insure it is compatible with the Winnitron game launcher in the arcade cabinet.  All other assets are included only for an example and can be discarded.
\

## Global Game Settings

### Windows > General

* DISABLED Display the cursor
* DISABLED Display Splash Screen
\
### Windows > Graphics

* ENABLED Start in fulscreen mode
* ENABLED Interpolate colors between pixels\
*disable this if you are using low-res pixel art*
* ENABLED Use synchronization to avoid tearing\
*disable if screen tearing is no problem for your game and you need the slightly faster response time*
* DISABLED Allow the player to resize the game window
* DISABLED Allow switching to fullscreen
\

## Scripts
### get_input()
You can handle these controls however you like, I chose to put them into a script. Just make sure that pressing the escape key will quit the game and that the proper keybindings for player 1 and player 2 are used.

* **ESCAPE** to quit game

* **PLAYER 1**
> movement = arrow keys \
> button 1 = period/greater-than key ( *keyboard_check(190)* ) \
> button 2 = question mark/slash key ( *keyboard_check(191)* ) \

* **PLAYER 2**
> movement = W A S D \
> button 1 = tilde/grave accent key ( *keyboard_check(192)* ) \
> button 2 = exclamation mark/1 key ( *keyboard_check(49)* ) \
\

## Rooms
### Room/Port Ratio

* Be sure either your room or port size (if using views) is at a **16 x 9 ratio** .  The example rooms included are at 1920 x 1080 (for a high-res game), and 320 x 180 (for low-res pixel art), but you can use any dimensions as long as they are 16 x 9.
\

## Further Questions
Refer to the [Winnitron Requirements](https://github.com/winnitron/WinnitronLauncher/wiki/Requirements-for-Winnitron-Games) page for more information.\
Alternate [GameMaker Studio template](https://github.com/Ludonaut/Winnitron-Templates/tree/master/GameMaker%20Studio) by Ludonaut.