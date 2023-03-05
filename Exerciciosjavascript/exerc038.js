let vetorImpar = []
function imprimirImpares(inicio = 0 , fim= 100){
    let aux = 0
    if (fim < inicio){
        aux = fim 
        fim = inicio
        aux = fim
    }
    for(let i =0; i <= fim ; i++){
        if (i % 2 != 0)
            vetorImpar.push(i)
    }
    console.log(vetorImpar.join(' '))
}
imprimirImpares(50,0)