# Old Keypad Phone Input to Text

This is a program to convert old keypad phone input to text messages.

## Input Mapping

Mapping for each number on keypad are as follows:
```csharp
{ '1', "!@#$%^&*()" },
{ '2', "ABC" },
{ '3', "DEF" },
{ '4', "GHI" },
{ '5', "JKL" },
{ '6', "MNO" },
{ '7', "PQRS" },
{ '8', "TUV" },
{ '9', "WXYZ" },
{ '0', " " }
```
### Special Inputs
'*' is for backspace.\
' '(whitespace) for a pause to type different letters from same number. (eg. 222 22# will return CB).\
'#' is to send a text message. Every input must end with #.

## Usage

The program will ask user to input keypad numbers (must end with #) then it will return text message output.\
If you type a number for more than the letters it has, it will return back from the first letter. (eg. If the input is 2222, it will return A because number 2 has only 3 letters.)

## Example Inputs and Outputs

input = "222#"\
output = "C"

input = "4433555 5556660966677755531#"\
output = "HELLO WORLD!"

## Detailed Code Explanation

It can be found in Old Keypad Phone Converter (Detailed Code Explanation).pdf in the repo.
