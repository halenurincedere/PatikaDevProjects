# 💸 Spend Bill Gates' Money — React Clone App

This project is a React-based clone of the popular interactive game:  
**[Spend Bill Gates' Money](https://neal.fun/spend)** — where users can hypothetically spend $100 billion on various imaginary items.

## 🎯 Objective

Simulate spending Bill Gates' $100,000,000,000 fortune by purchasing virtual products. The app dynamically updates the balance and displays purchased items.

## ✅ Features

- 💰 **Initial Balance**: $100,000,000,000
- 🛒 **Buy Products**: Deducts from balance
- 🔁 **Sell Products**: Adds back to balance
- 🚫 **"Buy" Button Disabled** if product price > current balance
- 🚫 **"Sell" Button Disabled** if quantity = 0
- 📦 **Live Cart Summary**: Lists purchased products with quantity and total value
- 🎨 Custom or demo-matching product list with prices and images

## 🧪 Rules & Logic

- Users can purchase as many products as their balance allows
- Selling restores funds to the total balance
- UI updates instantly to reflect changes in:
  - Balance
  - Button states (Buy/Sell)
  - Purchased product list

## 🛠️ Tech Stack

- React (Vite)
- JavaScript (ES6+)
- CSS Modules / Vanilla CSS
- Functional Components & React Hooks

## 🚀 Getting Started

```bash
npm install
npm run dev
`````
----

## 🪪 License

MIT — feel free to fork, use, or build on top of this project.