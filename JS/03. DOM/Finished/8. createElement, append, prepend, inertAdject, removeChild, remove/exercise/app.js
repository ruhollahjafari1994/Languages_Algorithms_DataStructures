// createElement()
// append()
// prepend()

/* insertAdjacentElement(
    'beforebegin'
    'afterend'
    'beforeend'
    'afterend',
    element
) */

// removeChild()
// remove()

const h1 = document.querySelector("h1");
const ul = document.querySelector("ul");
const li = document.createElement("li");
const li1 = document.createElement("li");

li.innerText = 6;
li1.innerText = 623473894;

li.classList.add("special");
li1.classList.add("special2");

// ul.append(li);
ul.prepend(li);
ul.prepend(li1); 

ul.removeChild(li);
h1.remove();

// ul.insertAdjacentElement("beforebegin", li);
// ul.insertAdjacentElement("afterend", li);
// ul.insertAdjacentElement("beforeend", li);
ul.insertAdjacentElement("afterend", li);
console.log(li);
