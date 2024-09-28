import { Component } from "react";

import Clock from "./components/Clock";

import "./App.css";

/*
 * // NOTE Mounting LifeCycle In Class Components
 * - constructor()
 * - static getDerivedStateFromProps(props, state)
 * - render()
 * - componentDidMount()
 */

class App extends Component {
  constructor() {
    super();
    console.log("App.js - constructor()");

    this.state = { date: new Date()};

    this.colorChange = this.colorChange.bind(this);
    this.clockChange = this.clockChange.bind(this);
  }

  static getDerivedStateFromProps(props, state) {
    console.log("App.js - getDerivedStateFromProps()");
    return state;
  }

  componentDidMount() {
    console.log("App.js - componentDidMount()");

    this.timer = setInterval(() => this.tick(), 1000);
  }

  componentWillUnmount() {
    console.log("App.js - componentWillUnmount()");

    clearInterval(this.timer);
  }

  tick() {
    this.setState({ date: new Date() });
  }

  clockChange() {
    this.setState({ showClock: !this.state.showClock });
  }

  colorChange() {
    this.setState({ color: !this.state.color });
  }

  render() {
    console.log("App.js - render()");

    const { date, showClock, color } = this.state;

    return (
      <div className="App">
        <p>سلام دوستان عزیز</p>
        {showClock ? <Clock date={date} color={color} /> : null}
        <hr />
        <button onClick={this.clockChange}>نمایش ساعت</button>
        <button onClick={this.colorChange}>تغییر رنگ</button>
      </div>
    );
  }
}

export default App;
