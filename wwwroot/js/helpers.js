function notifyUIUpdateComplete() {
    requestAnimationFrame(() => {
        DotNet.invokeMethodAsync('test1Blazor', 'NotifyUIUpdateComplete');
    });
}
