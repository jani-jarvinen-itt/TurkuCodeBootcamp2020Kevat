import React from 'react';

class WebHaku extends React.Component {

   componentDidMount() {
        console.log("WebHaku.componentDidMount()");

        fetch('https://jsonplaceholder.typicode.com/todos/1')
        .then(response => response.json())
        .then(json => console.log(json))
   }

    render() {
        console.log("WebHaku.Render()");
        return <h2>WebHaku-komponentti!</h2>;
    }
}

export default WebHaku;