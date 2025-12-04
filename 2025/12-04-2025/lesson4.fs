: card ( age -- ) 20 > if ." ALCOHOLIC BEVERAGES PERMITTED " else ." UNDER AGE " then ;
: sign.test ( n -- )
    dup 0> if ." positive " drop else
    dup 0< if ." negative " drop else ." zero "
    then then
;
: stars ( n -- ) dup 0> if 0 do 42 emit loop else ." invalid stars " then ;
: within ( n low high -- flag ) rot dup -rot > -rot <= AND ;
: guess ( answer guess -- )
    2dup = if ." correct! " else
    2dup > if ." too low " else ." too high "
    then then drop drop
;
: speller ( n -- )
    dup abs 4 > if ." out of range " else
        dup 0< if ." negative " then
        dup 0= if ." zero " else
        abs dup 1 = if ." one " else
        dup 2 = if ." two " else
        dup 3 = if ." three " else
        dup 4 = if ." four "
    then then then then then then drop
;
: trap ( answer low high -- answer )
    dup 2over rot within if ." in between " drop drop
    else over = -rot over = rot AND if ." correct! " drop else ." not in between "
    then then
;
