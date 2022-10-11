
import React from 'react'

const CharacterItem = ({ item }) => {
    return (
      <div className='card'>
        <div className='card-inner'>
          <div className='card-front'>
            <img src={item.movieImageURL} alt='' />
          </div>
          <div className='card-back'>
            <h1>{item.title}</h1>
            <ul>
              <li>
                <strong>Movie Stars:</strong> {item.movieStars}
              </li>
              <li>
                <strong>Genre:</strong> {item.movieGenre}
              </li>
              <li>
                <strong>Release Year:</strong> {item.movieYear}
              </li>
              <li>
                <strong>Runtime:</strong> {item.movieRuntime}
              </li>
              <li>
                <strong>Directors:</strong> {item.movieDirectort}
              </li>
              <li>
                <strong>IMBD Rating:</strong> {item.movieRating}
              </li>
          
            </ul>
          </div>
        </div>
      </div>
    )
  }
  
  export default CharacterItem