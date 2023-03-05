function frutas(fruta){
    switch(fruta){
        case "melancia":
            console.log("Aqui está, são 3 reais o quilo")
            break
        case "kiwi":
            console.log("Estamos com escassez de kiwis")
            break
        case "maçã":
            console.log("Não vendemos esta fruta aqui")
            break
        default: console.log(`Escolha outra fruta por favor ${fruta} está em falta`)

    }
}
frutas("melancia")
frutas("kiwi")
frutas("maçã")
frutas("uva")
frutas("banana e melao")
