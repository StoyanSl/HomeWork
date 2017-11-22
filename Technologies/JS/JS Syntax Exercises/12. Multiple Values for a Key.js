function solve(arr) {
    let resultDict = [];
    for (var i = 0; i < arr.length; i++) {
        let tokens = arr[i].split(' ');
        if (tokens.length == 1) break;
        let key = tokens[0];
        let value = tokens[1];

        if(!(resultDict.hasOwnProperty(key))) {
            resultDict[key] = new Array();
        }
        resultDict[key].push(value);
    }
    if(resultDict[arr[i]]!=undefined)
    {
        let key = arr[i];
        for(let j=0;j<resultDict[key].length;j++)
        {
        console.log(resultDict[key][j])
        }
    }
    else return "None"

}
console.log(solve(['key value',
    'key eulav',
    'test tset',
    'key']))