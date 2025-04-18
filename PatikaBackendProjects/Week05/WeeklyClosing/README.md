# Weekly Closing 

This program simulates a car manufacturing process. The user can produce cars, input their details, and store them in a list. The program includes validations, such as checking if the user inputs a valid number for the door count and handling invalid responses for the main prompt.

## 📋 Project Requirements
1) Car Class:
- Properties:
    - Production Date (automatically set when a car is created)
    - Serial Number
    - Brand
    - Model
    - Color
    - Door Count
2) User Interaction:
    - The user is asked if they want to produce a car. They can respond with 'e' (yes) or 'h' (no).
    - If the response is 'e', the user is prompted to enter details about the car (serial number, brand, model, color, and door count).
    - If the response is 'h', the program will end.
3) Validations:
    - If the user provides an invalid input for the door count (a non-numeric value), an exception is caught, and the user is asked to re-enter the door count.
    - The program also checks for valid responses to the main question about whether the user wants to produce a car or not. If an invalid response is provided, the program will ask again.
4) Storing Cars:
- Each car created is stored in a list of cars.
5) Final Output:
After the user decides not to produce any more cars, the program will display the serial numbers and brands of all the cars in the list.

## 🔄 How the Project Works

Console Output

```bash
Do you want to produce a car? (e/h):
e
Enter serial number:
1234AB
Enter brand:
Ferrari
Enter model:
LaFerrari
Enter color:
Red
Enter door count:
2
Enter the price of the car:
500000
Do you want to produce another car? (e/h):
h

Most Expensive Car:
Serial Number: 1234AB
Brand: Ferrari
Model: LaFerrari
Color: Red
Door Count: 2
Price: $500,000.00
```