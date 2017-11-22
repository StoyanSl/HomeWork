function ThreeIntegersSum([input]) {
    let numbers;
    numbers = input.split(' ').map(Number);
    let num1=numbers[0];
    let num2=numbers[1];
    let num3=numbers[2];
    if(num1+num2==num3){return `${Math.min(num1,num2)} + ${Math.max(num1,num2)} = ${num3}`;}
    else if (num3+num1==num2){return `${Math.min(num3,num1)} + ${Math.max(num3,num1)} = ${num2}`;}
    else if (num3+num2==num1){return `${Math.min(num3,num2)} + ${Math.max(num3,num2)} = ${num1}`;}
    else return `No`;
}