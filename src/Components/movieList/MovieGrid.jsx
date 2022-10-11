import React from 'react'
import CharacterItem from './CharacterItem'
import Spinner from '../ui/Spinner'
const MovieGrid  = ({ items, isLoading,notFound }) => {
    return isLoading ? (
      <Spinner />
    ) : (
      <section className='cards'>
     
         {!notFound && <CharacterItem item={items}></CharacterItem>}
         {notFound && <h1 style={{textAlign:'center'}}>NOT FOUND</h1>}
        
      </section>
    )
  }

export default MovieGrid