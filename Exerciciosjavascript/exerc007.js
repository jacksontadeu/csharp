function baskara (a,b,c){
    result =[]
    let delta = (Math.pow(b,2)) - (4 * a * c)
    if (delta > 0){
        let bask1 = (-b + Math.sqrt(delta))/ (2 * a)
        let bask2 = (-b - Math.sqrt(delta))/ (2 * a)
       result.push(bask1)
       result.push(bask2)
       console.log(result)
    }else{
        console.log('Delta é negativo')
    }
}
baskara(3,12,2)
baskara(1, 3, 2)
baskara(3, 1, 2)