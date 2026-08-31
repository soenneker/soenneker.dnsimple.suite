[![](https://img.shields.io/nuget/v/soenneker.dnsimple.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dnsimple.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dnsimple.suite/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dnsimple.suite/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dnsimple.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dnsimple.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dnsimple.suite/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dnsimple.suite/actions/workflows/codeql.yml)

# Soenneker.DNSimple.Suite

Registers the DNSimple contacts, delegation, domains, identity, and registrar packages together.

## Installation

```bash
dotnet add package Soenneker.DNSimple.Suite
```

## Configuration

```json
{
  "DNSimple": {
    "AccountId": 12345,
    "Token": "your-api-token",
    "Test": false
  }
}
```

Set `Test` to `true` to use DNSimple's sandbox. Registration and renewal workflows should be exercised against the sandbox before using production credentials.

## Registration

```csharp
using Soenneker.DNSimple.Suite.Registrars;

services.AddDNSimpleSuiteAsScoped();
```

This registers `IDNSimpleContactsUtil`, `IDNSimpleDelegationUtil`, `IDNSimpleDomainsUtil`, `IDNSimpleIdentityUtil`, and `IDNSimpleRegistrarUtil` as scoped services while their generated-client transport remains shared. Use `AddDNSimpleSuiteAsSingleton()` when all five wrappers should live for the application lifetime.

Install the individual package instead when an application needs only one area of DNSimple's API. The suite adds no separate facade; consumers inject the same interfaces exposed by its component packages.
