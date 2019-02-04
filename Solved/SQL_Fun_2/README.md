# SQL Fun 2
Web

## Challenge 

REPORT: A Client forgot his Password... again. Could you get it for me? He has a users account and his Lname is Miller if that helps at all. Oh! and Ken was saying something about a new table called passwd; said it was better to separate things

https://challenges.neverlanctf.com:1155

## Solution

So we do a simple retrieval of the Lname

	SELECT * FROM `users` WHERE Lname='Miller'

And we get the results with a hint.

	id	Username	Fname	Lname	Email
	5	DisUser	Tom	Miller	Miller@example.com
	maybe try JOINing another table

So we need to [use the JOIN query](https://www.w3schools.com/sql/sql_join.asp)

	SELECT * FROM users 
	INNER JOIN passwd ON users.id=passwd.user_id
	WHERE Lname='Miller'

And we get the results

	2	DisUser	Tom	Miller	Miller@example.com	5	ZmxhZ3tXMWxsX1kwdV9KMDFOX00zP30=

Base64 decode it

## Flag

	flag{W1ll_Y0u_J01N_M3?}
