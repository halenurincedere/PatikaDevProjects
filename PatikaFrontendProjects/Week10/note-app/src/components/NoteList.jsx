import React from 'react';
import NoteCard from './NoteCard';

function NoteList({ notes, search, deleteNote }) {
  const filtered = notes.filter((note) =>
    note.text.toLowerCase().includes(search.toLowerCase())
  );

  return (
    <div className="note-list">
      {filtered.length === 0 ? (
        <p>No notes found.</p>
      ) : (
        filtered.map((note) => (
          <NoteCard key={note.id} note={note} deleteNote={deleteNote} />
        ))
      )}
    </div>
  );
}

export default NoteList;