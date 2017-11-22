function playingWithArray(arr) {
    let n=Number(arr[0]);
    let resultArr=new Array(n);
    resultArr.fill(0);
    for(let i=1;i<arr.length;i++)
    {
        let tokens=arr[i].split(" - ").map(Number);
        let index=tokens[0];
        let value=tokens[1];
        resultArr[index]=value;
    }
  for (let number of resultArr)
  {
   console.log(number);
  }
}
playingWithArray(['3','0 - 5','1 - 6','2 - 7'])