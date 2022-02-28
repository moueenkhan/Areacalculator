™
IC:\Users\Moueen\Documents\Mob programming\calculatearea\console\Circle.cs
	namespace 	
CalculateArea
 
{ 
public 

class 
Circle 
: 
Shape 
{ 
private 
readonly 
float 
_radius &
;& '
public 
Circle 
( 
float 
radius "
)" #
{		 	
this

 
.

 
_radius

 
=

 
radius

 !
;

! "
} 	
public 
float 
GetArea 
( 
) 
{ 	
return 
( 
float 
) 
Math 
. 
PI !
*" #
_radius$ +
*, -
_radius. 5
;5 6
} 	
} 
} µ
JC:\Users\Moueen\Documents\Mob programming\calculatearea\console\Program.cs
	namespace 	
CalculateArea
 
{ 
public 

class 
Program 
{ 
public		 
static		 
void		 
Main		 
(		  
string		  &
[		& '
]		' (
args		) -
)		- .
{

 	
var 
square 
= 
new 
Square #
(# $
$num$ (
)( )
;) *
System 
. 
Console 
. 
	WriteLine $
($ %
square& ,
., -
GetArea- 4
(4 5
)5 6
)7 8
;8 9
} 	
} 
} «
LC:\Users\Moueen\Documents\Mob programming\calculatearea\console\Rectangle.cs
	namespace 	
CalculateArea
 
{ 
public 

class 
	Rectangle 
: 
Shape "
{ 
private 
readonly 
float 
_length &
;& '
private 
readonly 
float 
_breadth '
;' (
public 
	Rectangle 
( 
float 
length %
,% &
float' ,
breadth- 4
)4 5
{		 	
this

 
.

 
_length

 
=

 
length

 !
;

! "
this 
. 
_breadth 
= 
breadth #
;# $
} 	
public 
float 
GetArea 
( 
) 
{ 	
return 
_length 
* 
_breadth %
;% &
} 	
} 
} ≈
HC:\Users\Moueen\Documents\Mob programming\calculatearea\console\Shape.cs
	namespace 	
CalculateArea
 
{ 
public 

	interface 
Shape 
{ 
float 
GetArea 
( 
) 
; 
} 
} è
IC:\Users\Moueen\Documents\Mob programming\calculatearea\console\Square.cs
	namespace 	
CalculateArea
 
{ 
public 

class 
Square 
: 
	Rectangle #
{ 
public 
Square 
( 
float 
side  
)  !
:" #
base$ (
(( )
side) -
,- .
side. 2
)2 3
{ 	
} 	
} 
}		 