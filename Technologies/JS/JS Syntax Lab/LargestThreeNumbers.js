function largestThreeNumbers(arr) {
    let numbers=arr.map(Number);
    numbers.sort((a,b)=>b-a)
  for (let i=0;i<3;i++) if(numbers[i]!==undefined)console.log(numbers[i])
}
largestThreeNumbers(['20','30']);