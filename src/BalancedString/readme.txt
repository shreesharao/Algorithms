Asked By -
	Nextgen

Algo-
        //1) Use a stack
        //2) read string from left
        //3) push to stack if current read letter is open brace('(','{','[')
        //4) pop from stack if current read letter is close brace.
        //5) Check the popped brace with the current read brace
        //5.a) if it is pairing brace.ok continue
        //5.b) if stack was empty, then print NO
        //5.c) if popped char and read char is not a pair then print NO
        //6) when all the string are processed.check the length of the stack.
        //6.a) if length is 0 print YES
        //6.b) else print NO