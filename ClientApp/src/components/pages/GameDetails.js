import React, { Component } from "react";
import GameHighscores, { message } from "../GameHighscores";

export default class GameDetails extends Component {
  static displayName = GameDetails.name;

  constructor(props) {
    super(props);

    this.state = {
      game: null,
    };
  }

  componentDidMount() {
    const gameId = this.props.match.params.id;

    fetch(`https://localhost:5001/game/${gameId}`)
      .then((x) => x.json())
      .then((game) => {
        this.setState({
          game,
        });
      });
  }

  render() {
    const game = this.state.game;

    let contents = !game ? (
      <div>loading...</div>
    ) : (
      <div>
        <h1>{game.title}</h1>
        <p>{game.description}</p>
        <img src={game.imageUrl} alt="Tetris" />
        <hr />
        <GameHighscores scores={game.scores} />
      </div>
    );

    return <div>{contents}</div>;
  }
}
