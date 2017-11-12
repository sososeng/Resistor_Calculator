import React, { Component } from 'react';
import './App.css';

import MuiThemeProvider from 'material-ui/styles/MuiThemeProvider';
import Projects from './Components/Projects'

class App extends Component {

  render() {
    return (
      <MuiThemeProvider>
        <Projects />
      </MuiThemeProvider>
    );
  }
}

export default App;
