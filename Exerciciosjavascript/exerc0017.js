function salario(valor, opcao){
    
    switch(opcao){
        case "A":
            console.log(`O salário era ${valor.toFixed(2)} com reajuste ficou R$ ${(valor * 1.1).toFixed(2)}` )
            break
        case "B":
            console.log(`O salário era ${valor.toFixed(2)} com reajuste ficou R$ ${(valor * 1.15).toFixed(2)}` )
            break
        case "C":
            console.log(`O salário era ${valor.toFixed(2)} com reajuste ficou R$ ${(valor * 1.2).toFixed(2)}` )
            break
        default: console.log('Plano inválido!!!!')
    }
}
salario(1000, "A")
salario(2000, "B")
salario(3000, "C")
salario(1000, "D")