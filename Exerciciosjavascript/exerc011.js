function verificarBissexto(ano){
    if (ano <= 0 ){
        return false
    }else if (ano % 400 ==0){
        return true
    }else if (ano % 100 == 0 ){
        return false
    }else if (ano % 4 == 0){
        return true
    }else{
        return false
    }
    
}

console.log(verificarBissexto(0))
console.log(verificarBissexto(4))
console.log(verificarBissexto(100))
console.log(verificarBissexto(400))
console.log(verificarBissexto(800))
console.log(verificarBissexto(2020))
console.log(verificarBissexto(2021))
