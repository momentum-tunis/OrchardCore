using System.Collections.Generic;
using System.Globalization;
using Microsoft.Extensions.Logging;
using SixLabors.ImageSharp.Web;
using SixLabors.ImageSharp.Web.Commands;
using SixLabors.ImageSharp.Web.Processors;

namespace OrchardCore.Media.Processing
{
    /// <summary>
    /// Pass through processor which allows inclusion of a version query string in the cache key.
    /// </summary>
    public class ImageVersionProcessor : IImageWebProcessor
    {
        /// <summary>
        /// The command constant for a version query string.
        /// </summary>
        public const string VersionCommand = "v";

        private static readonly IEnumerable<string> VersionCommands = new[] { VersionCommand };

        public IEnumerable<string> Commands
            => VersionCommands;

        public FormattedImage Process(FormattedImage image, ILogger logger, IDictionary<string, string> commands, CommandParser parser, CultureInfo culture)
            => image;
    }
}
