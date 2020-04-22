import React, { Component } from "react";
import { Route } from "react-router";
import GameDetails from "./components/pages/GameDetails";
import PlayerDetails from "./components/pages/PlayerDetails";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <div>
        <Route path="/game/:id" component={GameDetails} />
        <Route path="/player/:id" component={PlayerDetails} />
      </div>
    );
  }
}
