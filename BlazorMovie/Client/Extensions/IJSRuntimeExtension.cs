using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BlazorMovie.Client.Extensions
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            return await js.InvokeAsync<bool>("confirm", message);
        }

        public static async ValueTask Log(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("log", message);
        }
    }
}
