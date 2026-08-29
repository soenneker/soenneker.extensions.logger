[![](https://img.shields.io/nuget/v/soenneker.extensions.logger.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.logger/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.logger/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.logger/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.logger.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.logger/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.logger/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.logger/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Logger
A collection of helpful ILogger extension methods.

## Installation

```bash
dotnet add package Soenneker.Extensions.Logger
```

## Quick start

```csharp
using Soenneker.Extensions.Logger;

// Given an existing ILogger named logger:
logger.LogStartupInformation(timeZoneInfo);
```

## Common operations

- `LogStartupInformation()` - Logs startup information, including the current time in the specified time zone, using the provided logger.
