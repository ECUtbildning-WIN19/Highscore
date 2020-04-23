import React from "react";

const GameHighscores = (props) => {
  return (
    <div>
      <h2>Highscores</h2>
      <ul>
        {props.scores &&
          props.scores.map((score) => (
            <li>
              {score.player}, {score.date}, {score.points}
            </li>
          ))}
      </ul>
    </div>
  );
};

export const message = "Hello World!";

export default GameHighscores;
