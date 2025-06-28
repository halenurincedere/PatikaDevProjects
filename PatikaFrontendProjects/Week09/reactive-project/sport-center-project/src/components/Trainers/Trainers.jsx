import TrainerCard from "./TrainerCard";
import Title from "../Statistics/Title";

const Trainers = () => {
  const trainers = [
    {
      name: "Zeynep Kaya",
      specialty: "Yoga Eğitmeni",
      image: "trainer1.jpg",
    },
    {
      name: "Mert Demir",
      specialty: "Fitness Koçu",
      image: "trainer2.jpg",
    },
    {
      name: "Ayşe Arslan",
      specialty: "Cardio Uzmanı",
      image: "trainer3.jpg",
    },
  ];

  return (
    <section style={styles.section}>
      <Title text="Meet Our Trainers" />
      <div style={styles.grid}>
        {trainers.map((trainer, index) => (
          <TrainerCard
            key={index}
            name={trainer.name}
            specialty={trainer.specialty}
            image={trainer.image}
          />
        ))}
      </div>
    </section>
  );
};

const styles = {
  section: {
    padding: "2rem",
    backgroundColor: "#f9f9f9",
  },
  grid: {
    display: "flex",
    justifyContent: "center",
    gap: "2rem",
    flexWrap: "wrap",
    marginTop: "1rem",
  },
};

export default Trainers;