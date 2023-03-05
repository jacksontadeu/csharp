let vetorInteiro = [1,2,30,45]
let vetorString = ['Jackson', "Lais",'Luciana', 'Juninho']
let vetorDecimal = [0.12,0.25,0.33,0.5]
let array = vetorDecimal.concat(vetorInteiro)
let resultado = array.concat(vetorString)
console.log(resultado)
function concatenar(...args){
    results = []
    for (let i =0; i <arguments.length;i++){
        results = results.concat(arguments[i])
    }
    return results
}
console.log(concatenar(vetorDecimal,vetorInteiro,vetorString))