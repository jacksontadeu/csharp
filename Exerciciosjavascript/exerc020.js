function cedulas(valor){
    let nota100;let nota50; let nota10; let nota5; let nota1
    while(valor != 0){
        if (valor >= 100){
            nota100 = Math.floor(valor / 100)
            valor = valor - nota100 * 100
            
        }else if ((valor % 100) >= 50){
            nota50 = Math.floor((valor % 100) / 50)
            valor = valor - nota50 * 50
            
        }else if ((valor % 50 ) >= 10){
            nota10 = Math.floor((valor % 50) / 10)
            valor = valor - nota10 * 10
            
        }else if ((valor % 10 ) >= 5){
            nota5 = Math.floor((valor % 10) / 5)
            valor = valor - nota5 * 5
            
        }else if ((valor % 5 ) >= 1){
            nota1 = Math.floor((valor % 5) / 1)
            valor = valor - nota1 * 1
            
        }
    }
    console.log(`Notas de 100: ${nota100}`)
    console.log(`Notas de 50: ${nota50}`)
    console.log(`Notas de 10: ${nota10}`)
    console.log(`Notas de 5: ${nota5}`)
    console.log(`Notas de 1: ${nota1}`)
}

cedulas(377)
