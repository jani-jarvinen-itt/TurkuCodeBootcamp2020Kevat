import React from 'react';

class Laskuri extends React.Component {
    render() {

        let luvut = [];
        for (let index = 0; index < this.props.maksimi; index++) {
            luvut.push(<li key={index}>{index + 1}</li>);
        }

        return <ul>
                  {luvut}
               </ul>;
    }
}

export default Laskuri;
