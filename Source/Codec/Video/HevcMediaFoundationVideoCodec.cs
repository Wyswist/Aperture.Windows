﻿using System;
using System.IO;
using SharpDX.MediaFoundation;
using SharpDX.Multimedia;

namespace Aperture {
  /// <inheritdoc />
  /// <summary>
  ///   Defines a Media Foundation-based HEVC video codec
  /// </summary>
  public sealed class HevcMediaFoundationVideoCodec : MediaFoundationVideoCodec {
    /// <inheritdoc />
    /// <summary>
    ///   Class constructor
    /// </summary>
    /// <param name="width">Width, in pixels, of the frames to be fed to this encoder</param>
    /// <param name="height">Height, in pixels, of the frames to be fed to this encoder</param>
    /// <param name="destStream">Destination stream</param>
    public HevcMediaFoundationVideoCodec(int width, int height, Stream destStream)
      : base(
        width,
        height,
        destStream,
        TranscodeContainerTypeGuids.Mpeg4,
        VideoFormatGuids.FromFourCC(new FourCC("HEVC")),
        60,
        2_500_000) { }
  }
}