# Encapsulation 🫙
This project demonstrates an application that introduces car features while implementing the principle of encapsulation to ensure data privacy and control.

## 📋 Project Requirements

1) Car Features
- Brand
- Model
- Color
- Number of Doors

2) Door Count Encapsulation
- The number of doors can only be 2 or 4.
- If a value other than 2 or 4 is assigned:
- A warning message will be displayed in the console.
- The number of doors will be set to -1.

## 🔄 How the Project Works

1) A car object is created from the Car class.

2) A value is assigned to the Number of Doors property.

3) The assigned value is validated:

-  If the value is valid (2 or 4), it is set as the Number of Doors.

- If the value is invalid, the Number of Doors is set to -1, and a warning message is displayed in the console.

4) The car's features are printed to the console.