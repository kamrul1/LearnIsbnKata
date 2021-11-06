# Learn ISBN Kata

This is my attempt at the [ISBN Kata](https://github.com/ardalis/kata-catalog/blob/main/katas/ISBN.md) using C#.

## Initial thoughts on, how to tackle?

- check for length
  - using string as input
  - can start with zero and contact spaces, and hypens
- ignore spaces and hypen
- do a checksum
  - convert to int number array
  - multiply each alternative number by 1 and 3
  - sum values of multipliacation
  - module 10 of sum
  - substract 10 from module reminder

# Basic Task - ISBN-13

>Create a function that takes a string and returns true if the string is a valid ISBN-13 and false otherwise

Done into first version, including seperation of concerns into helpers:

|Helper                 |Purpose                        |
|---                    |---                            |
|ConvertToIntArray      |Convert to int array           |
|DigitValidator         |Checks numbers/X char          |
|ISBNCheckSum           |Validate CheckSum number       |
|RemoveSpaceAndHypen    |Spaces and hypen remover       |
|SumPositionForISBN13   |Calculation by 13 position     |




## Advanced Task - ISBN-10

> Update the original function to also return true if the string is a valid ISBN-10.

introduced ```SumPositionForISBN10.cs``` to detail with ISBN-10 position calculations

