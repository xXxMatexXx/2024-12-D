let btn1 = document.getElementById("helloGomb");
let inpt1 = document.getElementById("inputMezo");
let p1 = document.getElementById("helloInputNev");

btn1.addEventListener('click',function(){
    p1.textContent = "Helló, " + inpt1.value +"!";
});

let btn2 = document.getElementById("festoGomb");
let p2 = document.getElementById("festeniValoSzoveg");

btn2.addEventListener('click',function(){
    p2.style = "background-color: red;"
});

let btn3 = document.getElementById("szamlaloGomb");
let p3 = document.getElementById("szamlalo");
let clicks = 0;

btn3.addEventListener('click',function(){
    clicks++;
    p3.innerHTML = clicks;
});

let btn4 = document.getElementById("listaHozzaad");
let inpt2 = document.getElementById("listaInput");
const ul = document.getElementById("lista");

btn4.addEventListener('click',function(){
    const li = document.createElement("li");
    li.appendChild(document.createTextNode(inpt2.value));
    ul.appendChild(li);
});

let btn5 = document.getElementById("elohozoGomb");
let p4 = document.getElementById("rejtettSzoveg");

btn5.addEventListener('click',function(){
    if (p4.style.display == "none") {
        btn5.textContent = "Rejtsd el";
        p4.style = "display: inline;"
    }
    else {
        btn5.textContent = "Mutasd";
        p4.style = "display: none;"
    }
    
});