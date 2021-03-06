﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.MovieTexture
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System.Runtime.CompilerServices;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Movie Textures are textures onto which movies are played back.</para>
  /// </summary>
  public sealed class MovieTexture : Texture
  {
    /// <summary>
    ///   <para>Returns the AudioClip belonging to the MovieTexture.</para>
    /// </summary>
    public AudioClip audioClip { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Set this to true to make the movie loop.</para>
    /// </summary>
    public bool loop { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Returns whether the movie is playing or not.</para>
    /// </summary>
    public bool isPlaying { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>If the movie is downloading from a web site, this returns if enough data has been downloaded so playback should be able to start without interruptions.</para>
    /// </summary>
    public bool isReadyToPlay { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>The time, in seconds, that the movie takes to play back completely.</para>
    /// </summary>
    public float duration { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Starts playing the movie.</para>
    /// </summary>
    public void Play()
    {
      MovieTexture.INTERNAL_CALL_Play(this);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_Play(MovieTexture self);

    /// <summary>
    ///   <para>Stops playing the movie, and rewinds it to the beginning.</para>
    /// </summary>
    public void Stop()
    {
      MovieTexture.INTERNAL_CALL_Stop(this);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_Stop(MovieTexture self);

    /// <summary>
    ///   <para>Pauses playing the movie.</para>
    /// </summary>
    public void Pause()
    {
      MovieTexture.INTERNAL_CALL_Pause(this);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_Pause(MovieTexture self);
  }
}
