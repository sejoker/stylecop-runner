# stylecop-runner

Project influenced by [StyleCop.Console](https://github.com/Nylle/StyleCop.Console). The main difference: it is using awesome [scriptcs](https://github.com/scriptcs/scriptcs) instead of C#. That means you could skip compilation step and start StyleCop your project with less friction.

## Getting scriptcs

Releases and nightly builds should be installed using [Chocolatey](http://chocolatey.org/). To install Chocolatey, execute the following command in your command prompt:

    @powershell -NoProfile -ExecutionPolicy Unrestricted -Command "iex ((New-Object Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET PATH=%PATH%;%systemdrive%\chocolatey\bin

If the above fails with the error indicating that proxy authentication is required (i.e. [HTTP 407](http://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html#sec10.4.8)) then try again with the following on the command prompt that uses your default credentials:

    @powershell -NoProfile -ExecutionPolicy Unrestricted -Command "[Net.WebRequest]::DefaultWebProxy.Credentials = [Net.CredentialCache]::DefaultCredentials; iex ((New-Object Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET PATH=%PATH%;%systemdrive%\chocolatey\bin

### Installing scriptcs

Once Chocolatey has been installed, you can install the latest stable version of scriptcs from your command prompt:

    cinst scriptcs

Chocolatey will install scriptcs to `%LOCALAPPDATA%\scriptcs\` and update your PATH accordingly.

**Note:** You may need to restart your command prompt after the installation completes.

## Getting Started

Run `scriptcs -install` to install required packages

Run `scriptcs runner.csx -- -project-path "path/to/your/cs/project"` to get a static code analysis with StyleCop's default rules.

To *not* analyse subdirectories recursively add the argument switch `-not-recursively`.

## Rules

### Default Rules

To deactivate default rules, edit the file `Settings.StyleCop` with the `StyleCopSettingsEditor.exe` or pass your existing settings file via command line argument:

```Shell
scriptcs runner.csx -- -settings-location "path/to/your/Settings.StyleCop" -project-path "path/to/your/cs/project"
```

### Custom Rules

WIP

Further reading: [How to Create StyleCop Custom Rule](https://stylecopplus.codeplex.com/wikipage?title=How%20to%20Create%20StyleCop%20Custom%20Rule)

## All Command Line Arguments

- Show help screen: `-help` or `-?`
- Specify project path: `-project-path <path>` or `-p <path>`
- Custom settings file: `-settings-location <path>` or `-s <path>`
- Do not analyse subdirectories: `-not-recursively` or `-n`