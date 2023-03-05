function jurosSimples (capital, juros, tempo){
    let montante = capital + (capital * (juros /100)* tempo)
    console.log("Juros Simples")
    console.log(`Capital......: R$ ${capital.toFixed(2)}`)
    console.log(`Taxa de juros: ${juros}`)
    console.log(`Tempo........: ${tempo}`)
    console.log(`Montante.....: R$ ${montante.toFixed(2)}`)

}
function jurosCompostos (capital, juros, tempo){
    let montante = capital*Math.pow((1 + (juros/100)), tempo)
    console.log("Juros Compostos")
    console.log(`Capital......: R$ ${capital.toFixed(2)}`)
    console.log(`Taxa de juros: ${juros}`)
    console.log(`Tempo........: ${tempo}`)
    console.log(`Montante.....: R$ ${montante.toFixed(2)}`)
}
jurosSimples(100,10,2)
jurosCompostos(100,10,2)