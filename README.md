# PSBB Bus Calculation App

This C# application calculates the minimum number of buses required to transport families to a wedding during the COVID-19 period, following the **PSBB** (Pembatasan Sosial Berskala Besar) guidelines. Each bus can carry up to 4 passengers, and each family must ride in the same bus. The program computes the minimum number of buses needed based on the total number of family members.

## Features
- Input the number of families and the number of members in each family.
- Ensures that each family rides in a separate bus, and that no bus carries more than one family.
- Calculates the minimum number of buses required based on the total number of family members divided by 4.
- Provides proper validation of inputs:
  - Ensures the number of family members matches the number of families.
  - Handles invalid inputs and empty spaces.

## Requirements
- .NET 6 or higher (for running C# code)

## Usage

Clone the repository:
   ```bash
   git clone https://github.com/yourusername/psbb-bus-calculator.git
   cd psbb-bus-calculator
Build and run the program.

The program will prompt you to input the number of families and the number of members in each family. Example:

Input the number of families: 5
Input the number of members in the family (separated by a space): 1 2 4 3 3
The program will output the minimum number of buses required.
Example output:
Minimum bus required is: 4
Example Input & Output
Example 1:
Input:
Input the number of families: 5
Input the number of members in the family (separated by a space): 1 2 4 3 3
Output:
Minimum bus required is: 4
Example 2:
Input:
Input the number of families: 8
Input the number of members in the family (separated by a space): 2 3 4 4 2 1 3 1
Output:
Minimum bus required is: 5
Example 3 (Invalid Input for Number of Families):
Input:
Input the number of families: 5
Input the number of members in the family (separated by a space): 1 5
Output:
Input must be equal with count of family
Example 4 (Invalid Member Size):
Input:
Input the number of families: 3
Input the number of members in the family (separated by a space): 2 5 3
Output:
Each family cannot have more than 4 members.


## Acknowledgements

This program was developed for the PSBB (Pembatasan Sosial Berskala Besar) scenario, where transportation is limited to 4 passengers per bus.
