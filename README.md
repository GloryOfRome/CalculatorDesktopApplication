# CalculatorDesktopApplication

Create a Calculator Desktop Application that behaves similarly to the Calculator app you can find in any Windows operating system (OS). It requires the following features:

It can perform Addition, Subtraction, Division, and Multiplication
It should use a single display panel which behaves as a display similar to that of a handheld calculator:
Numbers and operations are entered via the user's keyboard, or via buttons on the form. Only numbers, decimals, and operations can be entered: letters or other characters cannot.
When an Operation is entered, that Operation's symbol (+, -, /, *) appears in a separate display. The contents of the number display are cleared, and the number within becomes the Stored Operand. The selected Operation becomes the Stored Operation.
If the Equals (=) Sign, or the Enter Key, are pressed while there is a Stored Operation, a Stored Operand, and a number entered in the number display, the Stored Operation is performed on the Stored Operand and the number in the number display. The result is displayed in the number display. The result also becomes the Stored Operand. The Stored Operation is cleared.
If an Operation is selected while there is a Stored Operation and no number in the number display, the Stored Operation is changed to the new one selected.
If an Operation is selected while there is a Stored Operation and a number in the display window, the same occurs as when the Enter Key or Equals Sign are pressed, but the Stored Operation is changed to the newly selected Operation rather than being cleared.
The calculator should have another pair of buttons, "BIN" and "DEC."
The BIN button will convert a positive integer in the number display to a binary number, and display it in the number display.
The DEC button will convert a binary number in the number display to a decimal number and display it in the number display.
If either of these operations are given an invalid input, the message "ERROR" will be displayed in the number display. Any further input will clear the display.
Another new button, "LOC," will convert a decimal number to a Locational Numeral (https://en.wikipedia.org/wiki/Location_arithmetic#:~:text=To%20represent%20a%20given%20number,24%20%2B%2026%20%3D%20abceg)
Bonus: the display window for the Calculator can be switch between Decimal, Binary, and Locational tabs that perform these conversions when the tabs are switched.
