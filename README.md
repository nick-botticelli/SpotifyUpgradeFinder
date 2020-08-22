# SpotifyUpgradeFinder
[![.NET Core](https://github.com/nick-botticelli/SpotifyUpgradeFinder/workflows/.NET%20Core/badge.svg)](https://github.com/nick-botticelli/SpotifyUpgradeFinder/actions?query=workflow%3A%22.NET+Core%22)

Find download links for specific versions of Spotify (Windows). Use at your own risk.

## Using
SpotifyUpgradeFinder is a .NET Core Windows Console executable made in C#.

## Notes
* Newest online installer: https://download.scdn.co/SpotifySetup.exe
* Newest full installer: https://download.spotify.com/SpotifyFullSetup.exe

## Spotify Updates
Prevent Spotify from updating by performing the following commands:
>rm %localappdata%\Spotify\Update
>
>mkdir %localappdata%\Spotify\Update
>
>icacls %localappdata%\Spotify\Update /deny "%username%":D
>
>icacls %localappdata%\Spotify\Update /deny "%username%":R

## License
The MIT License (MIT)