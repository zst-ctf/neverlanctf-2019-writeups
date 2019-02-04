# Binary 4
Binary

## Challenge 

	It appears we're not doing a very good job at employee retention and statisfaction.
	Now our Embedded Firmawre Engineer has left and removed the source code for our latest IoT firmware. 
	Please help us to recover the source code for the following hex file. 
	We would prefer C, but assembly would work as well. I also think there's a flag somewhere in the sorce for you.

[embedded_db.hex](embedded_db.hex)

## Solution

We are given an [Intel HEX file](https://en.wikipedia.org/wiki/Intel_HEX#Record_types)

We need to convert it into a binary first. If you have [AVR-GCC installed, it will be helpful as we need the tools.](https://www.avrfreaks.net/forum/how-convert-intel-hex-file-raw-data-memory-view)

	$ avr-objcopy -I ihex -O binary embedded_db.hex embedded.bin

Now it is converted into a binary file and we can view its contents. 

From the text, we know it is an Arduino binary.

	$ cat embedded.bin | xxd | tail -10
	00001370: 2196 c633 d107 c9f7 f894 ffcf 0000 6602  !..3..........f.
	00001380: 8000 0000 0000 1c01 8500 b400 6301 e500  ............c...
	00001390: c300 d700 2525 2e25 6458 0061 646d 696e  ....%%.%dX.admin
	000013a0: 0064 4768 6c63 3255 6759 584a 6c49 4735  .dGhlc2UgYXJlIG5
	000013b0: 7664 4342 3061 4755 6759 3268 6863 6d46  vdCB0aGUgY2hhcmF
	000013c0: 6a64 4756 7963 7942 3562 3355 6759 584a  jdGVycyB5b3UgYXJ
	000013d0: 6c49 4778 7662 3274 7062 6d63 675a 6d39  lIGxvb2tpbmcgZm9
	000013e0: 7900 3c41 7264 7569 6e6f 2069 7320 7265  y.<Arduino is re
	000013f0: 6164 793e 000d 0a00 5468 6973 206a 7573  ady>....This jus
	00001400: 7420 696e 202e 2e2e 2000                 t in ... .

Trying out that base64-encoded text...

	$ echo "dGhlc2UgYXJlIG5vdCB0aGUgY2hhcmFjdGVycyB5b3UgYXJlIGxvb2tpbmcgZm9y" | base64 -D
	these are not the characters you are looking for

Since Arduino runs on AVR, disassemble it using avr-objdump to see the source code. 

	$ avr-objdump -Dz -m avr embedded_db.hex > objdump.dsm

After some analysis, we notice that a function is being called repeatedly with a changing parameter

     720:   8a e5           ldi r24, 0x5A   ; 90
     722:   90 e0           ldi r25, 0x00   ; 0
     724:   0e 94 a1 01     call    0x342   ;  0x342
     728:   8d e6           ldi r24, 0x6D   ; 109
     72a:   90 e0           ldi r25, 0x00   ; 0
     72c:   0e 94 a1 01     call    0x342   ;  0x342

In this case, function `*0x342` is being called with `r24` changing for each time it is called.

I extract the code from address 0x720 to 0x89c, which covers all function calls to `*0x342`

> [extracted_code.txt](extracted_code.txt)

Using regex, I extracted the hex value. 

> [extracted_hex.txt](extracted_hex.txt)
>
> 5A6D78685A3374545644464D54463956557A464F4E6C39545644513353554E66554451314E566450556B525466513D3D79

When we convert to ASCII, it shows a Base64 string and we can decode it to get the flag

	$ cat extracted_hex.txt | xxd -r -p | base64 -D
	flag{ST1LL_US1N6_ST47IC_P455WORDS}

## Flag

	flag{ST1LL_US1N6_ST47IC_P455WORDS}
