function trocaVetor (vetorA, vetorB){
    if (vetorA.length == vetorB.length){
        for(let i= 0; i <vetorA.length; i++){
            vetorA[i] = vetorA[i] + vetorB[i]
            vetorB[i] = vetorA[i] - vetorB[i]
            vetorA[i] = vetorA[i] - vetorB[i]
        }
    }
    console.log(`Vetor A: ${vetorA}`)
    console.log(`Vetor B: ${vetorB}`)
}
trocaVetor([1,2,3], [11,22,32])