import React from 'react';

class WebHaku extends React.Component {

    componentDidMount() {
        console.log("WebHaku.componentDidMount()");

        console.log("WebHaku: aloitetaan Fetch-kutsu");

        fetch('http://dummy.restapiexample.com/api/v1/employees')
            .then(response => response.json())
            .then(json => {
                console.log("WebHaku: Fetch-kutsu valmis");
                console.log(json);
            });
    }

    render() {
        console.log("WebHaku.Render()");
        return <h2>WebHaku-komponentti!</h2>;
    }
}

export default WebHaku;