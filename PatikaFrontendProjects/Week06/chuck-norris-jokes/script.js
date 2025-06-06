const jokeEl = document.getElementById("joke");
const button = document.getElementById("new-joke");

function getJoke() {
  jokeEl.textContent = "Şaka yükleniyor...";
  fetch("https://api.chucknorris.io/jokes/random")
    .then((res) => {
      if (!res.ok) {
        throw new Error("Sunucudan cevap alınamadı.");
      }
      return res.json();
    })
    .then((data) => {
      jokeEl.textContent = data.value;
    })
    .catch((err) => {
      jokeEl.textContent = "Bir hata oluştu. Lütfen tekrar deneyin.";
      console.error("API Hatası:", err);
    });
}

document.addEventListener("DOMContentLoaded", getJoke);
button.addEventListener("click", getJoke);