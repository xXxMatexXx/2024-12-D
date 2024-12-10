var tomb = []
tomb[0] = 0
tomb[1] = 1

for(var i = 2; i <=6; i++){
    tomb[i] = tomb[i - 1] + tomb[i -2]
}

console.log(tomb);