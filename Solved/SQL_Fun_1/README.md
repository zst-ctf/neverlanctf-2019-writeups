# SQL Fun 1
Web

## Challenge 

REPORT: 'My Customer forgot his Password. His Fname is Jimmy. Can you get his password for me? It should be in the users table'

https://challenges.neverlanctf.com:1150

## Solution

A simple page with a textbox to input raw SQL commands

	REPORT: 'My Customer forgot his `Password`. His `Fname` is Jimmy. Can you get his password for me? It should be in the `users` table'

Hence, input this

	SELECT * from `users` WHERE Fname='Jimmy'

And we get the results

	id	Username	Fname	Lname	Email	Password
	2	JimWill	Jimmy	Willman	SQL@example.com	flag{SQL_F0r_Th3_W1n}

## Flag

	flag{SQL_F0r_Th3_W1n}
