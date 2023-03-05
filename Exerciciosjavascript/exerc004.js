const divisao = function(dividendo, divisor){
    resto = dividendo % divisor
    resultado = dividendo / divisor
    console.log(`Resto....: ${resto}`)
    console.log(`Resultado: ${Math.floor(resultado)}`)
}
divisao(10,3)