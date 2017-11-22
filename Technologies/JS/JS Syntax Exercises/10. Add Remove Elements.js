function AddingRemovingElements(arr) {
    let resultArr=new Array();
    for(let i=0;i<arr.length;i++)
    {
      let tokens=arr[i].split(' ');
      let command=tokens[0];
      let num=Number(tokens[1]);
      if (command==="add") resultArr.push(num);
      else
      {
          if(num<0||num>resultArr.length-1)continue;
          resultArr.splice(num,1);
      }
    }
    for(let i=0;i<resultArr.length;i++)
    {
     console.log(resultArr[i]);
    }

}