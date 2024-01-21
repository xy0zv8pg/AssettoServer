﻿using System.Diagnostics;

namespace AssettoServer.Utils;

public static class ProcessHelper
{
    public static void OpenURL(string url)
    {
        url = url.Replace("&", "^&");
        Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
    }
}
