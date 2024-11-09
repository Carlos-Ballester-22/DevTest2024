import Pool from '../components/Home/Poll';
import React , { useState, useEffect } from 'react';

export default function Home() {
    const url = 'http://localhost:5000/api/Pool';
    const [polls, setPolls] = useState([]);

    const fetchInfo = () => {
        fetch(url, {
            method: "GET",
            headers: {
                'Contant-Type': 'application/json'
            }
        })
        .then(response => {
            if (!response.ok) {
                throw new Error('Failet fetch');
            }
            return response.json();
        })
        .then(data => {
            setPolls(data);
        })
        .catch(error => {
            console.error('Error fetching', error);
        });
    };

    useEffect(() => {
        fetchInfo();
    }, [])

    return (
        <div>
            <div>
                <h1> Online Polls</h1>
                <div>
                    <h2>Pools List</h2>
                    <div>
                        {polls.map((poll) => (
                            <div key={poll.id}>
                                <Pool 
                                    name={poll.name}
                                    options={poll.options}
                                />
                            </div>
                        ))}
                    </div>
                </div>
            </div>
        </div>
    );

}