using System;
using System.Net;
using System.Reflection;

namespace SpotifyUpgradeFinder
{
    class SpotifyUpgradeFinder
    {
        // Example: https://upgrade.scdn.co/upgrade/client/win32-x86/spotify_installer-1.0.92.390.g2ce5ec7d-18.exe
        static void Main(string[] args)
        {
            Console.WriteLine("=== SpotifyUpgradeFinder v" + Assembly.GetExecutingAssembly().GetName().Version.ToString() + " ===\n\n");

            Init();

            Console.WriteLine("\nProgram has finished. Press Enter to exit.");
            Console.ReadLine();
        }

        static void Init()
        {
            Console.Write("Enter the full Spotify version to find (e.g. \"1.1.26.501.gbe11e53b\": ");
            string versionInput = Console.ReadLine();

            Console.Write("Enter the number to start at (e.g. \"10\"): ");
            string startNumInput = Console.ReadLine();
            int startNum = Int32.Parse(startNumInput);

            Console.Write("Enter the number to stop at (e.g. \"99\"): ");
            string stopNumInput = Console.ReadLine();
            int stopNum = Int32.Parse(stopNumInput);

            Console.WriteLine();

            for (int i = startNum; i <= stopNum; i++)
            {
                string url = "https://upgrade.scdn.co/upgrade/client/win32-x86/spotify_installer-" + versionInput + "-" + i + ".exe";
                Console.WriteLine("Trying " + versionInput + "-" + i);

                Uri uri = new Uri(url);
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);

                try
                {
                    HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();

                    // Don't stop on first found; 1.1.26, for example, had 2 different downloads for numbers 19 and 21.
                    if (webResponse.StatusCode == HttpStatusCode.OK)
                        Console.WriteLine("Found: " + url);

                    webResponse.Close();
                }
                catch (Exception) { }
            }
        }
    }
}
