const greetingEl = document.getElementById("greeting");
const clockEl = document.getElementById("clock");
const dayEl = document.getElementById("day");

const days = ["Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi"];

let user = localStorage.getItem("userName");

if (!user) {
  user = prompt("Adınız nedir?");
  localStorage.setItem("userName", user);
}

greetingEl.textContent = `Merhaba, ${user}!`;

function updateTime() {
  const now = new Date();
  const time = now.toLocaleTimeString("tr-TR");
  const day = days[now.getDay()];
  clockEl.textContent = time;
  dayEl.textContent = day;
}

setInterval(updateTime, 1000);
updateTime();