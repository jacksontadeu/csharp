function calcularVenda(codigo, qtde){
switch(codigo){
    case 100:
        return qtde * 3
        break
    case 200:
        return qtde *4
        break
    case 300:
        return qtde * 5.5
        break
    case 400:
        return qtde * 7.5
        break
    case 500:
        return qtde * 3.5
    case 600:
        return qtde * 2.8
    default: return "Opção não disponível"
}
}
console.log(calcularVenda(100, 3))
console.log(calcularVenda(800, 3))
console.log(calcularVenda(200, 3))
console.log(calcularVenda(300, 3))
console.log(calcularVenda(400, 3))
console.log(calcularVenda(500, 3))
console.log(calcularVenda(600, 2))

