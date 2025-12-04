: STAR    [CHAR] * EMIT ;
: STARS   0 DO  STAR  LOOP ;
: MARGIN  CR 30 SPACES ;
: BLIP    MARGIN STAR ;
: BAR     MARGIN 5 STARS ;
: F       BAR BLIP BAR BLIP BLIP CR ;
: q1 ." Test heartbeats to send out to hackatime" ;
: q2 ." Test heartbeats for hackatime part two" ;
: q3 ." Test heartbeats please work pls pls psl " ;
