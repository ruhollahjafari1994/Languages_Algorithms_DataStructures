import { Component } from "react";

/*
 * // NOTE Updating LifeCycle
 * - static getDrivedStateFromProps(props, state);
 * - shouldComponentUpdate(nextProps, nextState);
 * - render();
 * - getSnapshotBeforeUpdate(prevProps, prevState);
 * - componentDidUpdate();
 */

class Clock extends Component {
  constructor(props) {
    super(props);

    this.state = {};
    console.log("Clock.jsx - constructor()");
  }

  static getDerivedStateFromProps(props, state) {
    console.log("Clock.jsx - getDerivedStateFromProps()");
    return state;
  }

  shouldComponentUpdate(nextProp, nextState) {
    console.log("Clock.jsx - shouldComponentUpdate()");
    if (this.props.date !== nextProp.date) {
      return true;
    }
    return false;
  }

  componentDidMount() {
    console.log("Clock.jsx - componentDidMount()");
  }

  componentWillUnmount() {
    console.log("Clock.jsx - componentWillUnmount()");
  }

  getSnapshotBeforeUpdate(prevProp, prevState) {
    console.log("Clock.jsx - getSnapshotBeforeUpdate()");
    return { prevProp, prevState };
  }

  componentDidUpdate(prevProp, prevState, snapshot) {
    console.log("Clock.jsx - componentDidUpdate()");
    console.log(snapshot);
  }

  render() {
    console.log("Clock.jsx - render()");

    const { date, color } = this.props;

    const style = {
      color: color ? "tomato" : "black",
    };

    return (
      <>
        <p style={style}>
          ساعت در حال حاضر برابر : {date.toLocaleTimeString()}
        </p>
      </>
    );
  }
}

export default Clock;
