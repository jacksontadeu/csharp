function  negativos(vetor){
    let neg = 0
    for (let i = 0; i < vetor.length; i++){
        if (vetor[i] < 0){
            neg++
        }
    }
    return `${neg} são negativos nesse vetor.`
}
const vet =[1,-21,35,5,-90,12,-50,220,30,10,19]
console.log(negativos(vet))