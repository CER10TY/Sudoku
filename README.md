# SUDOKU
Written in VB2013

### OVERVIEW
This program provides a basic user interface to play Sudoku. It is able to load predefined (explained further down below) Sudoku puzzles, as well as giving feedback and hints to the user.
The program is also able to solve very basic Sudoku puzzles using the CRME (Column, Row, Minigrid Elimination) technique. 
Future revisions will include the ability to generate Sudoku puzzles, as well as more techniques to solve more complex Sudoku puzzles.

### PRE-DEFINED SUDOKU PUZZLES
This program can read any text file, however the distinctive suffix used in this case is .sdo (which is still a text file). 
The text file that the program should load has some properties you should be aware of:
* It has to include a *minimum* of 81 numbers.
* A 0 equals an empty field.
* It has to be a single string, it cannot be formatted in any way.

The included easy.sdo looks as follows:
005400180146080500070013000451008706080000010603700948000390070004070269019006400

Be aware that including an incomplete file (one with less than 81 numbers) will still insert the numbers, however it will also cast an error due to there not being 81 numbers.
Due to this, when creating a sudoku file, make sure to include 0's to fill out the board and to prevent any unwanted side effects.

### DISCLAIMER
This program is a part of the book "Programming Sudoku (Technology In Action)" by Wei-Meng Lee. 
If you're planning on reading it, you should familiarise yourself with Visual Basic at least a bit before you do. This book goes in head first and often spends little time explaining the code, besides small comments.
Instead, the book focuses on the mathematical and general approach to building, solving and also generating Sudoku puzzles. 
You can buy the book on Amazon [here](http://www.amazon.com/Programming-Sudoku-Technology-Action-Wei-Meng/dp/1590596625/ref=sr_1_1?ie=UTF8&qid=1441307780&sr=8-1&keywords=programming+sudoku)

