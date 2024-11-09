import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import './NavbarStyles.css';


function Navbar() {

    const [pages, setPages] = useState('');

    return (
        <div className='navbar'>
            <Link to='/' className='iconHome'>Home</Link>
            <div onClick={() => {
                setPages(!pages)
            }}></div>
            <Link to='/' className='page'>Home</Link>
            <Link to='/createPool' className='page'>Create Pool</Link>
            <Link to='/votePool' className='page'>Vote in Pool</Link>
        </div>
    );
}

export default Navbar