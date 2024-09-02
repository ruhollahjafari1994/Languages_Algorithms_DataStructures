import { Component } from "react";
import Counter from "./components/Counter";
import './MyCounter.css';
//  class MyCounter extends Component{
//     render(){
//         return(
//             <div className="MyCounter">
//                     <h1>شمارنده من</h1>
//                     <br/>
//                     <Counter count={50}/>
//             </div>
//         )
//     }
//  }
//Remove self closing
const MyCounter=()=>{
    return(
        <div className="MyCounter">
                     <h1>شمارنده من</h1>
                     <br/>
                     <Counter  count={520}>
                        این شمارنده من است
                     </Counter>


        </div>
    )
}
export default MyCounter;