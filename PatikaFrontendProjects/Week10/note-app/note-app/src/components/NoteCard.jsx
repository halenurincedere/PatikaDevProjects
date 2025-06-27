import React from 'react';

function NoteCard({ note, deleteNote }) {
  return (
    <div
      className="note-card"
      style={{ backgroundColor: note.color }}
    >
      <button
        className="delete-btn"
        onClick={() => deleteNote(note.id)}
        title="Delete"
      >
        &times;
      </button>
      <p>{note.text}</p>
    </div>
  );
}

export default NoteCard;