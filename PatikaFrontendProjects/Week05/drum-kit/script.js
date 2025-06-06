const sounds = {
    A: "Sound/clap.wav",
    S: "Sound/hihat.wav",
    D: "Sound/kick.wav",
    F: "Sound/openhat.wav",
    G: "Sound/boom.wav",
    H: "Sound/ride.wav",
    J: "Sound/snare.wav",
    K: "Sound/tom.wav",
    L: "Sound/tink.wav",
  };
  
  function playSound(key) {
    const soundFile = sounds[key.toUpperCase()];
    if (!soundFile) return;
  
    const audio = new Audio(soundFile);
    audio.currentTime = 0;
    audio.play();
  
    const button = document.querySelector(`.drum-key[data-key="${key.toUpperCase()}"]`);
    if (button) {
      button.classList.add("playing");
      setTimeout(() => button.classList.remove("playing"), 150);
    }
  }
  
  document.querySelectorAll(".drum-key").forEach(btn =>
    btn.addEventListener("click", () => playSound(btn.dataset.key))
  );
  
  document.addEventListener("keydown", e => playSound(e.key));