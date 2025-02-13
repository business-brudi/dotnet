# What's new in Blazor .Net 9
[Link](https://learn.microsoft.com/de-de/aspnet/core/release-notes/aspnetcore-9.0?view=aspnetcore-9.0)

## .NET MAUI Blazor Hybrid and Web App solution template

use new template Blazor Web App (Blazor Server & hosted WASM konsolidated)
- 'dotnet workload install maui'
- 'dotnet new maui-blazor-web'
- rendermode (net8) global interactive auto 

## Detect rendering location, interactivity, and assigned render mode at runtime

[Link](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/render-modes?view=aspnetcore-9.0#detect-rendering-location-interactivity-and-assigned-render-mode-at-runtime)

+ Determine the current execution location of the component
+ Check if the component is running in an interactive environment
+ Retrieve the assigned render mode for the component

## Improved server-side reconnection experience

- immediately rather than waiting for the duration of the next reconnect interval
- When a reconnection attempt reaches the server but the server has already released the circuit, a page refresh occurs automatically.
- Reconnect timing uses a computed backoff strategy
  - customization possible via javascript

## Simplified authentication state serialization for Blazor Web Apps
