let notas = []
function verificaNotas(notas){
    for(let nota of notas){
        if(nota >0 && nota <= 4.9) console.log("Conceito D")
        else if (nota >=5.0 && nota <= 6.9) console.log("Conceito C")
        else if (nota >= 7.0 && nota <= 8.9) console.log("Conceito B")
        else if (nota >= 9.0 && nota <= 10.0) console.log("Conceito A")
    }
}
verificaNotas([10,5.5,7.0,9.9])