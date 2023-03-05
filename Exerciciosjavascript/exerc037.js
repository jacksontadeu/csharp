var vetorPA =[]
function PA(num, termo,razao){
    
    for (let i =0; i <num; i++){
        let numeros = termo + (razao *i)
        vetorPA.push(numeros)
    }
    console.log("Progressão Aritmética")
    return (num * ((termo * termo) + ((num - 1) * razao))) / 2
}

console.log(`Soma dos termos: ${PA(5, 2, 10)}`)
console.log(vetorPA.join(' '))
console.log()
let vetorPG = []
function PG(num, termo,razao){
    for(let i = 0; i < num; i++){
        let numeros = termo * (Math.pow(razao,i))
        vetorPG.push(numeros)
    }   
    console.log('Progressão Geométrica')
    return (termo * (Math.pow(razao, num) - 1)) / (razao - 1)

}
console.log(`Soma dos termos: ${PG(10,5,3)}`)
console.log(`Os termos são: ${vetorPG.join(' ')}`)