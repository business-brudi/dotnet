# What's new in Blazor .Net 9
[Link](https://learn.microsoft.com/de-de/aspnet/core/release-notes/aspnetcore-8.0?view=aspnetcore-8.0)

## @rendermode

use new template Blazor Web App (Blazor Server & hosted WASM konsolidated)

- component/page level or global
- SSR static serverside rendering
- interactive server
- interactive wasm
- interachtive auto

## Persist Prerendered State

[Link](https://learn.microsoft.com/de-de/aspnet/core/blazor/components/prerender?view=aspnetcore-8.0&viewFallbackFrom=aspnetcore-3.0&preserve-view=true#persist-prerendered-state)

+ PrerenderedCounter1 - without
+ PrerenderedCounter2 - with

look in console output

## Editform / \<form>

- considered attributes (ex. `[DataMember]` or `[IgnoreDataMember]`)
- new AntiforgeryToken-component render hidden member
- is active by default for `EditForm`
- `[RequireAntiforgeryToken]`


## Navigation

- reload page `NavigationManager.Refresh(bool forceLoad = false)`

## Streamingrendering

- Weather component
- renders placeholder, when streaming complete dom will be patched

## Key for DI

```cs
[Inject(Key = "my-service")]
public IMyService MyService { get; set; }
```
- `@inject` key not supported at this time

## Http Context

- accessible as static server component via cascading parameter
```
[CascadingParameter]
public HttpContext? HttpContext { get; set; }
```

## QuickGrid

[Link](https://learn.microsoft.com/de-de/aspnet/core/blazor/components/quickgrid?preserve-view=true&view=aspnetcore-8.0)
- via NuGet
- EF-Core support via DI (extra NuGet)

## Rendering outside from ASP.Net Core

- there was a article from PBE?
```
var parameters = ParameterView.FromDictionary(dictionary);
var output = await htmlRenderer.RenderComponentAsync<RenderMessage>(parameters);

output.ToHtmlString();
```

## Section Outlets

`SectionOutlet` `SectionContent`

## User Defined Error Pages in Blazor Web App

## new IExceptionHandler

`IServiceCollection.AddExceptionHandler<T>`
- Singleton
- Check in flow of registration

## Hashed Routing

HashedReload

## Root-Level-Cascading-Values

Daleks-Component
Program.cs

## Virtualize Empty Content

EmptyVirtualzie

## Monitoring SignalR Activities

[Link](https://learn.microsoft.com/de-de/aspnet/core/blazor/fundamentals/signalr?preserve-view=true&view=aspnetcore-8.0#monitor-server-side-circuit-activity)

## Better JIT Performance

## WASM Debugging

Loads NuGet PDB's automatically

## Handling for Exceptions outside of Blazor-Lifecycle

`ComponentBase.DispatchExceptionAsync`

```cs
try
{
    ...
}
catch (Exception ex)
{
    await DispatchExceptionAsync(ex);
}
```
Will be catched in ErrorBoundary
```cs
<article class="content px-4">
    <ErrorBoundary>
        <ChildContent>
            @Body
        </ChildContent>
        <ErrorContent>
            <p class="alert alert-danger" role="alert">
                Oh, dear! Oh, my! - George Takei
            </p>
        </ErrorContent>
    </ErrorBoundary>
</article>
```
Component Ex.
```
<button @onclick="SendReport">Send report</button>

@code {
    private void SendReport()
    {
        _ = SendReportAsync();
    }

    private async Task SendReportAsync()
    {
        try
        {
            await ReportSender.SendAsync();
        }
        catch (Exception ex)
        {
            await DispatchExceptionAsync(ex);
        }
    }
}
```

## Project Templates without Open Ionic

## <dialog> button support

```
<div>
    <p>Output: @message</p>

    <button onclick="document.getElementById('my-dialog').showModal()">
        Show modal dialog
    </button>

    <dialog id="my-dialog" @onclose="OnClose" @oncancel="OnCancel">
        <p>Hi there!</p>

        <form method="dialog">
            <button>Close</button>
        </form>
    </dialog>
</div>

@code {
    private string? message;

    private void OnClose(EventArgs e) => message += "onclose, ";

    private void OnCancel(EventArgs e) => message += "oncancel, ";
}
```

## Secure Blazor WASM with ASP.NET Core Identity

[SampleApp](https://learn.microsoft.com/de-de/aspnet/core/blazor/security/webassembly/standalone-with-identity?preserve-view=true&view=aspnetcore-8.0)
[Blog Entry](https://devblogs.microsoft.com/dotnet/whats-new-with-identity-in-dotnet-8/#the-blazor-identity-ui)

