import React from "react";

const ClassTabs = ({ activeTab, setActiveTab }) => {
  const tabs = ["Yoga", "Group", "Solo", "Stretching"];

  const tabStyle = (tab) => ({
    padding: "0.6rem 1.2rem",
    margin: "0.3rem",
    border: "none",
    borderRadius: "20px",
    cursor: "pointer",
    backgroundColor: activeTab === tab ? "#355592" : "#e0e0e0",
    color: activeTab === tab ? "#fff" : "#333",
    fontWeight: "bold",
  });

  return (
    <div style={{ marginBottom: "2rem" }}>
      {tabs.map((tab) => (
        <button key={tab} onClick={() => setActiveTab(tab)} style={tabStyle(tab)}>
          {tab}
        </button>
      ))}
    </div>
  );
};

export default ClassTabs;