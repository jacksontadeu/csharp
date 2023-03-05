const vetor = [1,2,3,4,5,6,7,8,9,10,11,12,20]
let impar = 0
let par = 0
function acharPares(vetorNumeros){
    
    for (let i =0 ; i < vetorNumeros.length; i++){
        if (i % 2 == 0){
            par++
        }else{
            impar++
        }
    
    }
    return `${par} números são pares e ${impar} são ímpares.`
}
console.log(acharPares(vetor))