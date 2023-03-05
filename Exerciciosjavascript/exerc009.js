function classificarAluno(nota){
    let notaFinal = arredondarNota(nota)

    if (notaFinal >= 40){
        console.log (`Aluno aprovado com a nota ${notaFinal}`)
    }else{
        console.log(`Aluno reprovado com a nota ${notaFinal}`)
    }
}
function arredondarNota(nota){
    if (nota % 5 > 2){
          
        return nota + (5 - (nota % 5))
    }else {
        return nota
    }
}
classificarAluno(100)
classificarAluno(30)
classificarAluno(38)
classificarAluno(88)
classificarAluno(61)