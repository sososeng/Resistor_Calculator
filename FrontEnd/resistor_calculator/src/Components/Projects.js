import React, { Component } from 'react';

import SelectField from 'material-ui/SelectField';
import MenuItem from 'material-ui/MenuItem';
import RaisedButton from 'material-ui/RaisedButton';
import AppBar from 'material-ui/AppBar';
import './Projects.css';
import TextField from 'material-ui/TextField';
import axios from 'axios';


const styles = {
  customWidth: {
    width: 150,
  },
};




class Projects extends Component {
  state = {
    valueOne: "None",
    colorOne: "#464646",
    valueTwo: "None",
    colorTwo: "#464646",
    valueThree: "None",
    colorThree: "#464646",
    valueFour: "None",
    colorFour: "#464646",
    result: ""


  };

handleChangeOne = (event, index, value) => {
  if(value === "None"){
    this.setState({valueOne : value, colorOne:"#464646"});
  } else if(value === "White"){
    this.setState({valueOne : value, colorOne:"#464646"});
  }
  else{
    this.setState({valueOne : value, colorOne:value});
  }
}


handleChangeTwo = (event, index, value) => {
  if(value === "None"){
    this.setState({valueTwo : value, colorTwo:"#464646"});
  } else if(value === "White"){
    this.setState({valueTwo : value, colorTwo:"#464646"});
  }
  else{
    this.setState({valueTwo : value, colorTwo:value});
  }
}

handleChangeThree = (event, index, value) => {
  if(value === "None"){
    this.setState({valueThree : value, colorThree:"#464646"});
  } else if(value === "White"){
    this.setState({valueThree : value, colorThree:"#464646"});
  }
  else{
    this.setState({valueThree : value, colorThree:value});
  }
}

handleChangeFour = (event, index, value) => {
  if(value === "None"){
    this.setState({valueFour : value, colorFour:"#464646"});
  } else if(value === "White"){
    this.setState({valueFour : value, colorFour:"#464646"});
  }
  else{
    this.setState({valueFour : value, colorFour:value});
  }
}

handleClick = (event)=>{


  axios.get("http://localhost:54228/api/values/" + this.state.valueOne+"-"+ this.state.valueTwo+"-"+ this.state.valueThree+"-"+ this.state.valueFour)
  .then(response => {
      this.setState({result : response.data});
    })
    .catch(error => {
      console.log('Error fetching and parsing data', error);
    });

}

  render() {
    return (
      <div className = "outer" >
      <AppBar
        title="Resistor Calculator"
         showMenuIconButton={false}
      />

        <div >
         <p className = "direction">Please select the color of each band on the resistor</p>
        </div>

        <div className = "inner">
          <div className = "selector">
            <SelectField
              floatingLabelText="First Band Color"
              value={this.state.valueOne}
              onChange={this.handleChangeOne}
              labelStyle={{ color: this.state.colorOne }}
              style={styles.customWidth}

            >
              <MenuItem value={"None"} primaryText="None" />
              <MenuItem value={"Black"} primaryText="Black" />
              <MenuItem value={"Brown"} primaryText="Brown" />
              <MenuItem value={"Red"} primaryText="Red" />
              <MenuItem value={"Orange"} primaryText="Orange" />
              <MenuItem value={"Yellow"} primaryText="Yellow" />
              <MenuItem value={"Green"} primaryText="Green" />
              <MenuItem value={"Blue"} primaryText="Blue" />
              <MenuItem value={"Violet"} primaryText="Violet" />
              <MenuItem value={"Gray"} primaryText="Gray" />
              <MenuItem value={"White"} primaryText="White" />

            </SelectField>
          </div>

          <div className = "selector">
            <SelectField
              floatingLabelText="Second Band Color"
              value={this.state.valueTwo}
              onChange={this.handleChangeTwo}
              labelStyle={{ color: this.state.colorTwo }}
              style={styles.customWidth}

            >
              <MenuItem value={"None"} primaryText="None" />
              <MenuItem value={"Black"} primaryText="Black" />
              <MenuItem value={"Brown"} primaryText="Brown" />
              <MenuItem value={"Red"} primaryText="Red" />
              <MenuItem value={"Orange"} primaryText="Orange" />
              <MenuItem value={"Yellow"} primaryText="Yellow" />
              <MenuItem value={"Green"} primaryText="Green" />
              <MenuItem value={"Blue"} primaryText="Blue" />
              <MenuItem value={"Violet"} primaryText="Violet" />
              <MenuItem value={"Gray"} primaryText="Gray" />
              <MenuItem value={"White"} primaryText="White" />

            </SelectField>
          </div>

          <div className = "selector">
            <SelectField
              floatingLabelText="Third Band Color"
              value={this.state.valueThree}
              onChange={this.handleChangeThree}
              labelStyle={{ color: this.state.colorThree }}
              style={styles.customWidth}

            >
              <MenuItem value={"None"} primaryText="None" />
              <MenuItem value={"Black"} primaryText="Black" />
              <MenuItem value={"Brown"} primaryText="Brown" />
              <MenuItem value={"Red"} primaryText="Red" />
              <MenuItem value={"Orange"} primaryText="Orange" />
              <MenuItem value={"Yellow"} primaryText="Yellow" />
              <MenuItem value={"Green"} primaryText="Green" />
              <MenuItem value={"Blue"} primaryText="Blue" />
              <MenuItem value={"Violet"} primaryText="Violet" />
              <MenuItem value={"Gray"} primaryText="Gray" />
              <MenuItem value={"White"} primaryText="White" />

            </SelectField>
          </div>

          <div className = "selector">
            <SelectField
              floatingLabelText="Fourth Band Color"
              value={this.state.valueFour}
              onChange={this.handleChangeFour}
              labelStyle={{ color: this.state.colorFour }}
              style={styles.customWidth}

            >
              <MenuItem value={"None"} primaryText="None" />
              <MenuItem value={"Brown"} primaryText="Brown" />
              <MenuItem value={"Red"} primaryText="Red" />
              <MenuItem value={"Gold"} primaryText="Gold" />
              <MenuItem value={"Silver"} primaryText="Silver" />

            </SelectField>
          </div>
          <RaisedButton label="calulate" primary={true} style={{margin: 12}} onClick = {this.handleClick} />
        </div>

        <div>
          <p>Resistor Value:</p>
          <TextField
           id= "calulate"
            value = {this.state.result}
            inputStyle={{ textAlign: 'center', cursor: 'none' }}
          />
        </div>
      </div>
    );
  }
}

export default Projects;
