import React, { Component } from "react";

export default class Games extends Component {
  static displayName = Games.name;

  constructor(props) {
    super(props);

    this.state = {
      games: [],
    };
  }

  componentDidMount() {
    fetch(`https://localhost:5001/graphql?query={games{title}}`)
      .then((x) => x.json())
      .then((data) => {
        this.setState({
          games: data.data.games,
        });
      });
  }

  render() {
    return (
      <div>
        <h2>Games</h2>
        <ul>
          {this.state.games.map((game) => (
            <li>{game.title}</li>
          ))}
        </ul>
      </div>
    );
  }
}
