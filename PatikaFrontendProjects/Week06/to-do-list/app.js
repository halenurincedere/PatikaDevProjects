document.addEventListener("DOMContentLoaded", () => {
  const taskInput = document.getElementById("taskInput");
  const taskList = document.getElementById("taskList");
  const addBtn = document.getElementById("addBtn");
  const successToast = new bootstrap.Toast(document.getElementById("successToast"));
  const errorToast = new bootstrap.Toast(document.getElementById("errorToast"));

  const defaultTasks = [
    "3 Litre Su İç",
    "Ödevleri Yap",
    "En Az 3 Saat Kodlama Yap",
    "Yemek Yap",
    "50 Sayfa Kitap Oku"
  ];

  // İlk yüklemede görevleri getir
  let tasks = JSON.parse(localStorage.getItem("tasks"));
  if (!tasks || tasks.length === 0) {
    tasks = defaultTasks.map(text => ({ text, completed: false }));
    localStorage.setItem("tasks", JSON.stringify(tasks));
  }
  tasks.forEach(task => createTaskElement(task.text, task.completed));

  // Görev ekleme
  addBtn.addEventListener("click", () => {
    const text = taskInput.value.trim();
    if (text === "") {
      errorToast.show();
      return;
    }
    createTaskElement(text);
    saveTask(text);
    taskInput.value = "";
    successToast.show();
  });

  function createTaskElement(text, completed = false) {
    const li = document.createElement("li");
    li.textContent = text;
    if (completed) li.classList.add("checked");

    li.addEventListener("click", () => {
      li.classList.toggle("checked");
      updateStorage();
    });

    const span = document.createElement("span");
    span.className = "close";
    span.textContent = "×";
    span.addEventListener("click", (e) => {
      e.stopPropagation();
      li.remove();
      updateStorage();
    });

    li.appendChild(span);
    taskList.appendChild(li);
  }

  function saveTask(text) {
    const tasks = JSON.parse(localStorage.getItem("tasks")) || [];
    tasks.push({ text, completed: false });
    localStorage.setItem("tasks", JSON.stringify(tasks));
  }

  function updateStorage() {
    const items = document.querySelectorAll("#taskList li");
    const tasks = [];
    items.forEach(li => {
      const text = li.firstChild.textContent.trim();
      const completed = li.classList.contains("checked");
      tasks.push({ text, completed });
    });
    localStorage.setItem("tasks", JSON.stringify(tasks));
  }
});