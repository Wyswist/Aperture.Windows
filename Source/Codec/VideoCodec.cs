using System.IO;

namespace Aperture {
  /// <inheritdoc />
  /// <summary>
  ///   Implements the logic behind a video encoder.
  /// </summary>
  public abstract class VideoCodec : Codec {
    /// <inheritdoc />
    /// <summary>
    ///   Class constructor
    /// </summary>
    protected VideoCodec(int width, int height, Stream destStream) : base(width, height, destStream) { }
  }
}