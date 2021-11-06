# Learn ISBN Kata

This is my attempt at the [ISBN Kata](https://github.com/ardalis/kata-catalog/blob/main/katas/ISBN.md) using C#.

## Initial Thoughts

>Create a function that takes a string and returns true if the string is a valid ISBN-13 and false otherwise

- check for length
  - using string as input
  - can start with zero and contact spaces, and hypens
- ignore spaces and hypen
- do a checksum
  - convert to int number array
  - multiply each alternative number by 1 and 3
  - sum values of multipliacation
  - module 10 of sum
  - substract 10 from result

