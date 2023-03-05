function acharIntervalo(vetorNumeros){
    let dentro = 0
    let fora = 0
    for (let i =0; i < vetorNumeros.length; i++){
        if (vetorNumeros[i] >= 10 && vetorNumeros[i] <= 20){
            dentro++
        }else{
            fora++
        }
    }
    return `${dentro} números estão dentro e ${fora} estão fora.`
}
const vetor =[1,21,35,5,90,12,50,20,30,10,19]
console.log(acharIntervalo(vetor))