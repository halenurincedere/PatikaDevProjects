import React, { useState } from 'react';

const colors = ['#f06292', '#ba68c8', '#ffd54f', '#4fc3f7', '#aed581'];

function NoteInput({ addNote }) {
  const [text, setText] = useState('');
  const [selectedColor, setSelectedColor] = useState(colors[0]);

  const handleAdd = () => {
    if (text.trim() === '') return;
    addNote(text, selectedColor);
    setText('');
  };

  return (
    <div className="note-input">
      <textarea
        placeholder="Enter your note here..."
        value={text}
        onChange={(e) => setText(e.target.value)}
      ></textarea>

      <div className="color-picker">
        {colors.map((color) => (
          <span
            key={color}
            className={`color ${selectedColor === color ? 'active' : ''}`}
            style={{ backgroundColor: color }}
            onClick={() => setSelectedColor(color)}
          />
        ))}
      </div>

      <button onClick={handleAdd}>ADD</button>
    </div>
  );
}

export default NoteInput;