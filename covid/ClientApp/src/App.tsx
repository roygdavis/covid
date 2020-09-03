import React from 'react';
import logo from './logo.svg';
import './App.css';
import { getDataForCountry } from './code/httpService';
import { Row } from './code/model';
import { Chart } from 'react-google-charts';

export interface AppProps {

}

export interface AppState {
  rows: Row[];
}

class App extends React.Component<AppProps, AppState> {
  constructor(props: AppProps) {
    super(props);
    this.state = { rows: [] };
  }

  async UNSAFE_componentWillMount() {
    const rows = await getDataForCountry("greece")
      .then(x => x.data)
      .catch(x => { console.log(x); return []; }) as Row[];

    this.setState({ rows });
  }

  render() {
    const { rows } = this.state;
    const data = [["Date", "Daily cases"], ...rows.map(x => [x.date, x.newCasesPerMillion])];
    return (
      <div className="App">
        <header className="App-header">
          <h1>Covid 2</h1>
          <img src={logo} className="App-logo" alt="logo" />
          <p>
            Edit <code>src/App.tsx</code> and save to reload.
        </p>
          <Chart
            chartType="ScatterChart"
            data={data}
            width="100%"
            height="400px"
            legendToggle
          />
          <a
            className="App-link"
            href="https://reactjs.org"
            target="_blank"
            rel="noopener noreferrer"
          >
            Learn React
        </a>
        </header>
      </div>
    );
  }
}

export default App;
