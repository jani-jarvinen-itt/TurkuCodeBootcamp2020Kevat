import React from 'react';

class WebHaku extends React.Component {

    constructor(props) {
        super(props);

        console.log("WebHaku.constructor()");
        this.state = { työntekijät: [] };
    }

    componentDidMount() {
        console.log("WebHaku.componentDidMount()");

        console.log("WebHaku: aloitetaan Fetch-kutsu");

        fetch('http://dummy.restapiexample.com/api/v1/employees')
            .then(response => response.json())
            .then(json => {
                console.log("WebHaku: Fetch-kutsu valmis");
                console.log(json);

                console.log("WebHaku: Ennen tilan päivitystä");
                this.setState({ työntekijät: json.data });
                console.log("WebHaku: Tila on päivitetty!");                
            });
    }

    render() {
        console.log("WebHaku.Render()");

        let rivit = [];
        for (let index = 0; index < this.state.työntekijät.length; index++) {
            const työntekijä = this.state.työntekijät[index];
            rivit.push(<tr key={index}>
                <td>{työntekijä.employee_name}</td>
                <td>{työntekijä.employee_age}</td>
            </tr>);
        }

        return <div>
            <h2>WebHaku-komponentti!</h2>
            <table>
                <thead>
                    <tr>
                        <th>Nimi</th>
                        <th>Ikä</th>
                    </tr>
                </thead>
                <tbody>
                    {rivit}
                </tbody>
            </table>
        </div>;
    }
}

export default WebHaku;