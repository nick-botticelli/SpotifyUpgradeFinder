# SpotifyUpgradeFinder
Find download links for specific versions of Spotify (Windows). Use at your own risk.

# Using
SpotifyUpgradeFinder is a C# 4.5 Windows Console executable. It should be able to run by default on Windows 8 installations and above.

# Notes
* Newest online installer: https://download.scdn.co/SpotifySetup.exe
* Newest full installer: https://download.spotify.com/SpotifyFullSetup.exe

# Spotify Updates
Prevent Spotify from updating by performing the following commands:
>rm %localappdata%\Spotify\Update
>
>mkdir %localappdata%\Spotify\Update
>
>icacls %localappdata%\Spotify\Update /deny "%username%":D
>
>icacls %localappdata%\Spotify\Update /deny "%username%":R

# License
The MIT License (MIT)