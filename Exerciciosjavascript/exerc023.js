function mediaAluno(codigo, nota1, nota2, nota3){
    while (codigo > 0){
        let media = ((nota1 * 4) + (nota2 *3) + (nota3 * 3)) / 10

        if(media >= 5 ){
            return `O aluno código ${codigo} obteve as notas ${nota1}, ${nota2} e ${nota3}. A média foi ${media} e está APROVADO!!!`
        }else{
            return `O aluno código ${codigo} obteve as notas ${nota1}, ${nota2} e ${nota3}. A média foi ${media} e está REPROVADO!!!`
        }

    }
}
console.log(mediaAluno(102, 5, 6.5, 10))
console.log(mediaAluno(103, 5, 2.5, 4))
console.log(mediaAluno(104, 5, 6.5, 5))
console.log(mediaAluno(-102, 5, 4.5, 10))