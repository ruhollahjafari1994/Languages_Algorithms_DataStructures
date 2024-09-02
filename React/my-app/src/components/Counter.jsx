import { Component } from "react";
class Counter extends Component{
render(){
   // console.log(this.props)
    return(

        <div>
        <p>شمارنده: {Math.floor(Math.random()*1000)}</p>
        </div>
    )
}
}
// const Counter = ()=>{
//     return(
//         <div>
//              <p>شمارنده: {Math.floor(Math.random()*1000)}</p>
//         </div>
//     )
// }

export default Counter;