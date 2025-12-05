: q1 ( a b c -- ) */ NEGATE ;
: q2 ( a b c d -- ) max max max . ;
0 32 - 10 18 */ .
212 32 - 10 18 */ .
-32 32 - 10 18 */ .
32 16 10 18 */ + .
233 273 - .
: F>C 32 - 10 18 */ ;
: C>F 32 18 10 */ +
: K>C 273 - ;
: C>K 273 + ;
: F>K F>C C>K ;
: K>F K>C C>F ;
\ the formulas were so confusing because they weren't split into separate lines...
