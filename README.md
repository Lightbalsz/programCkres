# This repository contains solutions for two programming problems:
1. Sort Character 
2. PSBB (Pembatasan Sosial Berskala Besar)
   
## 1. Sort Character (NDL010)
Problem Description
The task is to sort characters from a given string based on certain rules. The string contains both vowels and consonants. We are required to sort the vowels and consonants separately while maintaining their order of appearance.

Input
Input one line of words (S) : Sample Case
Example: "hello world"
Output
Vowel Characters :
aaee
Consonant Characters :
ssmplc

## 2. PSBB (Pembatasan Sosial Berskala Besar)
Problem Description
During the COVID-19 pandemic, the government enforced the PSBB (Large-Scale Social Restrictions) program, limiting the number of people allowed in one vehicle. Given the number of families and the number of members in each family, the task is to calculate the minimum number of buses required to transport all family members, where each bus can hold at most 4 passengers. A bus cannot carry members from more than two families.

Input
Input the number of families : 5
Input the number of members in the family
(separated by a space) : 1 2 4 3 3
Output
Minimum bus required is : 4

Explanation:
One bus can carry members from two families (if their combined size is ≤ 4).
We calculate the minimum number of buses required to transport all members according to these rules.

## How to Run
Clone this repository to your local machine.
Navigate to the folder containing the program.
Execute the program with "dotnet run" .
