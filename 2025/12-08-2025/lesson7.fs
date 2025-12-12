: n-max 0 begin 1+ dup 0= until drop . ;
: beep 500 ms ." beep " ;
: ring beep beep beep ;

: F>C ( f -- c ) -32 M+ 10 18 M*/ ;
: C>F ( c -- f ) 32 18 10 */ M+ ; 
: C>K ( c -- k ) 273 M+ ;
: K>C ( k -- c ) -273 M+ ;
: K>F ( k -- f ) k>c c>f M+ ;
: F>K ( f -- k ) f>c c>k ;

0.0 f>c
212.0 f>c
20.0 f>c
16.0 c>f
-40.0 c>f
100.0 k>c
100.0 k>f
233.0 k>c
233.0 k>f

\ I may have forgot that factoring exists
: quad ( x -- d ) dup 20 * 5 + swap dup * 7 m* ;
: .bases
    17 0 do
        cr ." Decimal: " decimal i 2 u.r
        ."   Hex: " hex i 2 u.r
        ."   Binary: " 2 base ! i 2 u.r
    loop
;
: .ph#
    <# # # # # [char] - hold # # #
    #> type space ;
