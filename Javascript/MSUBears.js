for(let i = 1; i < 101; ++i){
    if(i % 3 === 0 && i % 5 === 0){
            console.log("MSUBears");
        }
        //when i is divisible by just 3 print MSU to the console.
        else if(i % 3 === 0){
            console.log("MSU");
        }
        //when i is divisible by just 5 print Bears to the console.
        else if(i % 5 === 0){
            console.log("Bears");
        }
        //when i isn't divisible by either 5 or 3 print its value.
        else{
            console.log(i);
        }
}