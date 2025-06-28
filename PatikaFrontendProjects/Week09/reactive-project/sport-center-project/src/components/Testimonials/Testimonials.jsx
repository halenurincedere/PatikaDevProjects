import TestimonialCard from "./TestimonialCard";
import Title from "../Statistics/Title";

const Testimonials = () => {
  const testimonials = [
    {
      name: "Seda Yılmaz",
      message: "Bu spor merkezi sayesinde enerjim hiç bitmiyor!",
      image: "client2.jpg",
    },
    {
      name: "Ali Korkmaz",
      message: "Antrenörler harika, hizmet süper. Kesinlikle tavsiye ederim!",
      image: "client1.jpg",
    },
  ];

  return (
    <section style={styles.section}>
      <Title text="What Our Clients Say" />
      <div style={styles.grid}>
        {testimonials.map((item, i) => (
          <TestimonialCard
            key={i}
            name={item.name}
            message={item.message}
            image={item.image}
          />
        ))}
      </div>
    </section>
  );
};

const styles = {
  section: {
    padding: "2rem",
    backgroundColor: "#f7f7f7",
  },
  grid: {
    display: "flex",
    flexWrap: "wrap",
    justifyContent: "center",
  },
};

export default Testimonials;