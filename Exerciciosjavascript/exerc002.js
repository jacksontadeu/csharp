const triangulo = function(a,b,c){

    if(a == b && b == c) console.log('Triângulo Equilátero')
    else if (a == b || b ==c || a == c) console.log("Triãgulos Isósceles")
    else if (a!== b && b !== c) console.log('Triàngulo Escaleno')

}
triangulo(1,1,1)
triangulo(2,1,2)
triangulo(1,3,3)
triangulo(1,2,3)
triangulo(3,3,3)