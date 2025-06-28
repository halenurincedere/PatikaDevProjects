// src/components/Statistics/Statistics.jsx
import Title from "./Title";
import StatCard from "./StatCard";

const Statistics = () => {
  const stats = [
    { number: 325, label: "Course" },
    { number: 405, label: "Work Out" },
    { number: "305h", label: "Working Hour" },
    { number: 705, label: "Happy Client" },
  ];

  return (
    <section style={styles.container}>
      <Title text="Our Statistics" />
      <div style={styles.grid}>
        {stats.map((item, index) => (
          <StatCard key={index} number={item.number} label={item.label} />
        ))}
      </div>
    </section>
  );
};

const styles = {
  container: {
    padding: "2rem",
    backgroundColor: "#eef2f3",
  },
  grid: {
    display: "flex",
    justifyContent: "space-around",
    flexWrap: "wrap",
    gap: "1rem",
  },
};

export default Statistics;