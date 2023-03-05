function formatarDinheiro(valor){
    valorReais = `R$ ${valor.toFixed(2).toString().replace(".",",")}`
    return valorReais
}
console.log(formatarDinheiro(2.53 + 5.99))