[![](https://img.shields.io/nuget/v/soenneker.extensions.logger.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.logger/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.logger/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.logger/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.logger.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.logger/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.logger/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.logger/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Logger
Writes a compact startup timestamp block through `ILogger`.

## Installation

```bash
dotnet add package Soenneker.Extensions.Logger
```

## Usage

```csharp
using Soenneker.Extensions.Logger;

TimeZoneInfo eastern = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
logger.LogStartupInformation(eastern);
```

`LogStartupInformation()` emits three `Debug` messages: an opening marker, the current UTC time converted to the supplied time zone, and a closing marker. The timestamp uses the Soenneker precise date format.

The text labels the time as `ET` regardless of which `TimeZoneInfo` is supplied, so pass an Eastern time zone if the label must be accurate. Nothing is written when Debug logging is disabled. Both arguments must be non-null.
