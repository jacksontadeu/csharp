function acharMaior(vetorNumeros){
    let maior = 0
    let menor = vetorNumeros[0]
    for (let i =0; i < vetorNumeros.length; i++){
        if (vetorNumeros[i] > maior){
            maior = vetorNumeros[i]
        }else if (vetorNumeros[i] < menor){
            menor= vetorNumeros[i]
        }
    }
    return `${maior} é o maior e ${menor} é o menor.`
}
const vetor =[1,21,35,5,90,12,-50,220,30,10,19]
console.log(acharMaior(vetor))