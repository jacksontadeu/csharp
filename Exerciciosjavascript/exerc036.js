let vetorMultiplicado = []
let vetor = []
let vetorMaior5 = []
function calcularVetor(vetor,num){
    for(let element of vetor){
        vetorMultiplicado.push(element * num)
    }
    return vetorMultiplicado
}
function calcularVetorMaior5(vetor, num){
    for( let element of vetor){
        if (element > 5 )
            vetorMaior5.push(element * num)
    }
    return vetorMaior5
}

console.log(`Vetor multiplicado............: ${calcularVetor([2,4,6,8],3)}`)
console.log(`Vetor multiplicado maior que 5: ${calcularVetorMaior5([1,2,6,8,9],2)}`)