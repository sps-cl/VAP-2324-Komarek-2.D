let platno = document.getElementById("platno")
let kontext = platno.getContext("2d")

let stredKruhuX = 100;
let stredKruhuY = 100;

platno.onmousemove = function(event){
    let rect = platno.getBoundingClientRect();
    stredKruhuX = event.clientX - rect.left
    stredKruhuY = event.clientY - rect.top
}

function nakresli(){
    kontext.clearRect(0, 0, platno.clientWidth, platno.clientHeight)
    kontext.beginPath()
    kontext.arc(stredKruhuX, stredKruhuY, 50, 0, 2*Math.PI)
    kontext.fill()
    kontext.fillStyle = "red"
    kontext.fillRect(150, 150, 100, 100)
    kontext.fillStyle = "blue"
    requestAnimationFrame(nakresli);
}

nakresli()