function planoDeSaude(idade){
    if (idade < 10){
        return console.log(`Valor a pagar: ${100 + 80}`)
    }else if (idade >=10 && idade <=30){
        return console.log(`Valor a pagar: ${100 + 50}`)
    }else if(idade >30 && idade <= 60){
        return console.log(`Valor a pagar: ${100 + 95}`)
    }else {
        return console.log(`Valor a pagar: ${100 + 130}`)
    }
}
planoDeSaude(65)
planoDeSaude(35)
planoDeSaude(25)
planoDeSaude(2)