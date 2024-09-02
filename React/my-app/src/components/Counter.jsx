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
//Pure and UnPure 
//Props are Read-Only
//Change State and Props force React to ReRender 
const Counter = (p)=>{
    console.log(p.count)
    console.log(p.fullName)
    console.log(p.myArrray)
    console.log(p.isLoggedIn)

    return(
        <div>
             <p>شمارنده: {p.count}</p>
        </div>
    )
}

export default Counter;