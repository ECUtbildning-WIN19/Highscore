import React, { Component } from 'react';


export default class GameDetails extends Component {

    static displayName = GameDetails.name;

    constructor(props) {

        super(props);

        this.state = {
            game: {
                title: "Tetris",
                description: "Lorem ipsum dolor",
                imageUrl: "http://via.placeholder.com/640x480.png?text=Tetris"
            }
        }
    }

    render() {
        return (
            <div>
                <h1>{this.state.game.title}</h1>
                <p>
                    {this.state.game.description}
                </p>
                <img src={this.state.game.imageUrl} alt="Tetris" />
            </div>
        );
    }
}
