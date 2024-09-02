import { Component } from "react";
// class Counter extends Component{
// render(){
//    // console.log(this.props)
//    const {count}=this.props;
//     return(

//         <div>
//         <p>شمارنده: {count}</p>
//         </div>
//     )
// }
// }
//Use Object Destructure
const Counter = ({count})=>{
    return(
        <div>
             <p>شمارنده: {count}</p>
        </div>
    )
}

export default Counter;