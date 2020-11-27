C# Part One
-------------------------------------------------------------------------------------------------------------------------------------------
C# Variables and Syntax
-------------------------------------------------------------------------------------------------------------------------------------------
WriteLine or Write

The most common method to output something in C# is WriteLine(), but you can also use Write().

The difference is that WriteLine() prints the output on a new line each time, while Write() prints on the same line (note that you should remember to add spaces when needed, for better readability): (Please example in the Programs file )
=============================================================================================================================================
Variables are containers for storing data values.

In C#, there are different types of variables (defined with different keywords), for example:

int - stores integers (whole numbers), without decimals, such as 123 or -123
char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
string - stores text, such as "Hello World". String values are surrounded by double quotes
bool - stores values with two states: true or false

to declare a variable please follow the proper guide:

type variableName = value;

--------------------------------------------------------------------------------------------------------------------------------------------
Float VS Double VS Decimal
--------------------------------------------------------------------------------------------------------------------------------------------
Float - 32 bit (7 digits) Double - 64 bit (15-16 digits) Decimal - 128 bit (28-29 significant digits)

Difference between Decimal, Float and Double

The main difference is Floats and Doubles are binary floating point types and a Decimal will store the value as a floating decimal point type. So Decimals have much higher precision and are usually used within monetary (financial) applications that require a high degree of accuracy. But in performance wise Decimals are slower than double and float types.

Decimal can 100% accurately represent any number within the precision of the decimal format, whereas Float and Double, cannot accurately represent all numbers, even numbers that are within their respective formats precision.

When To Use Decimal, Double, and Float

In case of financial applications it is better to use Decimal types because it gives you a high level of accuracy and easy to avoid rounding errors Double

Double Types are probably the most normally used data type for real values, except handling money. Float

It is used mostly in graphic libraries because very high demands for processing powers, also used situations that can endure rounding errors

--------------------------------------------------------------------------------------------------------------------------------------------
C# Identifiers
--------------------------------------------------------------------------------------------------------------------------------------------

All C# variables must be identified with unique names.

These unique names are called identifiers.

Identifiers can be short names (like x and y) or more descriptive names (age, sum, totalVolume).