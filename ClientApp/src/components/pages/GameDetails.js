import React, { Component } from "react";

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
    let contents = !this.state.game ? (
      <div>loading...</div>
    ) : (
      <div>
        <h1>{this.state.game.title}</h1>
        <p>{this.state.game.description}</p>
        <img src={this.state.game.imageUrl} alt="Tetris" />
      </div>
    );

    return <div>{contents}</div>;
  }
}
