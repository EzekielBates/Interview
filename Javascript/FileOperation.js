const readline = require('readline');
const fs = require('fs');
const file = "bear.txt"

//creates a way to read data from a file.
const readInterface = readline.createInterface({
    input: fs.createReadStream(file),
    console: false
});

//reads data from a file line by line
readInterface.on('line',function(line){
    let isBear = false;
    //split the line into individual words
    let str = line.split(' ');
    //loop through the words looking for bear.
    for(let i = 0; i < str.length; ++i){
        //if the word bear. is found isBear becomes true.
        if(str[i] === 'bear.'){
            isBear = true;
            break;
        }
    }
    if(isBear)
        console.log("bear. is present in that line");
    else 
        console.log("bear. is not present in that line");
    //closes the filestream.
    readInterface.close();
});