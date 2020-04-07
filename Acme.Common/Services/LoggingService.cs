using System;
using System.Collections.Generic;
using System.IO;
using Acme.Common.Interfaces;

namespace Acme.Common.Services {
    public static class LoggingService {
        public static void WriteToFile (string path, List<ILoggable> loggables) {

            var filePath = $"{path}.txt";

            if (!File.Exists (filePath))
                File.CreateText (filePath);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter (filePath, true)) {
                foreach (var loggable in loggables) {
                    // calling log() here is an example of polymorphism.
                    file.WriteLine ($"{DateTime.Now.ToString("s")}: {loggable.Log()}"); 
                }
            }
        }
    }
}