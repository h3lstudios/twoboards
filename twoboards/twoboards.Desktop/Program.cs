using osu.Framework.Platform;
using osu.Framework;
using twoboards.Game;

namespace twoboards.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableDesktopHost(@"twoboards"))
            using (osu.Framework.Game game = new twoboardsGame())
                host.Run(game);
        }
    }
}
