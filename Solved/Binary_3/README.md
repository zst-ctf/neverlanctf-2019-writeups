# Binary 3
Binary

## Challenge 

Another day, another disgruntled engineer. It seems that the login is working fine, but some portions of the application are broken. Do you think you could fix the the code and retrieve the flag?

[get_flag](get_flag)

## Solution

#### Static code analysis

    $ file get_flag 
    get_flag: ELF 64-bit LSB shared object, x86-64, version 1 (SYSV), dynamically linked, interpreter /lib64/ld-linux-x86-64.so.2, for GNU/Linux 3.2.0, BuildID[sha1]=9d6e0012cc1b18b155cb8f490eb1fbed910694e2, not stripped

Decompile the code using Hopper Decompiler

    void main(void) {
        c();
        if (u() == 0x0) {
            puts("username incorrect.");
        } else {
            if (b() == 0x0) {
                puts("password incorrect.");
            } else {
                puts("you are now logged in...");
            }
        }
    }

    int u() {
        printf("username: ");
        fgets(&var_100, 0x100, *__TMC_END__);
        strtok(&var_100, 0x260b);
        if (strcmp(*username, &var_100) == 0x0) {
                rax = 0x1;
        } else {
                rax = 0x0;
        }
        return rax;
    }

    int b() {
        printf("password: ");
        fgets(&var_100, 0x100, *__TMC_END__);
        strtok(&var_100, 0x260b);
        if (strcmp(password, &var_100) == 0x0) {
                rax = 0x1;
        } else {
                rax = 0x0;
        }
        return rax;
    }

From the above code, we know that `u()` and `b()` ask the input for the username/password and then checks against the memory buffer.

Hence, `c()` appears to be copying some password.

    int c() {
        strcpy(password, *p1);
        strcat(password, *p2);
        strcat(password, *p3);
        strcat(password, *p4);
        strcat(password, *p5);
        strcat(password, *p6);
        strcat(password, *p7);
        strcat(password, *p8);
        strcat(password, *p9);
        strcat(password, *p10);
        strcat(password, *p11);
        strcat(password, *p12);
        strcat(password, *p13);
        strcat(password, *p14);
        strcat(password, *p15);
        strcat(password, *p16);
        strcat(password, *p17);
        rax = *p18;
        rax = strcat(password, rax);
        return rax;
    }

#### Dynamic analysis

We can see what is the password using GDB

     # gdb ./get_flag 
    (gdb) run

    Starting program: /FILES/get_flag 
    username: ^C                         
    Program received signal SIGINT, Interrupt.
    0x00007ffff7ef41d1 in __GI___libc_read (fd=0, buf=0x555555758670, nbytes=1024) at ../sysdeps/unix/sysv/linux/read.c:27
    27  ../sysdeps/unix/sysv/linux/read.c: No such file or directory.

    (gdb) print /s (char *)&password
    $2 = 0x555555757180 <password> "a2VlcCBsb29raW5nLCBub3QgdGhlIGZsYWc="

    (gdb) print /s (char *)&username 
    $3 = 0x5555557570c8 <username> "\304eUUUU"

We see a base64 encoded text, but it is not the flag

    $ echo "a2VlcCBsb29raW5nLCBub3QgdGhlIGZsYWc=" | base64 -D
    keep looking, not the flag

---

#### Found hidden functions

Now if we continue looking into the program, we realise there are some weird functions:

    $ objdump -t get_flag | sort | grep 'main' -B12
    0000000000000d80 l     F .text  0000000000000000              __do_global_dtors_aux
    0000000000000dc0 l     F .text  0000000000000000              frame_dummy
    0000000000000dca g     F .text  0000000000000078              u
    0000000000000e42 g     F .text  0000000000000075              b
    0000000000000eb7 g     F .text  0000000000000193              c
    000000000000104a g     F .text  0000000000000365              f
    00000000000013af g     F .text  0000000000000365              l
    0000000000001714 g     F .text  0000000000000365              a
    0000000000001a79 g     F .text  0000000000000365              g
    0000000000001dde g     F .text  0000000000000365              s
    0000000000002143 g     F .text  0000000000000163              x
    00000000000022a6 g     F .text  0000000000000216              d
    00000000000024bc g     F .text  000000000000007f              main

The functions `u()`, `b()`, `c()` are already called.

And there are extra functions `f()`, `l()`, `a()`, `g()`, `s()`, `x()`, `d()`.

#### Call the hidden functions

Let's call them in order using GDB

    (gdb) run
    (gdb) call (char *) f()
    $22 = 0x555555757600 <uu1> "81c26d1dd57fd11842fc13e53540db80"
    (gdb) call (char *) l()
    $23 = 0x555555757620 <uu2> "eacbe4d1b2dee530eee7460477877c4d"
    (gdb) call (char *) a()
    $24 = 0x5555557575c0 <uu3> "667d5fa72f80788a5ed2373586e57ff6"
    (gdb) call (char *) g()
    $25 = 0x555555757640 <uu4> "c4ff45bb1fab99f9164b7fec14b2292a"
    (gdb) call (char *) s()
    $26 = 0x5555557575e0 <uu5> "6470e394cbf6dab6a91682cc8585059b"
    (gdb) call (char *) x()
    $27 = 0x5555557571c0 <url> "/81c26d1dd57fd11842fc13e53540db80/eacbe4d1b2dee530eee7460477877c4d/667d5fa72f80788a5ed2373586e57ff6/c4ff45bb1fab99f9164b7fec14b2292a/6470e394cbf6dab6a91682cc8585059b"
    (gdb) call (char *) d()
    GET /81c26d1dd57fd11842fc13e53540db80/eacbe4d1b2dee530eee7460477877c4d/667d5fa72f80788a5ed2373586e57ff6/c4ff45bb1fab99f9164b7fec14b2292a/6470e394cbf6dab6a91682cc8585059b HTTP/1.0

    HTTP/1.1 200 OK
    Date: Sun, 03 Feb 2019 06:21:31 GMT
    Server: Apache/2.4.29 (Ubuntu)
    Last-Modified: Sat, 02 Feb 2019 00:39:46 GMT
    ETag: "26-580de7f137f8d"
    Accept-Ranges: bytes
    Content-Length: 38
    Connection: close

    flag{AP1S_SH0ULD_4LWAYS_B3_PR0T3CTED}

Apparently, this constructs a URL which is then queried to get our flag

## Flag

    flag{AP1S_SH0ULD_4LWAYS_B3_PR0T3CTED}
