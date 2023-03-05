function acharMedia(vetorNumeros){
    let media = 0
    let soma = 0
    for( let i =0; i <vetorNumeros.length; i++){
        soma += vetorNumeros[i]
        media = soma / vetorNumeros.length
    }
    return `A média do vetor é ${media}.`
}
const vetor =[1,21,35,5,90,12,50,220,30,10,19]
console.log(acharMedia(vetor))