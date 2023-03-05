function verificarString(word1, word2){
    let isContent = true
    for(let i =0;i <word1; i++){
        let string1 = word1.charAt(i).toLowerCase()
        for(let j = 0; j< word2; j++){
            let string2 = word2.charAt(j).toLowerCase()
            if (string1 == string2){
                isContent = true
                break
            }else{
                isContent = false
                
            }
        }
        if(!isContent)
            return isContent
    }
    
    for(let i =0;i <word2.length; i++){
        let string2 = word2.charAt(i).toLowerCase()

        for(let j = 0; j< word1.length; j++){
            let string1 = word1.charAt(j).toLowerCase()
            if (string1 == string2){
                isContent = true
                break
            }else{
                isContent =false
                
            }
        }
        if(!isContent)
            return isContent
    }
    return isContent

}
console.log(verificarString('ejack','cajke'))