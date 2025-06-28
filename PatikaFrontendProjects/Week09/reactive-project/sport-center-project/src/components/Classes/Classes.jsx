import React, { useState } from "react";
import ClassTabs from "./ClassTabs";
import ClassCard from "./ClassCard";

const classData = {
  Yoga: {
    title: "Yoga Seansları",
    description: "Yoga esneklik, denge ve nefesi geliştirmek için mükemmel bir yöntemdir.",
    image: "/images/yoga.jpg",
    schedule: "Pazartesi-Pazar: 10:00 - 18:00",
  },
  Group: {
    title: "Grup Antrenmanları",
    description: "Motivasyonu artıran grup seansları ile dayanıklılığı artırın.",
    image: "/images/group.webp",
    schedule: "Hafta içi: 17:00 - 19:00",
  },
  Solo: {
    title: "Birebir Antrenörlük",
    description: "Kişiye özel planlama ile hızlı ve etkili sonuçlar.",
    image: "/images/solo.jpg",
    schedule: "Randevu ile",
  },
  Stretching: {
    title: "Esneme & Dinlenme",
    description: "Mobiliteyi artırın, sakatlanmaları önleyin.",
    image: "/images/stret.webp",
    schedule: "Her gün: 08:00 - 09:00",
  },
};

const Classes = () => {
  const [activeTab, setActiveTab] = useState("Yoga");

  const sectionStyle = {
    padding: "4rem 1rem",
    backgroundColor: "#f9fbfd",
    textAlign: "center",
  };

  const titleStyle = {
    fontSize: "2rem",
    marginBottom: "1rem",
    color: "#355592",
  };

  const subtitleStyle = {
    fontSize: "1rem",
    color: "#555",
    marginBottom: "2rem",
  };

  return (
    <section id="classes" style={sectionStyle}>
      <h2 style={titleStyle}>Sınıflarımız</h2>
      <p style={subtitleStyle}>İhtiyacınıza uygun antrenman türünü seçin.</p>
      <ClassTabs activeTab={activeTab} setActiveTab={setActiveTab} />
      <ClassCard {...classData[activeTab]} />
    </section>
  );
};

export default Classes;