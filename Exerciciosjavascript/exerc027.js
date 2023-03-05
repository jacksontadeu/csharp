function comparaCriancas(altura1,taxa1, altura2, taxa2){
    
    if (altura1 == altura2){
        if (taxa1 > taxa2){
            return "A criança1 ultrapassará a criança2 em 1 ano."
        }else{
            return "A criança2 ultrapassará a criança1 em 1 ano."
        }
    }else {
        if(altura1 > altura2){
            if (taxa1 >= taxa2){
                return "A criança2 não ultrapassará a criança1"
            }else{
                return `A criança2 ultrapassará a criança1 em ${calculaTempo(altura1,taxa1, altura2, taxa2)} anos.`
            }
        }else{
            if (taxa2 >= taxa1){
                return "A criança1 não ultrapassará a criança2"
            }else{
                return `A criança1 ultrapassará a criança2 em ${calculaTempo(altura2,taxa2, altura1, taxa1)} anos.`
            }
            
        }
    }
}
function calculaTempo(alturaMaior, taxaMaior, alturaMenor, taxaMenor){
    let tempo = 0
    while(alturaMaior > alturaMenor){
        alturaMaior += taxaMaior
        alturaMenor += taxaMenor
        tempo++

    }
    return tempo

}
console.log(comparaCriancas(150,2,130,4))
console.log(comparaCriancas(130,4,150,2))
console.log(comparaCriancas(150,4,150,2))
console.log(comparaCriancas(130,4,150,4))