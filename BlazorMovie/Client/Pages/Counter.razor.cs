using BlazorMovie.Client.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BlazorMovie.Client.Shared.MainLayout;

namespace BlazorMovie.Client.Pages
{
    public partial class Counter
    {
        [CascadingParameter] public AppState State { get; set; }
        [Inject] public SingletonService Singleton { get; set; }
        [Inject] public TransientService Transient { get; set; }
        [Inject] public IJSRuntime JSRuntime { get; set; }

        private int currentCount = 0;
        private static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
            Singleton.Value++;
            Transient.Value++;
            currentCountStatic++;
            await JSRuntime.InvokeVoidAsync("dotnetStaticInvocation");
        }

        private async Task IncrementCountJavaScript()
        {
            await JSRuntime.InvokeVoidAsync("dotnetInstanceInvocation", DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }

    }
}
