using System;
using System.IO;

namespace Aperture {
  /// <inheritdoc />
  /// <summary>
  ///   Implements the logic behind a still image encoder.
  /// </summary>
  public abstract class StillImageCodec : Codec {
    /// <summary>
    ///   Indicates whether a frame has been fed to the encoder.
    /// </summary>
    private bool frameFed;

    /// <inheritdoc />
    /// <summary>
    ///   Class constructor
    /// </summary>
    protected StillImageCodec(int width, int height, Stream destStream) : base(width, height, destStream) { }

    /// <inheritdoc />
    /// <summary>
    ///   Instructs the encoder to begin accepting frames
    /// </summary>
    /// <remarks>
    ///   This method is not relevant to the <see cref="StillImageCodec"/> class
    /// </remarks>
    public sealed override void Start() {}

    /// <inheritdoc />
    /// <summary>
    ///   Encodes a single frame and writes the output to the destination stream.
    /// </summary>
    /// <remarks>
    ///   Only call the base method upon successful encoding of the frame. The class will be locked after a frame has
    ///   been encoded succesfully.
    /// </remarks>
    public override void Feed() {
      if (this.frameFed) {
        throw new InvalidOperationException("The encoder does not accept multiple frames");
      }

      this.frameFed = true;
    }
  }
}