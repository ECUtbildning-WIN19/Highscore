import React, { Component } from 'react';
import { Route } from 'react-router';
import GameDetails from './components/pages/GameDetails';

export default class App extends Component {

    static displayName = App.name;

    render() {
        return (
            <Route path='/game/:id' component={GameDetails} />
        );
    }
}