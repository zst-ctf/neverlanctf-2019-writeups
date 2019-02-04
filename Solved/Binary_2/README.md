# Binary 2
Binary

## Challenge 

	Our lead Software Engineer recently left and deleted all the source code 
	and changed the login information for our employee payroll application. 
	Without the login information none of our employees will be paid. 
	Can you help us by finding the login information?

	***Flag is all caps

[Employee_Payroll.exe](Employee_Payroll.exe)

## Solution

	$ file *.exe
	Employee_Payroll.exe: PE32 executable (GUI) Intel 80386 Mono/.Net assembly, for MS Windows

Since this is a NET app, use JetBrains dotPeek to decompile:

And we get the source code

1. [Program.cs](Program_decompile.cs)
2. [employee_payroll.cs](employee_payroll_decompile.cs)

---

From the source code we can see the password inside `employee_payroll.cs`.

It is created inside the `btnLogin_Click()` function. 

It appends `r1` through `r53`. I extracted it into a simple script to get the ASCII flag

	$ python3 solve.py 
	flag{ST0RING_STAT1C_PA55WORDS_1N_FIL3S_1S_N0T_S3CUR3}

## Flag

	flag{ST0RING_STAT1C_PA55WORDS_1N_FIL3S_1S_N0T_S3CUR3}
