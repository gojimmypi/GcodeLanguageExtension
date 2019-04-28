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
not a comment
gwerwerqwerv werqwr wqeo gwerq 

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

