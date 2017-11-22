function symmetricNumbers(input) {
    let n=Number(input);
    for(let i=0;i<=n;i++){
        if(isSymmetric(i.toString()))
        {
            if (i!==0)
            {
                console.log(i);
            }
        }
    }
    function isSymmetric(str) {
        for(let i=0;i<=str.length/2;i++){
          if(str[i]!=str[str.length-i-1])return false;
        }
        return true;
    }
}
symmetricNumbers(750)