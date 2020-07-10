function log (message){
    console.log(message);
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorMovie.Client", "GetCurrentCount")
            .then(result => {
                log(`Count from js: ${result}`);
            });
}

function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}