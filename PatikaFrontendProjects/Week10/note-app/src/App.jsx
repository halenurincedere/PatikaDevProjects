import React, { useState, useEffect } from 'react';
import SearchBar from './components/SearchBar';
import NoteInput from './components/NoteInput';
import NoteList from './components/NoteList';
import './App.css';

function App() {
  const [search, setSearch] = useState('');

  const [notes, setNotes] = useState(() => {
    const saved = localStorage.getItem('notes');
    return saved ? JSON.parse(saved) : [];
  });

  useEffect(() => {
    localStorage.setItem('notes', JSON.stringify(notes));
  }, [notes]);

  const addNote = (text, color) => {
    const newNote = {
      id: Date.now(),
      text,
      color,
    };
    setNotes([newNote, ...notes]);
  };

  const deleteNote = (id) => {
    setNotes(notes.filter((note) => note.id !== id));
  };

  return (
    <div>
      <h1>NotesApp</h1>
      <SearchBar search={search} setSearch={setSearch} />
      <NoteInput addNote={addNote} />
      <NoteList notes={notes} search={search} deleteNote={deleteNote} />
    </div>
  );
}

export default App;