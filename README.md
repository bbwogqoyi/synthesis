1. Create a function abelar to return true if the input is greater than 12, and less than 3097, and is a multiple of 12. [target: 1 line]
2. Create a function area which, given a base and height, finds the area of a triangle. If either the base or the height is negative, throw an exception. [target: 3 lines]
3. Create a function zollo which returns a positive number if given a negative number, or doubles the number if the input is positive. [target: 3 lines]
4. Create a function min which chooses the smaller of two values. [target: 3 lines]
5. Create a function max which chooses the larger of two values. [target: 3 lines]
6. Create a function ofTime to convert hours, minutes, and seconds to a number of seconds. [target: 1 line]
7. Create a function toTime to convert a number of seconds to hours, minutes, and seconds. [target: 7 lines]
8. Create a function digits to count the number of digits in a number. The input may be positive or negative. [target: 5 lines]
9. Create a function minmax which finds the largest and smallest values out of four values that are provided. [target: 3 lines]
10. Create a function isLeap which returns true if the given year is a leap year. Every year that is divisible by 4 is a leap year, unless it is also divisible by 100. However, if it is also divisible by 400, then it is still a leap year. The function should throw an exception of the input year is less than 1582. [target: 5 lines]
11. Create a function month which accepts an integer between 1 and 12 inclusive, and returns the corresponding month and the number of days in that month, assuming that it is not a leap year. If an integer less than 1 or greater than 12 is supplied, an exception should be thrown. [target: 13 lines]
12. Create a function toBinary which converts a positive integer to a binary string. Throw an exception if a negative integer is supplied. [target: 11 lines]
13. Create a function bizFuzz to accept an integer n and return the number of times a number between 1 and n inclusive is divisible by 3, divisible by 5, and divisible by both 3 and 5. [target: 10 lines]
14. Create a function monthDay which accepts an integer d and a year y, and returns a string for the month that the day d falls within. The function must accept a range of d from 1 to 365 if y isn’t a leap year, and must accept d between 1 and 366 if y is a leap year. If d is out of range, or if y is less than 1582, then an exception must be thrown. Remember that:
     - April, June, September, and November have 30 days.
    - January, March, May, July, August, October, and December have 31 days.
    - February has 29 days in a leap year, and 28 days otherwise.

    [target: 17 lines]
15. Create a function coord which is given a Cartesian coordinate and returns functions to calculate: 
    - the straight-line distance to another Cartesian coordinate, as calculated by
        ```dist = sqrt ( (x1 − x2)**2 + (y1 − y2)**2 )```

    Hint: you developed a square-root function in a tutorial on page 35 of your textbook. 
    - whether a rectangle (described by top-left coordinate, width, and height, in that order) will contain the initial coordinate.

    [target: 6 lines, excluding sqrt function]