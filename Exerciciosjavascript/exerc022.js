function anuidade(mes,taxa){
    let valor
    switch(mes){
        case 1:
            valor = taxa
            return valor.toFixed(2)
            break
        case 2:
            valor = taxa * Math.pow((1 + (5/100)), 1)
            return valor.toFixed(2)
            break
        case 3:
            valor = taxa * Math.pow((1 + (5/100)), 2)
            return valor.toFixed(2)
            break
        case 4:
            valor = taxa * Math.pow((1 + (5/100)), 3)
            return valor.toFixed(2)
            break
        case 5:
            valor = taxa * Math.pow((1 + (5/100)), 4)
            return valor.toFixed(2)
            break
        case 6:
            valor = taxa * Math.pow((1 + (5/100)), 5)
            return valor.toFixed(2)
            break
        case 7:
            valor = taxa * Math.pow((1 + (5/100)), 6)
            return valor.toFixed(2)
            break
        case 8:
            valor = taxa * Math.pow((1 + (5/100)), 7)
            return valor.toFixed(2)
            break
        case 9:
            valor = taxa * Math.pow((1 + (5/100)), 8)
            return valor.toFixed(2)
            break
        case 10:
            valor = taxa * Math.pow((1 + (5/100)), 9)
            return valor.toFixed(2)
            break
        case 11:
            valor = taxa * Math.pow((1 + (5/100)), 10)
            return valor.toFixed(2)
            break
        case 12:
            valor = taxa * Math.pow((1 + (5/100)), 11)
            return valor.toFixed(2)
            break
        default: return "Mês inválido"
    }
}
console.log(anuidade(14,200))

function cobranca(mes, valor){
    if (mes > 1 && mes <12){
        let tempo = mes - 1
        montante = valor* Math.pow((1 + (5/100)), tempo)
        return montante.toFixed(2)
    }else{
        return "Mês inválido"

    }
}
console.log(cobranca(14,100))