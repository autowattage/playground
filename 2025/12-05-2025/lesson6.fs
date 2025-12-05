: stars ( #n -- ) 0 do 42 emit loop ;
: box ( w h -- ) 0 do cr dup stars loop drop ;
: \stars ( height -- ) 0 do cr i spaces 10 stars loop ;
: /stars ( height -- ) dup 0 do cr dup i - spaces 10 stars loop drop ;
: /stars ( height -- ) begin cr 1- dup spaces 10 stars dup 0= until drop ;

: padding ( i -- ) 15 swap - spaces ;
: tri ( f -- ) if 1 9 1 else -1 1 9 then
    do cr i padding 2 i * 1- stars i padding
    dup +loop drop ;
: diamonds ( #diamonds -- ) 0 do true tri false tri loop ;

: dbld ( balance interest -- )
    over 2 * -rot 21 1
    do
        cr ." Year " i 2 u.r 3 spaces ." Balance "
        2dup over 10 */ 5 + 10 / + rot drop dup . swap
        dup 2over <= i swap
        if cr ." more than doubled " . ." years " drop leave then 2drop
    loop 2drop drop ;

: ** ( n exp -- n' )
    1- dup 0 >=
    if
        over swap 0
        do over * loop
        nip
    else drop then ;
