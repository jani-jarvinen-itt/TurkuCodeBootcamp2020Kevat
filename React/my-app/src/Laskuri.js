import React from 'react';

class Laskuri extends React.Component {
    render() {

        let luvut = [];
        for (let index = 0; index < 10; index++) {
            luvut.push(<li>{index + 1}</li>);
        }

        return <ul>
                  {luvut}
               </ul>;
    }
}

export default Laskuri;
