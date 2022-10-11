
import React, { useState,useEffect } from 'react'
const Search = ({ getQuery }) => {
    const [focused, setFocused] = useState(false)
    const onFocus = () => setFocused(true)
    const onBlur = () => setFocused(false)
    const [text, setText] = useState('')
    const [savedState, setSavedState] = useState([])

useEffect(() => {
 const data = JSON.parse(localStorage.getItem('savedState'));
 if (data){
    setSavedState(data)
 }
}, [])
useEffect(() => {
    if(text !==''){
        localStorage.setItem('savedState', JSON.stringify(savedState))
        setText('')
    }
    
   }, [savedState])


    const onChange = (q) => {
      setText(q)
     
    }
    const setQuery = (e) => {
        e.preventDefault()
        getQuery(text)    
        if (savedState.length > 4){
            savedState.shift(1)
            setSavedState([...savedState, text]);
            
        }
        else{
            setSavedState([...savedState, text]);
            
        }
        
        
        
        
    }
    
  
    return (
      <section style={{marginTop:'80px', marginBottom:'30px'}} className='search'>
        <form onSubmit={setQuery}>
          <input
           onFocus={onFocus} onBlur={onBlur}
            type='text'
            className='form-control'
            placeholder='Search Movie'
            value={text}
            onChange={(e) => onChange(e.target.value)}
            autoFocus
          />
          {focused || text==='' ? <><h2 style={{textAlign:'center', marginTop:'10px'}}>RecentSearches</h2><div style={{display:'flex', width:'50%', margin:'0px auto'}}>{savedState.map((one) =>{
          return <h3  style={{cursor:'pointer',padding:'30px', marginTop:'-20px'}}><ul><li onClick={() =>setText(one)}>{one}</li></ul></h3>})}</div> </>: ''}
        </form>
      </section>
    )
}

export default Search