import Header from "./components/Header/Header";
import Navbar from "./components/Header/Navbar";
import React from "react";
import Statistics from "./components/Statistics/Statistics";
import Classes from "./components/Classes/Classes";
import BmiCalculator from "./components/BmiCalculator/BmiCalculator";
import Trainers from "./components/Trainers/Trainers";
import Products from "./components/Products/Products";
import Testimonials from "./components/Testimonials/Testimonials";
import Contact from "./components/Contact/Contact";
import Footer from "./components/Footer/Footer";
import "./App.css";

function App() {
  return (
    <>
      <Header />
      <Navbar />
      <Statistics />
      <Classes />
      <BmiCalculator />
      <Trainers />
      <Products />
      <Testimonials />
      <Contact />
      <Footer />
    </>
  );
}

export default App;