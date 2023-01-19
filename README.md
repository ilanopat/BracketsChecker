# BracketsChecker

C# console application that takes a string argument and returns whether or not characters in the string have matching brackets. Meaning for every { there is a corresponding } bracket. Returns Trus if they do, otherwise returns False.

This console application contains Unit testing for the following use cases:

* {}  - True
* }{  - False
* {{} - False
* ""  - True
* {abc...xyz} - True
