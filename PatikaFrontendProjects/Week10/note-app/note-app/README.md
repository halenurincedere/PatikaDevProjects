# 🗒️ NotesApp — React Note-Taking App

A simple yet interactive note-taking application built with React.  
Users can create, color-code, and search through notes in real-time.

## 🚀 Features

- 📝 Add notes via a `textarea` input
- 🎨 Select a color before saving — each note is saved in that color
- 🔍 Filter/search through notes using the search input
- 🎯 Live updates as you type
- 💾 Notes are displayed instantly on the screen
- ✅ Clean, minimal, and responsive UI

## 🛠️ Tech Stack

- React (via Vite)
- Functional components & hooks (`useState`)
- CSS (custom styling)

## 🧪 Functional Requirements

- Notes are stored in component state (not persisted after refresh)
- Selected color is visually indicated before adding a note
- Only one color can be selected per note
- Notes are filtered live by the search input (case-insensitive)
- Notes are displayed with the most recently added first

## 📦 File Structure (Suggested)

````bash
plaintext
src/
├── components/
│   ├── NoteCard.jsx
│   ├── NoteInput.jsx
│   └── SearchBar.jsx
├── App.jsx
└── App.css
`````



