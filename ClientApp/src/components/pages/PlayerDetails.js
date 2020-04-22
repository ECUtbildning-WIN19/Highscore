import React, { Component } from "react";

export default class PlayerDetails extends Component {
  static displayName = PlayerDetails.name;

  constructor(props) {
    super(props);

    this.state = {
      player: {
        alias: "MrPlayer",
      },
    };
  }

  render() {
    return <div>{this.state.player.alias}</div>;
  }
}
