%
O0000
    N10 (MACH3 MILL - )
N20 (AUTHOR - {SCOTT SHAFER}) G0 ( second comment )
N30 (GROUP - TOOLPATH GROUP #1)
N40 (SYSTEM- ONECNC-XR2 MILL ADVANTAGE - VERSION 8.12)
N50 (NOTES - NONE)
N60 G0 G40 G49 G50 G80 G94
N70 (.1875 INCH 3/16 HSS END MILL ) ( )
N80 T4 M06 G43 H4
N90 S3411.0 F25.0 M3 M07
N100 G4 P3
N110 G00 X14.9375 Y1.4106 Z0.1
N120 Z0.05
N130 G01 X14.9358 Y1.3786 Z0.0466 F25.0
N140 X14.9376 Y1.3149 Z0.0399
N150 X14.9445 Y1.2515 Z0.0332
N160 X14.9564 Y1.1889 Z0.0265
N170 X14.9734 Y1.1275 Z0.0198
N180 X15.0049 Y1.0575 Z0.0118
N190 X15.0484 Y0.9943 Z0.0037
N200 X15.1023 Y0.9398 Z-0.0044
N210 X15.1652 Y0.8957 Z-0.0124
N220 X15.2348 Y0.8636 Z-0.0205
N230 X15.309 Y0.8443 Z-0.0285

X12 G1.1 (c)G1 G1 (C) G1 
G01 this is text () G01 ;  this is a comment
G34 x12 Y12 Z12  
M12  
N12 X12 () test ;7684
12
23
A21X21 d; as asd  s

G10 this is txt(but this is a comment!)G1 X12 G1 () G1 
A12 x1
B12
o12 goto 20
	G10
o13
not a commentgwerwerqwerv werqwr wqeo gwerq 

(material acrzlic 50x50x3 mm)
(zero point -> plate center, material surface)
(tool -> 1.6 mm end mill)

g21 (Millimeter)
g61 (path mode)
g0 z5
g0 x10 y-10
m6 t55 (loading tool no. 55)
m3 s14000 (spindle ON, 14000 rpm)
g0 z0.5
g1 z-1 f30
g1 x0 y10 f80
g1 x-10 y-10
g1 x10
g0 z5
g0 x18 y-18
g0 z0.5
g1 z-1.1 f30
g1 y18 f80
g1 x-18
g1 y-18
g1 x18
g1 z-2.2 f30
g1 y18 f80
g1 x-18
g1 y-18
g1 x18
g1 z-3.3 f30
g1 y18 f80
g1 x-18
g1 y-18
g1 x18
g0 z5
m5
g0 x0 y0
m02 (end of program)

