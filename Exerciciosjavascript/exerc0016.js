function calculadora(x,y,operacao){
    switch(operacao){
        case "+":
            console.log(x + y)
            break
        case "-":
            console.log(x - y)
            break
        case "*":
            console.log(x * y)
            break
        case "/":
            console.log(x / y)
            break
        default:
            console.log('Operação Inválida!!!')
    }
}
calculadora(10,5,"+")
calculadora(10,5,"-")
calculadora(10,5,"*")
calculadora(10,5,"/")
calculadora(10,5,"a")