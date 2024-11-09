import React from 'react';
import {Routes , Route} from 'react-router-dom'
import Navbar from './components/Navbar';
import Home from './pages/Home';
import CreatePool from './pages/CreatePool';
import VotePool from './pages/VotePool';
import './App.css';

function App() {
  return (
    <div className="App">
      <Navbar />
      <Routes>
        <Route path='/' element={<Home />}/>
        <Route path='/createPool' element={<CreatePool />}/>
        <Route path='/votePool' element={<VotePool />}/>        
      </Routes>
    </div>
  );
}

export default App;
