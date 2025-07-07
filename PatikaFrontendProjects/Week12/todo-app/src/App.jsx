import { useState, useEffect } from 'react';

function App() {
  const [todos, setTodos] = useState(() => {
    const stored = localStorage.getItem('todos');
    return stored ? JSON.parse(stored) : [];
  });

  const [newTodo, setNewTodo] = useState('');
  const [filter, setFilter] = useState('all');

  useEffect(() => {
    localStorage.setItem('todos', JSON.stringify(todos));
  }, [todos]);

  const handleKeyDown = (e) => {
    if (e.key === 'Enter' && newTodo.trim() !== '') {
      setTodos([
        ...todos,
        { id: Date.now(), text: newTodo.trim(), completed: false }
      ]);
      setNewTodo('');
    }
  };

  const toggleTodo = (id) => {
    setTodos(
      todos.map(todo =>
        todo.id === id ? { ...todo, completed: !todo.completed } : todo
      )
    );
  };

  const clearCompleted = () => {
    setTodos(todos.filter(todo => !todo.completed));
  };

  const filteredTodos = todos.filter(todo => {
    if (filter === 'active') return !todo.completed;
    if (filter === 'completed') return todo.completed;
    return true;
  });

  const remaining = todos.filter(todo => !todo.completed).length;

  return (
    <section className="todoapp">
      <header className="header">
        <h1>todos</h1>
        <input
          className="new-todo"
          placeholder="What needs to be done?"
          autoFocus
          value={newTodo}
          onChange={(e) => setNewTodo(e.target.value)}
          onKeyDown={handleKeyDown}
        />
      </header>

      {todos.length > 0 && (
        <>
          <section className="main">
            <ul className="todo-list">
              {filteredTodos.map((todo) => (
                <li key={todo.id} className={todo.completed ? 'completed' : ''}>
                  <div className="view">
                    <input
                      className="toggle"
                      type="checkbox"
                      checked={todo.completed}
                      onChange={() => toggleTodo(todo.id)}
                    />
                    <label>{todo.text}</label>
                  </div>
                </li>
              ))}
            </ul>
          </section>

          <footer className="footer">
            <span className="todo-count">
              <strong>{remaining}</strong> item{remaining !== 1 ? 's' : ''} left
            </span>

            <ul className="filters">
              <li>
                <a
                  href="#/"
                  className={filter === 'all' ? 'selected' : ''}
                  onClick={() => setFilter('all')}
                >
                  All
                </a>
              </li>
              <li>
                <a
                  href="#/active"
                  className={filter === 'active' ? 'selected' : ''}
                  onClick={() => setFilter('active')}
                >
                  Active
                </a>
              </li>
              <li>
                <a
                  href="#/completed"
                  className={filter === 'completed' ? 'selected' : ''}
                  onClick={() => setFilter('completed')}
                >
                  Completed
                </a>
              </li>
            </ul>

            <button className="clear-completed" onClick={clearCompleted}>
              Clear completed
            </button>
          </footer>
        </>
      )}
    </section>
  );
}

export default App;