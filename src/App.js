import React, { useState, useEffect } from 'react'
import axios from 'axios'
import MovieGrid from './Components/movieList/MovieGrid'
import Search from './Components/ui/Search'
import './App.css'

const App = () => {
  const [items, setItems] = useState([])
  const [isLoading, setIsLoading] = useState(true)
  const [title, setTitle] = useState('Thor')
  const [notFound, setNotFound] = useState(false)

  useEffect(() => {
    const fetchItems = async () => {
      setIsLoading(true)
      await axios.get(
        `https://localhost:44366/api/Movie/${title}`
      ).then(response => {
        setItems(response.data)
        setIsLoading(false)
     })
     .catch(error => {
        console.log(error.response.data)
        if(error.response.data === 'check your API'){
          setNotFound(true)
          setIsLoading(false)
        }
     })
    }

    fetchItems()
  }, [title])
  
  const queryFunction = (q) =>{
    setTitle(q)
    setNotFound(false)
  }
  
  return (
    <div className='container'>

      <Search getQuery={queryFunction} />
      <MovieGrid isLoading={isLoading} notFound={notFound} items={items} />
    </div>
  )
}

export default App