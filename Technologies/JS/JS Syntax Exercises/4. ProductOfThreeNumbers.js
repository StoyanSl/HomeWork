function productOfThreeNumbers(arr) {
    let numbers= Array(Number(arr[0]),Number(arr[1]),Number(arr[2]))
    if(checkForZero(numbers)){return"Positive";}
    if (countingNegatives(numbers)%2===0) return "Positive";
    else return "Negative"
    function checkForZero(numbers) {
        for (let number of numbers)
        {
            if (number===0) return true;
        }
        return false;
    }
   function countingNegatives(arr) {
        let counter=0;
       for(let element of arr){
           if(element<0) counter++;
       }
       return counter;
   }
}
console.log(productOfThreeNumbers(['2',
   '3',
    '-1']))