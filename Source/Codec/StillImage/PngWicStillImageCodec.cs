using System.IO;
using SharpDX.WIC;

namespace Aperture {
  /// <inheritdoc />
  /// <summary>
  ///   Implements a WIC-enabled PNG image codec
  /// </summary>
  [DisplayName("PNG")]
  [MediaType("image/png", "png")]
  public sealed class PngWicStillImageCodec : WicStillImageCodec {
    /// <inheritdoc />
    /// <summary>
    ///   Class constructor
    /// </summary>
    /// <param name="width">Capture width, in pixels</param>
    /// <param name="height">Capture height, in pixels</param>
    /// <param name="destStream">Destination stream</param>
    public PngWicStillImageCodec(int width, int height, Stream destStream) : base(
      width, height, destStream, ContainerFormatGuids.Png) {
      /* that's all folks! */
    }
  }
}