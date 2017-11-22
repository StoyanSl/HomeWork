function KeyValuePLaying(arr) {
    let resultDict = [];
    for (var i = 0; i < arr.length; i++) {
        let tokens = arr[i].split(' ');
        if (tokens.length == 1) break;
        let key = tokens[0];
        let value = tokens[1];
        resultDict[key] = value;
    }
   if(resultDict[arr[i]]!=undefined)
   {
       return resultDict[arr[i]];
   }
   else return "None"

}
console.log(KeyValuePLaying(['3 bla',
    '3 alb',
    'test tset',
    '2']))