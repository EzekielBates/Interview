//calculates the nth number of the fibonnaci sequence.
function fib(n){
    let w,x,z;
        w = 1;
        x = 1;
    // adds the previous two numbers in the sequence to the current number and swaps the values until it gets the desired place in the sequence.
    for(let i = 2; i <= n; ++i){
        z = w+x;
        x = w;
        w = z;       
    }
    if(n == 0 || n == 1){
        z = 1;
    }
    return z;
}

let n = 5;
console.log(fib(n));