///get_input()
if keyboard_check_pressed(vk_escape) { game_end(); }

if name == "player1" {
    RIGHT = keyboard_check (vk_right);
    LEFT = keyboard_check (vk_left);
    UP = keyboard_check (vk_up);
    DOWN = keyboard_check (vk_down);
    B1 = keyboard_check_pressed(190); // keyboard_check (ord('.'));
    B2 = keyboard_check_pressed(191); // keyboard_check (ord('/'));
    B1held = keyboard_check(190); // keyboard_check (ord('.'));
    B2held = keyboard_check(191); // keyboard_check (ord('/'));
} 

if name == "player2" {
    RIGHT = keyboard_check (ord('D'));
    LEFT = keyboard_check (ord('A'));
    UP = keyboard_check (ord('W'));
    DOWN = keyboard_check (ord('S'));
    B1 = keyboard_check_pressed(192); // keyboard_check (ord('`'));
    B2 = keyboard_check_pressed(49); // keyboard_check (ord('1'));
    B1held = keyboard_check(192); // keyboard_check (ord('`'));
    B2held = keyboard_check(49); // keyboard_check (ord('1'));
}
