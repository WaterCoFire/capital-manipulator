# capital-manipulator

## What is this?

Each time the "touch the capital's cake" button is pressed, one of the following six outcomes will occur randomly (each with a 16.67% probability):

- Computer shuts down automatically
- Computer displays a fake BSOD
- Computer cursor starts jumping around
- Computer begins reciting "the truth of capitalism"
- Computer starts bombarding with pop-up windows
- Computer automatically plays Rickroll

Enjoy :)

## Publish (aka "Build")

In the project folder (the directory containing the `.csproj` file), execute:

```
dotnet publish -c Release -r win-x64 --self-contained true -o ./publish
```

Note: `--self-contained true` ensures the release package includes all runtime files, so others do not need to install .NET on their computers. (This makes it easier for capital to teach them a lesson!)
