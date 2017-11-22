This application is to help diagnose a crash on startup issue on an installed machine, especially when all you get out of the event log is a generic error.

To use run the CrashCatcher and drag the offending .exe onto it. It will launch the .exe with Process.Start catching any exceptions and information from stderror and report it in the window.