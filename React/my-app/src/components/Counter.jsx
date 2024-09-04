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
//Use default props

const Counter = (p)=>{
    return(
        <div>
             <p>شمارنده: {p.count}</p>
             <p>شمارنده: {p.children}</p>

        </div>
    )
}

export default Counter;