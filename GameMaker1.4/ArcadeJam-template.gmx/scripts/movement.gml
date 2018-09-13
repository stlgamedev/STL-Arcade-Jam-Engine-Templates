/// movement()

// GET MOVE AXES
xaxis = (RIGHT - LEFT);
yaxis = (DOWN - UP);


// GET LENGTH & DIRECTION
if (xaxis == 0 && yaxis == 0) {
    spd = 0; 
    exit;
} else {
    dir = point_direction (0, 0, xaxis, yaxis);
    spd = movespd;
}

// MOVE IF NOT COLLIDING WITH A WALL
for (var s = spd; s > 0; s--) {
    hspd = lengthdir_x(s,dir);
    vspd = lengthdir_y(s,dir);        
    if !place_meeting(x+hspd,y+vspd,o_wall) {
        x += hspd;
        y += vspd;
        exit;
    } else if s < 2 {
        dir = 45*floor(dir/45);
        // SWEEP TO FIND AN ALTERNATE DIRECTION TO MOVE IN
        var interval = 45;
        for (var angle = interval; angle <= 90; angle += interval) {
            for (var sweepdir = -1; sweepdir <= 1; sweepdir += 2) {
                var angle_check = dir+angle*sweepdir;
                hspd = lengthdir_x(spd,angle_check);
                vspd = lengthdir_y(spd,angle_check);     
                if !place_meeting(x+hspd,y+vspd,o_wall) {
                    x += hspd;
                    y += vspd;
                    exit;
                }
            }
        }
    }
}
