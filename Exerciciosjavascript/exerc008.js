let pontos = [10,1,35,12,14,36,41,9,52,5]

function verificaPontos (pontos){
    let maiorPontuacao = pontos[0]
    let menorPontuaçao = pontos[0]
    let qtdeJogosComRecorde= 0
    let piorJogo = 1
    let resultado = []
    
    for(let i = 1; i<pontos.length; i++){
        if (pontos[i] > maiorPontuacao){
            maiorPontuacao = pontos[i]
            qtdeJogosComRecorde++
        }else if (pontos[i] < menorPontuaçao){
            menorPontuaçao = pontos[i]
            piorJogo = i+1;

        }

    }
    resultado.push(qtdeJogosComRecorde)
    resultado.push(piorJogo)
    return resultado
}
console.log(verificaPontos(pontos))